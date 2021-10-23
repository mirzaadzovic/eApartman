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

namespace eApartman.WinUI.Forms.Apartmani
{
    public partial class ApartmaniDodavanjeFrm : MaterialForm
    {
        private readonly APIService _serviceGradovi;
        private readonly APIService _serviceDrzave;
        private readonly APIService _serviceApartmani;
        private readonly APIService _serviceSlike;
        private readonly APIService _serviceApartmaniTip;
        public ApartmaniDodavanjeFrm(/*Korisnik korisnik*/)
        {
            InitializeComponent();
            _serviceGradovi = new APIService("Gradovi");
            _serviceDrzave = new APIService("Drzava");
            _serviceApartmani = new APIService("Apartmani");
            _serviceSlike = new APIService("Slike");
            _serviceApartmaniTip = new APIService("ApartmaniTip");

        }

        private async void ApartmaniDodavanjeFrm_Load(object sender, EventArgs e)
        {
            try
            {
                txtUsername.Text = APIService.Korisnik.Username;

                SwitchComboBoxes(false);

                cmbDrzava.Hint = "Loading Države...";
                cmbGrad.Hint = "Loading Gradovi...";
                //cmbTipApartmana.Hint = "Loading Tipovi...";

                //cmbTipApartmana.DataSource = await LoadApartmaniTip();
                //cmbDrzava.ValueMember = "ApartmanTipId";
                //cmbDrzava.DisplayMember = "ApartmanTipNaziv";
                //cmbDrzava.SelectedIndex = 0;

                cmbDrzava.DataSource = await LoadDrzave();
                cmbDrzava.ValueMember = "DrzavaId";
                cmbDrzava.DisplayMember = "Naziv";
                cmbDrzava.SelectedIndex = 0;

                SwitchComboBoxes(true);

            }
            catch(Exception ex)
            {
                MessageBox.Show("Aplikacija se nije uspjela povezati na server. Pokušajte kasnije...");
            }

        }

        private void cmbDrzava_SelectedIndexChanged(object sender, EventArgs e)
        {
            var drzava = cmbDrzava.Items[cmbDrzava.SelectedIndex] as Drzava;
            if(drzava!=null)
            {
                var gradovi = drzava.Grads.OrderBy(g => g.Naziv).ToList();
                LoadGradovi(gradovi);
            }              
        }

        private void txtNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&(e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
        private async Task<List<Drzava>> LoadDrzave()
        {
            DrzavaSearchObject search = new DrzavaSearchObject()
            {
                IncludeGradovi=true
            };
            return await _serviceDrzave.Get<List<Drzava>>(search);

        }
        private void LoadGradovi(object gradovi)
        {
            cmbGrad.DataSource = gradovi as List<Grad>;
            cmbGrad.ValueMember = "GradId";
            cmbGrad.DisplayMember = "Naziv";
        }
        private async Task<List<ApartmanTip>> LoadApartmaniTip()
        {
            return await _serviceApartmaniTip.Get<List<ApartmanTip>>();
        }
        private void SwitchComboBoxes(bool state)
        {
            cmbGrad.Enabled = state;
            cmbDrzava.Enabled = state;
            cmbTipApartmana.Enabled = state;
        }

    }
}
