using eApartman.Model;
using eApartman.Model.Requests;
using eApartman.WinUI;
using eApartman.WinUI.Forms;
using eApartman.WinUI.Forms.Apartmani;
using MaterialSkin;
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


namespace eApartman.UI.Forms
{
    public partial class RegisterFrm : MaterialForm
    {
        private readonly APIService _serviceKorisnici=new APIService("Korisnici");
        public RegisterFrm()
        {
            InitializeComponent();
            
        }

        private void RegisterFrm_Load(object sender, EventArgs e)
        {

        }

        private async void btnRegister_Click(object sender, EventArgs e)
        {

            try
            {
                KorisnikInsertRequest noviKorisnik = new KorisnikInsertRequest()
                {
                    Ime = txtIme.Text,
                    Prezime = txtPrezime.Text,
                    Email = txtEmail.Text,
                    Username = txtUsername.Text,
                    Password = txtPassword.Text,
                    Status = true,
                    PasswordPotvrda = txtPotvrdaPassword.Text,
                    Telefon = txtTelefon.Text,
                    Uloge = new List<int>() { 2 },
                    DatumRegistracije = DateTime.Now
                };
                if (ofdSlika.FileName != "") noviKorisnik.Slika = File.ReadAllBytes(ofdSlika.FileName);

                APIService.Username = txtUsername.Text;
                APIService.Password = txtPassword.Text;

                EnableTextBoxes(false);
                APIService.Korisnik = await _serviceKorisnici.Insert<Korisnik>(noviKorisnik);
                
                this.Close();
                
            }
            catch
            {
                MessageBox.Show("Pogrešan unos podataka!", "Poruka", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                EnableTextBoxes(true);
            }

        }

        private void registerFormClosed(object sender, FormClosedEventArgs e)
        {

        }

        void EnableTextBoxes(bool state)
        {
            foreach(Control control in this.Controls)
            {
                control.Enabled = state;
            }
            txtLoading.Text = txtLoading.Text == "" ? "Loading..." : "";
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
