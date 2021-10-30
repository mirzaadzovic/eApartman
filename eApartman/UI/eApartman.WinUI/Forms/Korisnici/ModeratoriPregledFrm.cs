using eApartman.Model;
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

namespace eApartman.WinUI.Forms.Korisnici
{
    public partial class ModeratoriPregledFrm : MaterialForm
    {
        private readonly APIService _api = new APIService("Moderatori");
        public ModeratoriPregledFrm()
        {
            InitializeComponent();
            dgvModeratori.AutoGenerateColumns = false;
        }

        private void txtNaziv_TextChanged(object sender, EventArgs e)
        {

        }

        private async void ModeratoriPregledFrm_Load(object sender, EventArgs e)
        {
            await LoadData();
        }
        private async Task LoadData()
        {
            VlasnikModerator request = new VlasnikModerator()
            {
                VlasnikId = APIService.Korisnik.KorisnikId
            };
            List<Korisnik> moderatori = await _api.Get<List<Korisnik>>(request);
            dgvModeratori.DataSource = moderatori;
        }
    }
}
