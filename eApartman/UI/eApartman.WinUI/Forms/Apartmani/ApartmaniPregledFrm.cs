using eApartman.Model;
using eApartman.Model.Requests;
using eApartman.WinUI.Helpers;
using MaterialSkin;
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

namespace eApartman.WinUI.Forms.Apartmani
{
    public partial class ApartmaniPregledFrm : MaterialForm
    {
        private APIService _service = new APIService("Apartmani");
        private APIService _serviceTip = new APIService("ApartmaniTip");
        public ApartmaniPregledFrm()
        {
            InitializeComponent();
            dgvApartmani.AutoGenerateColumns = false;
        }

        private async void ApartmaniPregledFrm_Load(object sender, EventArgs e)
        {
            try
            {
                await LoadData();
            }
            catch
            {
                MessageBox.Show("Došlo je do greške", "Greška", MessageBoxButtons.OK,
                     MessageBoxIcon.Error);
            }
        }

        private async void btnPretrazi_Click(object sender, EventArgs e)
        {
            await LoadApartmani();   
        }
        private async Task LoadApartmani()
        {
            ApartmanSearchObject request = new ApartmanSearchObject()
            {
                VlasnikId = APIService.Korisnik.KorisnikId,
            };

            if (txtNaziv.Text != "") request.Naziv = txtNaziv.Text;
            if (cmbApartmanTip.SelectedIndex > 0) request.Tip = (cmbApartmanTip.Items[cmbApartmanTip.SelectedIndex] as ApartmanTip).ApartmanTipNaziv;

            dgvApartmani.DataSource = await _service.Get<List<Apartman>>(request);
        }
        private async Task LoadApartmaniTip()
        {

  
            var tipovi = await _serviceTip.Get<List<ApartmanTip>>();
            tipovi.Insert(0, new ApartmanTip() { ApartmanTipNaziv="Svi"});
            cmbApartmanTip.DataSource = tipovi;
            cmbApartmanTip.DisplayMember = "ApartmanTipNaziv";
            cmbApartmanTip.ValueMember = "ApartmanTipId";

            cmbApartmanTip.Hint = "Tip apartmana";
        }
        public async Task LoadData()
        {
            btnPretrazi.Enabled = false;
            await LoadApartmani();
            await LoadApartmaniTip();
            btnPretrazi.Enabled = true;
        }



        private async void btnDodaj_Click(object sender, EventArgs e)
        {
            ApartmaniDodavanjeFrm frm = new ApartmaniDodavanjeFrm();
            //frm.MdiParent = this.MdiParent;
            frm.ShowDialog();
            await LoadApartmani();
        }

        private async void dgvApartmani_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Apartman apartman=dgvApartmani.SelectedRows[0].DataBoundItem as Apartman;
            ApartmaniDodavanjeFrm frm = new ApartmaniDodavanjeFrm(apartman);
            //frm.MdiParent = this.MdiParent;
            frm.ShowDialog();
            await LoadApartmani();
        }

        private async void dgvApartmani_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            byte[] imgStream = (dgvApartmani.SelectedRows[0].DataBoundItem as Apartman).SlikaProfilnaFile;
            Image img = ImageBytesConverter.BytesToImage(imgStream);
            pbApartman.Image = img;
            
            if(e.ColumnIndex==dgvApartmani.ColumnCount-1)
            {
                await DeleteApartman();
            }
        }
        public async Task DeleteApartman()
        {
            Apartman apartman = dgvApartmani.SelectedRows[0].DataBoundItem as Apartman;
            if (MessageBox.Show($"Želite li potvrditi brisanje apartmana {apartman.Naziv}", "Pitanje", MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
                Apartman obrisan = await _service.Delete<Apartman>(apartman.ApartmanId);
                MessageBox.Show($"Apartman {obrisan.Naziv} je obrisan.");
            }
        }
    }
}
