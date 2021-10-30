using eApartman.Model;
using eApartman.Model.Requests;
using eApartman.WinUI.Helpers;
using eApartman.WinUI.Parameters;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eApartman.WinUI.Forms.Apartmani
{
    public partial class ApartmaniDodavanjeFrm : MaterialForm
    {
        private readonly APIService _serviceAdrese;
        private readonly APIService _serviceDrzave;
        private readonly APIService _serviceApartmani;
        private readonly APIService _serviceSlike;
        private readonly APIService _serviceApartmaniTip;
        private readonly Apartman _apartman;
        private readonly List<Image> _slike;
        private int slikaIndex = 0;
        public ApartmaniDodavanjeFrm(Apartman apartman=null)
        {
            InitializeComponent();
            _serviceAdrese = new APIService("Adrese");
            _serviceDrzave = new APIService("Drzava");
            _serviceApartmani = new APIService("Apartmani");
            _serviceSlike = new APIService("Slike");
            _serviceApartmaniTip = new APIService("ApartmaniTip");
            _apartman = apartman;
            _slike = new List<Image>();

            ofdSlika.Filter = "Images (*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|" +
            "All files (*.*)|*.*";
            ofdGalerija.Filter= "Images (*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|" +
            "All files (*.*)|*.*";
            ofdGalerija.Multiselect = true;
        }

        private async void ApartmaniDodavanjeFrm_Load(object sender, EventArgs e)
        {
            try
            {
                txtUsername.Text = APIService.Korisnik.Username;

                SwitchComboBoxes(false);

                await LoadData();
                
                SwitchComboBoxes(true);

            }
            catch
            {
                MessageBox.Show("Aplikacija se nije uspjela povezati na server. Pokušajte kasnije...");
            }
           
        }

        private void cmbDrzava_SelectedIndexChanged(object sender, EventArgs e)
        {
            var drzava = cmbDrzava.Items[cmbDrzava.SelectedIndex] as Drzava;
            if(drzava!=null)
            {
                var gradovi = drzava.Grads.OrderBy(g => g.Naziv).ToList();
                LoadGradovi(gradovi);
            }              
        }

        private void txtNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private async Task LoadDrzave()
        {
            DrzavaSearchObject search = new DrzavaSearchObject()
            {
                IncludeGradovi=true
            };
            cmbDrzava.DataSource= await _serviceDrzave.Get<List<Drzava>>(search);
            cmbDrzava.DisplayMember = "Naziv";
            cmbDrzava.ValueMember = "DrzavaId";
            cmbDrzava.SelectedIndex = 0;


        }
        private void LoadGradovi(object gradovi)
        {
            cmbGrad.DataSource = gradovi as List<Grad>;
            cmbGrad.DisplayMember = "Naziv";
            cmbGrad.ValueMember = "GradId";
        }
        private async Task LoadApartmaniTip()
        {
            cmbTipApartmana.DataSource= await _serviceApartmaniTip.Get<List<ApartmanTip>>();
            cmbTipApartmana.ValueMember = "ApartmanTipId";
            cmbTipApartmana.DisplayMember = "ApartmanTipNaziv";
            cmbTipApartmana.SelectedIndex = 0;
            cmbTipApartmana.Enabled = true;
        }
        private void SwitchComboBoxes(bool state)
        {
            cmbGrad.Enabled = state;
            cmbDrzava.Enabled = state;
            cmbTipApartmana.Enabled = state;
        }

        private async Task LoadData()
        {
            cmbDrzava.Hint = "Loading Države...";
            cmbGrad.Hint = "Loading Gradovi...";
            cmbTipApartmana.Hint = "Loading Tipovi...";
            btnPrev.Enabled = false;
            btnNext.Enabled = false;

            await LoadApartmaniTip();
            await LoadDrzave();
            if (_apartman != null)
            {
                LoadApartman();
                await LoadSlike();
            }
        }
        private void LoadApartman()
        {
            txtNaziv.Text = _apartman.Naziv;
            cmbDrzava.SelectedValue = _apartman.DrzavaId;
            cmbGrad.SelectedValue = _apartman.GradId;
            txtAdresa.Text = _apartman.AdresaNaziv;
            txtBroj.Text = _apartman.Adresa.Broj.ToString();
            txtCijena.Text = _apartman.CijenaInt.ToString();
            cmbTipApartmana.SelectedValue = _apartman.ApartmanTipId;
            txtOsoba.Text = _apartman.MaxOsoba.ToString();
            cbBalkon.Checked = _apartman.ImaBalkon;
            cbParking.Checked = _apartman.ImaParking;
            pbSlika.Image = ImageBytesConverter.BytesToImage(_apartman.SlikaProfilnaFile);
        }

        private void btnSlika_Click(object sender, EventArgs e)
        {
            try
            {
                var result = ofdSlika.ShowDialog();
                if (result == DialogResult.OK)
                {
                    var fileName = ofdSlika.FileName;
                    pbSlika.Image = Image.FromFile(fileName);

                    if (_slike.Count > 0) _slike.RemoveAt(0);
                    _slike.Insert(0, pbSlika.Image);

                    CheckGalleryButtons();
                }
            }
            catch
            {
                MessageBox.Show("Pogrešan format fajla!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ofdSlika.FileName = "";
            }
        }

        private async void btnSacuvaj_Click(object sender, EventArgs e)
        {
            Loading(true);
            try
            {
                Adresa adresa = await GetAdresa();
                int apartmanTipId = GetAdresaTip();
                byte[] file;

                //Slika handling
                if (ofdSlika.FileName != "")
                    file = File.ReadAllBytes(ofdSlika.FileName);
                else if (_apartman != null)
                    file = _apartman.SlikaProfilnaFile;
                else
                    throw new Exception("Obavezno dodavanje profilne slike!");


                ApartmanUpsertRequest request = new ApartmanUpsertRequest()
                {
                    VlasnikId = APIService.Korisnik.GetVlasnikId(),
                    Naziv = txtNaziv.Text,
                    AdresaId = adresa.AdresaId,
                    ApartmanTipId=apartmanTipId,
                    ImaBalkon = cbBalkon.Checked,
                    ImaParking = cbParking.Checked,
                    SlikaProfilnaFile =file,
                    Cijena = decimal.Parse(txtCijena.Text),
                    MaxOsoba = int.Parse(txtOsoba.Text),
                    CheckoutVrijeme = new TimeSpan(12, 0, 0),
                    PetFriendly = false    
                };

                //UPDATE/PUT METODA
                if(_apartman==null)
                {
                    var apartman = await _serviceApartmani.Insert<Apartman>(request);
                    await SaveSlike(apartman);
                    MessageBox.Show($"Apartman {apartman.Naziv} dodan!");
                }

                //INSERT/POST METODA
                else
                {
                    var apartman = await _serviceApartmani.Update<Apartman>(_apartman.ApartmanId, request);
                    await SaveSlike(apartman);
                    MessageBox.Show($"Apartman {apartman.Naziv} ažuriran!");
                }

                DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Loading(false);
            }

                        
        }

        void Loading(bool state)
        {
            txtNaslov.Text = state ? "Loading..." : "Dodavanje apartmana";
            state = !state;
            foreach(Control control in this.Controls)
            {
                control.Enabled = state;
            }
            CheckGalleryButtons();
        }
        private int GetAdresaTip()
        {
            object objId = cmbTipApartmana.SelectedValue;
            int id = int.Parse(objId.ToString());
            return id;
        }
        private async Task<Adresa> GetAdresa()
        {
            Adresa adresa= await PostojiLiAdresa();
            if(adresa==null)
            {
                var objId = cmbGrad.SelectedValue;
                int gradId = int.Parse(objId.ToString());

                var novaAdresa = new AdresaUpsertRequest()
                {
                    Naziv = txtAdresa.Text,
                    Broj = int.Parse(txtBroj.Text),
                    GradId = gradId
                };

                adresa=await _serviceAdrese.Insert<Adresa>(novaAdresa);
            }

            return adresa;
        }
        private async Task<Adresa> PostojiLiAdresa()
        {
            AdresaSearchObject searchAdresa = new AdresaSearchObject()
            {
                Naziv = txtAdresa.Text,
                Broj = int.Parse(txtBroj.Text)
            };

            var result = await _serviceAdrese.Get<List<Adresa>>(searchAdresa);
            Adresa adresa = result.SingleOrDefault();

            return adresa;
        }

        private async void btnDodajGrad_Click(object sender, EventArgs e)
        {
            var parameters = new ApartmaniGradoviFrmParameters()
            {
                SelectedIndexGrad = 0,
                CmbDrzave=cmbDrzava
            };
            ApartmaniGradoviFrm frm = new ApartmaniGradoviFrm(parameters);
            frm.ShowDialog();

            if(frm.DialogResult==DialogResult.OK)
            {               
                try
                {
                    await ReloadGradSelection(parameters);
                }
                catch
                {
                    this.Refresh();
                }

            }
        }
        public async Task ReloadGradSelection(ApartmaniGradoviFrmParameters parameters)
        {
            object selectedValue = parameters.CmbDrzave.SelectedValue;
            await LoadDrzave();
            cmbDrzava.SelectedValue = selectedValue;
            cmbGrad.SelectedValue = parameters.SelectedIndexGrad;
        }

        private void btnGalerija_Click(object sender, EventArgs e)
        {
            var result=ofdGalerija.ShowDialog();
            try
            {
                if (result == DialogResult.OK)
                {
                    string[] filenames = ofdGalerija.FileNames;
                    txtGalerijaCount.Text = filenames.Count().ToString();
                    foreach (string filename in filenames)
                    {
                        _slike.Add(Image.FromFile(filename));
                    }
                    CheckGalleryButtons();
                }
            }
            catch
            {
                MessageBox.Show("Pogrešan format fajla!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ofdSlika.FileName = "";
            }
        }

        private async Task LoadSlike()
        {
            ApartmanSlikaSearchObject search = new ApartmanSlikaSearchObject() 
            { 
                ApartmanSlikaId=_apartman.ApartmanId
            };
            var slike=await _serviceSlike.Get<List<ApartmanSlika>>(search);
           
            _slike.Add(ImageBytesConverter.BytesToImage(_apartman.SlikaProfilnaFile));

            foreach (var slika in slike)
            {
                var file = ImageBytesConverter.BytesToImage(slika.SlikaFile);
                _slike.Add(file);
            }
            pbSlika.Image = _slike[slikaIndex];
            CheckGalleryButtons();
        }
        private async Task SaveSlike(Apartman apartman)
        {
            List<ApartmanSlikaInsertRequest> slike=new List<ApartmanSlikaInsertRequest>();

            //Dodavanje profilne slike u listu
            if(ofdSlika.FileName!="")
            {
                byte[] fileProfilna = File.ReadAllBytes(ofdSlika.FileName);
                ApartmanSlikaInsertRequest profilna = new ApartmanSlikaInsertRequest()
                {
                    SlikaFile = fileProfilna,
                    ApartmanId = apartman.ApartmanId
                };
                slike.Add(profilna);
            }


            //Dodavanje galerije slika u listu 
            foreach(string filename in ofdGalerija.FileNames)
            {
                byte[] file = File.ReadAllBytes(filename);
                ApartmanSlikaInsertRequest slika = new ApartmanSlikaInsertRequest()
                {
                    SlikaFile = file,
                    ApartmanId = apartman.ApartmanId
                };
                slike.Add(slika);
            }

            //Slanje liste slika na API ako ima novih slika
            try
            {
                if (slike.Count > 0)
                    await _serviceSlike.Insert<ApartmanSlika>(slike);
            }
            catch
            {
                MessageBox.Show("Server nije dostupan!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            slikaIndex--;
            pbSlika.Image = _slike[slikaIndex];
            CheckGalleryButtons();
        }
        private void CheckGalleryButtons()
        {
            btnPrev.Enabled = slikaIndex > 0;
            btnNext.Enabled = slikaIndex < _slike.Count - 1;

            if(_apartman!=null)// UPDATE - profilna je već učitana iz baze case
                txtProfilna.Text = slikaIndex == 0? "Profilna slika" : "";
            else // INSERT - još nije učitana profilna case
                txtProfilna.Text = slikaIndex == 0 && ofdSlika.FileName!=""? "Profilna slika" : "";

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            slikaIndex++;
            pbSlika.Image = _slike[slikaIndex];
            CheckGalleryButtons();
        }
    }
}
