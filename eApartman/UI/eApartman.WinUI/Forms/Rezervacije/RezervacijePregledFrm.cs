using eApartman.Model;
using eApartman.Model.Requests;
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
    public partial class RezervacijePregledFrm : MaterialForm
    {
        private readonly APIService _api = new APIService("Rezervacije");
        public RezervacijePregledFrm()
        {
            InitializeComponent();
            dgvApartmani.AutoGenerateColumns = false;
        }
        private async void RezervacijePregledFrm_Load(object sender, EventArgs e)
        {
            try
            {
                calendar.SelectionStart = DateTime.Today;
                txtDatum.Text = calendar.SelectionStart.ToString("d.M.yyyy");

                await LoadRezervacije();
            }
            catch
            {
                MessageBox.Show("Greška");
            }
        }
        private async Task LoadRezervacije()
        {
            //bool izvrsena = calendar.SelectionStart.Date < DateTime.Today;
            RezervacijaSearchObject request = new RezervacijaSearchObject()
            {
                IncludeList = new string[]{ "Apartman.Adresa" },
                Datum = calendar.SelectionStart,
                VlasnikId = APIService.Korisnik.GetVlasnikId(),
                Otkazana = cbOtkazane.Checked
            };
            dgvApartmani.DataSource = await _api.Get<List<Rezervacija>>(request);
        }
        private async void dgvApartmani_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex==7)
            {
                if (MessageBox.Show("Želite li potvrditi otkazivanje rezervacije?", "Otkazivanje", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    var rezervacija = dgvApartmani.SelectedRows[0].DataBoundItem as Rezervacija;
                    if(rezervacija.Otkazana)
                    {
                        MessageBox.Show($"Rezervacija gosta {rezervacija.GostIme} {rezervacija.GostPrezime} je već otkazana!");
                    }
                    else
                    {
                        var result = await OtkaziRezervaciju(rezervacija);
                        MessageBox.Show($"Rezervacija gosta {result.GostIme} {result.GostPrezime} otkazana!");
                    }
                }
            }
        }
        public async Task<Rezervacija> OtkaziRezervaciju(Rezervacija rezervacija)
        {
            RezervacijaUpdateRequest request = new RezervacijaUpdateRequest()
            {
                DatumCheckIn = rezervacija.DatumCheckIn,
                DatumCheckOut = rezervacija.DatumCheckOut,
                Izvrsena = false,
                Otkazana = true
            };
            return await _api.Update<Rezervacija>(rezervacija.RezervacijaId, request);
        }

        private async void calendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            txtDatum.Text = calendar.SelectionStart.ToString("d.M.yyyy");
            await LoadRezervacije();
        }

        private async void cbOtkazane_CheckedChanged(object sender, EventArgs e)
        {
            await LoadRezervacije();
            if (cbOtkazane.Checked)
                dgvApartmani.BackgroundColor = Color.LightPink;
            else
                dgvApartmani.BackgroundColor = Color.White;
        }

        private async void btnDodaj_Click(object sender, EventArgs e)
        {
            RezervacijeDodavanjeFrm frm = new RezervacijeDodavanjeFrm();
            frm.ShowDialog();
            await LoadRezervacije();
        }
    }
}
