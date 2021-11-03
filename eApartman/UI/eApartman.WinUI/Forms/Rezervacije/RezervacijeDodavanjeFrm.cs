using eApartman.Model;
using eApartman.Model.Requests;
using eApartman.WinUI.Helpers;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eApartman.WinUI.Forms.Rezervacije
{
    public partial class RezervacijeDodavanjeFrm : MaterialForm
    {
        private readonly APIService _apiRezervacija = new APIService("Rezervacije");
        private readonly APIService _apiApartmani = new APIService("Apartmani");
        public RezervacijeDodavanjeFrm()
        {
            InitializeComponent();

        }
        private void Loading(bool state)
        {
            state=!state;
            foreach(Control control in this.Controls)
            {
                control.Enabled = state;
            }
        }

        private async void RezervacijeDodavanjeFrm_Load(object sender, EventArgs e)
        {
            Loading(true);
            try
            {

                await LoadData();
            }
            catch(Exception error)
            {
                MessageBox.Show($"Server trenutno nije dostupan... Greška: \n{error.Message}");
                this.Close();
            }
            Loading(false);
        }
        private void LoadDatumi()
        {
            dtOd.MinDate = DateTime.Today;
            dtDo.MinDate = dtOd.Value.AddDays(1);
            dtOd.Value = DateTime.Today;
        }
        private async Task LoadData()
        {
            await LoadApartmani();
            LoadDatumi();
            LoadKorisnik();
        }
        private void LoadKorisnik()
        {
            var korisnik = APIService.Korisnik;
            if (korisnik.Slika.Count() != 0)
                pbUser.Image = ImageBytesConverter.BytesToImage(korisnik.Slika);
        }
        private async Task LoadApartmani()
        {
            ApartmanSearchObject search = new ApartmanSearchObject()
            {
                IncludeRezervacije = true,
                VlasnikId = APIService.Korisnik.GetVlasnikId()
            };
            var apartmani = await _apiApartmani.Get<List<Apartman>>(search);
            cmbApartman.DataSource = apartmani;
            cmbApartman.ValueMember = "ApartmanId";
            cmbApartman.DisplayMember = "Naziv";
            cmbApartman.SelectedIndex = 0;
        }

        private void cmbApartman_SelectedIndexChanged(object sender, EventArgs e)
        {
            var apartman = cmbApartman.Items[cmbApartman.SelectedIndex] as Apartman;
            sldOsoba.Value = 0;
            sldOsoba.RangeMax = apartman.MaxOsoba;
            sldOsoba.ValueMax = apartman.MaxOsoba;
            CheckApartmanStatus(apartman);
        }
        private void CheckApartmanStatus(Apartman apartman)
        {
            bool status = ApartmanSlobodan(apartman);
            if(status)
            {
                txtStatus.Text = "Slobodan";
                txtStatus.ForeColor = Color.DarkOliveGreen;
                btnSave.Enabled = true;
            }
            else
            {
                txtStatus.Text = "Zauzet";
                txtStatus.ForeColor = Color.Maroon;
                btnSave.Enabled = false;
            }
        }
        private bool ApartmanSlobodan(Apartman apartman)
        {
            var checkin = dtOd.Value.Date;
            var checkout = dtDo.Value.Date;
            var set=apartman.Rezervacijas
                .Where(r => 
                (r.DatumCheckIn>=checkin && r.DatumCheckOut<=checkout) 
                ||
                (r.DatumCheckIn<=checkin && r.DatumCheckOut>=checkout
                && 
                r.DatumCheckOut>checkin && r.DatumCheckIn<checkout)
                ||
                (r.DatumCheckIn<=checkin && r.DatumCheckOut<=checkout
                && r.DatumCheckOut>checkin)
                ||
                (r.DatumCheckIn>=checkin && r.DatumCheckOut>=checkout 
                && r.DatumCheckIn<checkout))
                .Where(r => r.Otkazana==false);

            return !set.Any();
        }

        private void dtOd_ValueChanged(object sender, EventArgs e)
        {
            //Check-out datum uvijek mora biti makar dan nakon check-in datuma
            if (dtOd.Value.Date >= dtDo.Value.Date)
                dtDo.Value = dtOd.Value.Date.AddDays(1);

            var apartman = cmbApartman.Items[cmbApartman.SelectedIndex] as Apartman;
            CheckApartmanStatus(apartman);
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {   
            Loading(true);
            try
            {
                HandleErrors();
                var obj = cmbApartman.SelectedValue;
                int id=int.Parse(obj.ToString());
                var apartman = cmbApartman.Items[cmbApartman.SelectedIndex] as Apartman;
                int dana = int.Parse((dtDo.Value.Date - dtOd.Value.Date).TotalDays.ToString());
                decimal cijena = apartman.Cijena * dana;
                RezervacijaInsertRequest request = new RezervacijaInsertRequest()
                {
                    ApartmanId = id,
                    BrojDana = dana,
                    DatumCheckIn = dtOd.Value.Date,
                    DatumCheckOut = dtDo.Value.Date,
                    BrojOsoba = sldOsoba.Value,
                    Poruka = $"Rezervaciju dodao stanodavac.",
                    Cijena = cijena,
                    GostIme = txtIme.Text,
                    GostPrezime = txtPrezime.Text,
                    DatumRezervacije = DateTime.Now
                };
                await _apiRezervacija.Insert<Rezervacija>(request);
                MessageBox.Show("Rezervacija dodana!");
                this.Close();
            }
            catch(Exception error)
            {
                MessageBox.Show(error.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Loading(false);
            }
        }
        public void HandleErrors()
        {
            if (txtIme.Text== "" || txtPrezime.Text == "")
                throw new Exception("Ime i prezime se moraju unijeti!");
            if(sldOsoba.Value==0)
                throw new Exception("Obavezno odabrati broj osoba!");
        }
    }
}
