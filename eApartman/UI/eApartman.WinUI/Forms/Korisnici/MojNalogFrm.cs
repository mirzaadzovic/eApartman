using eApartman.Model;
using eApartman.Model.Requests;
using eApartman.WinUI.Helpers;
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

namespace eApartman.WinUI.Forms.Korisnici
{
    public partial class MojNalogFrm : MaterialForm
    {
        private readonly APIService _api = new APIService("Korisnici");
        public MojNalogFrm()
        {
            InitializeComponent();
        }


        private void MojNalogFrm_Load(object sender, EventArgs e)
        {
            LoadKorisnik();
            
        }
        private void LoadKorisnik()
        {
            Korisnik korisnik = APIService.Korisnik;
            txtIme.Text = korisnik.Ime;
            txtPrezime.Text = korisnik.Prezime;
            txtTelefon.Text = korisnik.Telefon;
            if(korisnik.Slika.Count()!=0)
                pbSlika.Image = ImageBytesConverter.BytesToImage(korisnik.Slika);
        }
        void Loading(bool state)
        {
            state = !state;

            txtIme.Enabled = state;
            txtPrezime.Enabled = state;
            txtPassword.Enabled = state;
            txtPotvrdaPassword.Enabled = state;
            txtTelefon.Enabled = state;
            txtOldPassword.Enabled = state; 
            btnRegister.Enabled = state;
        }

        private async void btnRegister_Click(object sender, EventArgs e)
        {
            Loading(true);
            try
            {
                if (txtOldPassword.Text!=APIService.Password)
                {
                    txtOldPassword.Text = "";
                    throw new Exception("Stara lozinka neispravna!");
                }
                if (txtPassword.Text != txtPotvrdaPassword.Text)
                {
                    txtPassword.Text = "";
                    txtPotvrdaPassword.Text = "";
                    throw new Exception("Lozinka i potvrda lozinke se ne podudaraju!");
                }
                var file = ofdSlika.FileName;

                KorisnikUpdateRequest request = new KorisnikUpdateRequest()
                {
                    Ime = txtIme.Text,
                    Prezime = txtPrezime.Text,
                    Slika = file == "" ? APIService.Korisnik.Slika : File.ReadAllBytes(file),
                    Telefon = txtTelefon.Text,
                    Password = txtPassword.Text,
                    PasswordPotvrda = txtPotvrdaPassword.Text,
                    OldPassword = txtOldPassword.Text,
                    Status=true
                };
                int id = APIService.Korisnik.KorisnikId;
                var korisnik=await _api.Update<Korisnik>(id, request);
                APIService.Korisnik = korisnik;

                if (txtPassword.Text != "")
                    APIService.Password = txtPassword.Text;

                MessageBox.Show("Korisnički nalog ažuriran!");
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Poruka", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Loading(false);
            }
        }

        private void btnSlika_Click(object sender, EventArgs e)
        {
            try
            {
                var result = ofdSlika.ShowDialog();
                if (result == DialogResult.OK)
                {
                    string filename = ofdSlika.FileName;
                    pbSlika.Image = Image.FromFile(filename);
                }
            }
            catch
            {
                MessageBox.Show("Pogrešan format!");
            }
           
        }
    }
}
