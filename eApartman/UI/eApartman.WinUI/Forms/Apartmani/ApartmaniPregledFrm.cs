using eApartman.Model;
using eApartman.Model.Requests;
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
        public ApartmaniPregledFrm()
        {
            InitializeComponent();
          
        }

        private async void ApartmaniPregledFrm_Load(object sender, EventArgs e)
        {
            try
            {
                ApartmanSearchObject request = new ApartmanSearchObject()
                {
                    VlasnikId = APIService.Korisnik.KorisnikId
                };
                LoadKorisnik();
                dgvApartmani.DataSource = await LoadApartmani(request);
            }
            catch
            {
                MessageBox.Show("Došlo je do greške", "Greška", MessageBoxButtons.OK,
                     MessageBoxIcon.Error);
            }
            

        }

        private async void btnPretrazi_Click(object sender, EventArgs e)
        {
            if(txtNaziv.Text!="")
            {
                ApartmanSearchObject request = new ApartmanSearchObject()
                {
                    VlasnikId = APIService.Korisnik.KorisnikId,
                    Naziv = txtNaziv.Text
                };
                dgvApartmani.DataSource = await LoadApartmani(request);
            }
        }
        private async Task<List<Apartman>> LoadApartmani(ApartmanSearchObject request)
        {
            return await _service.Get<List<Apartman>>(request);
        }
        private void LoadKorisnik()
        {
            txtUsername.Text = APIService.Korisnik.Username;
            
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            ApartmaniDodavanjeFrm frm = new ApartmaniDodavanjeFrm();
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }
    }
}
