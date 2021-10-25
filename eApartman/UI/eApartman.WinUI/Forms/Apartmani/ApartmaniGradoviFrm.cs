using eApartman.Model;
using eApartman.Model.Requests;
using eApartman.WinUI.Parameters;
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
    public partial class ApartmaniGradoviFrm : MaterialForm
    {
        private readonly Drzava _drzava;
        private readonly APIService _api = new APIService("Gradovi");
        private readonly ComboBox _cmb;
        private ApartmaniGradoviFrmParameters parameters;
        public ApartmaniGradoviFrm(ApartmaniGradoviFrmParameters parameters)
        {
            InitializeComponent();
            this.parameters = parameters;
            this._cmb = parameters.CmbDrzave;
            this._drzava = parameters.CmbDrzave.Items[_cmb.SelectedIndex] as Drzava;
        }

        private void ApartmaniGradoviFrm_Load(object sender, EventArgs e)
        {
            txtDrzava.Text = _drzava.Naziv;
        }
        private void txtNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private async void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (txtNaziv.Text == "" || txtPostanskiBroj.Text == "")
                MessageBox.Show("Sva polja moraju biti popunjena!", "Poruka", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                Loading(true);
                try
                {
                    GradUpsertRequest request = new GradUpsertRequest()
                    {
                        Naziv = txtNaziv.Text,
                        DrzavaId = _drzava.DrzavaId,
                        PostanskiBroj = int.Parse(txtPostanskiBroj.Text)
                    };
                    Grad grad=await _api.Insert<Grad>(request);
                    MessageBox.Show($"Dodan grad {grad.Naziv}!", "Poruka", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    parameters.SelectedIndexGrad = grad.GradId;
                    DialogResult = DialogResult.OK;
                }
                catch
                {
                    MessageBox.Show("Server trenutno nije dostupan...", "Poruka", MessageBoxButtons.OK, MessageBoxIcon.Error);                  
                }           
                this.Close();
            }
        }
        void Loading(bool state)
        {
            txtNaslov.Text = state ? "Loading..." : "Dodavanje gradova";
            state = !state;
            foreach (Control control in this.Controls)
            {
                control.Enabled = state;
            }
        }
    }
}
