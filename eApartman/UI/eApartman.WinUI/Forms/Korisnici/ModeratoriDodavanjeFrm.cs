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

namespace eApartman.WinUI.Forms.Korisnici
{
    public partial class ModeratoriDodavanjeFrm : MaterialForm
    {
        private readonly APIService _apiKorisnici = new APIService("Korisnici");
        private readonly APIService _apiModeratori = new APIService("Moderatori");
        private readonly Korisnik _moderator;
        public ModeratoriDodavanjeFrm(Korisnik moderator=null)
        {
            InitializeComponent();
            _moderator = moderator;
        }

        private void DodajModeratoraFrm_Load(object sender, EventArgs e)
        {
            
        }

        private void materialTextBox1_Enter(object sender, EventArgs e)
        {
            txtPassword.Focus();
        }

        private async void btnDodaj_Click(object sender, EventArgs e)
        {
            Loading(true);
            try
            {
                if (!cmbApartmani.Checked && !cmbRezervacije.Checked)
                    throw new Exception("Morate odabrati makar jednu ulogu!");

                KorisnikInsertRequest request = new KorisnikInsertRequest()
                {
                    Ime = txtIme.Text,
                    Prezime = txtPrezime.Text,
                    Email = txtEmail.Text,
                    Username = txtUsername.Text,
                    Password = txtPassword.Text,
                    Status = true,
                    PasswordPotvrda = txtPasswordPotvrda.Text,
                    Telefon = txtTelefon.Text,
                    Uloge = new List<int>(),
                    DatumRegistracije = DateTime.Now
                };
                if (cmbApartmani.Checked) request.Uloge.Add(4);//Moderator Apartmana uloga
                if (cmbRezervacije.Checked) request.Uloge.Add(5);//Moderator Rezervacija uloga

                Korisnik moderator = await _apiKorisnici.Insert<Korisnik>(request);

                Moderator requestModerator = new Moderator()
                {
                    ModeratorId = moderator.KorisnikId,
                    VlasnikId = APIService.Korisnik.KorisnikId
                };

                await _apiModeratori.Insert<Moderator>(requestModerator);

                MessageBox.Show($"Moderator {moderator.Username} dodan!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Poruka", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Loading(false);
            }
            this.Close();

        }
        private void Loading(bool state)
        {
            state = !state;
            foreach(Control control in this.Controls)
            {
                control.Enabled = state;
            }
        }
    }
}
