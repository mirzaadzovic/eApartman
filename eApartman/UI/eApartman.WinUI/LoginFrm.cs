using eApartman.Model;
using eApartman.Model.Requests;
using eApartman.UI.Forms;
using eApartman.WinUI.Forms;
using eApartman.WinUI.Forms.Apartmani;
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

namespace eApartman.WinUI
{
    public partial class LoginFrm : MaterialForm
    {
        private readonly APIService _api = new APIService("Korisnici");
        private readonly APIService _apiUloge = new APIService("KorisnikUloge");
        public LoginFrm()
        {
            InitializeComponent();
           
        }
        private void linkRegisster_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form register = new RegisterFrm();
            register.ShowDialog();
            if(APIService.Korisnik!=null)
            {
                var frm = new PocetnaMDIFrm();
                this.Hide();
                frm.ShowDialog();

                ResetujKorisnika();
                this.Show();
            }
        }
        private void LoginFrm_Load(object sender, EventArgs e)
        {

        }
        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }
        private async void loginBtn_Click(object sender, EventArgs e)
        {
            APIService.Username = txtUsername.Text;
            APIService.Password = txtPassword.Text;

            try
            {
                KorisnikSearchObject search = new KorisnikSearchObject()
                {
                    Username = APIService.Username,
                    IncludeList = new string[] { "KorisnikUlogas", "ModeratorModeratorNavigation" }
                };

                EnableTextBoxes(false);

                var result = await _api.Get<List<Korisnik>>(search);
                APIService.Korisnik = result.SingleOrDefault();

                /*U slučaju da neko ko već ima account a ulogom "Gost" i sad želi takođe izdavati
                 apartmane, prilikom logiranja na desktop aplikaciju mu se na postojeći
                account dodaje uloga "Vlasnik".*/
                await ProvjeriUlogu();

                var frm = new PocetnaMDIFrm();
                this.Hide();
                frm.ShowDialog();

                ResetujKorisnika();
                this.Show();
            }
            catch
            {
                EnableTextBoxes(true);
                txtPassword.Text = "";
                MessageBox.Show("Pogrešan username ili password!", "Poruka", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        private async Task ProvjeriUlogu()
        {
            var korisnik = APIService.Korisnik;
            //Ako je korisnik moderator, ne dajemo mu ulogu vlasnika, prekidamo ovu funkciju
            if (korisnik.IsModeratorApartmani==true || korisnik.IsModeratorRezervacije==true)
                return;
            //Ako postojeći korisnik GOST nema ulogu VLASNIKA apartmana, pri prvom logiranju mu se dodjeljuje ta uloga
            else if (korisnik.IsVlasnik==false)
            {
                KorisnikUloga request = new KorisnikUloga()
                {
                    KorisnikId = APIService.Korisnik.KorisnikId,
                    UlogaId = 2//Id Vlasnik uloge
                };
                var uloga = await _apiUloge.Insert<Model.KorisnikUloga>(request);
                APIService.Korisnik.KorisnikUlogas.Add(uloga);
            }
        }
        void EnableTextBoxes(bool state)
        {
            foreach (Control control in this.Controls)
            {
                control.Enabled = state;
            }
            txtLoading.Text=txtLoading.Text==""?"Loading...":"";
        }
        void ResetujKorisnika()
        {
            APIService.Reset();
            EnableTextBoxes(true);
            txtPassword.Text = "";
            txtUsername.Text = "";
        }
    }
}
