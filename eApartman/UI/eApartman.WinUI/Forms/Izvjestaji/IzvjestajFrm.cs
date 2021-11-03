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
using Microsoft.Reporting.WinForms;
using eApartman.Model.Requests;
using eApartman.Model;

namespace eApartman.WinUI.Forms.Izvjestaji
{
    public partial class IzvjestajFrm : MaterialForm
    {
        private readonly APIService _api = new APIService("Rezervacije");
        public IzvjestajFrm()
        {
            InitializeComponent();
        }

        private async void IzvjestajFrm_Load(object sender, EventArgs e)
        {
            try
            {
                cbPeriod.Checked = false;
                LoadDatumi();
                await GetTabelaZaradaApartmani();
            }       
            catch(Exception error)
            {
                MessageBox.Show(error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private async Task<List<Rezervacija>> LoadZaradaApartmani()
        {
            var request = new RezervacijaSearchObject()
            {
                VlasnikId = APIService.Korisnik.GetVlasnikId(),
                IncludeList = new string[] { "Apartman.Adresa" },
            };

            return await _api.Get<List<Rezervacija>>(request);
        }
        private async Task GetTabelaZaradaApartmani()
        {
            ReportParameterCollection rpc = new ReportParameterCollection();
            rpc.Add(new ReportParameter("Username", APIService.Korisnik.Username));
            rpc.Add(new ReportParameter("ImePrezime", APIService.Korisnik.GetFullName()));
            rpc.Add(new ReportParameter("Email", APIService.Korisnik.Email));
            rpc.Add(new ReportParameter("DatumOd", dtOd.Value.ToString("d.M.yyyy")));
            rpc.Add(new ReportParameter("DatumDo", dtDo.Value.ToString("d.M.yyyy")));

            ReportDataSource rds = new ReportDataSource();
            DataSet.ZaradaApartmaniDataTable tbl = new DataSet.ZaradaApartmaniDataTable();

            var rezervacije = await LoadZaradaApartmani();
            var query = from r in rezervacije
                        where DateTime.Parse(r.CheckIn).Date>=dtOd.Value.Date &&
                        DateTime.Parse(r.CheckIn).Date <= dtDo.Value.Date
                        group r by new { r.ApartmanNaziv, r.Adresa } into rpg
                        select new ZaradaApartman()
                        {
                            Apartman = rpg.Key.ApartmanNaziv,
                            Adresa = rpg.Key.Adresa,
                            Zarada = rpg.Sum(r => (int)r.Cijena).ToString(),
                            BrojRezervacija = rpg.Sum(r=>r.BrojDana).ToString()
                        };

            foreach(var item in query)
            {
                DataSet.ZaradaApartmaniRow red = tbl.NewZaradaApartmaniRow();
                red.Apartman = item.Apartman;
                red.Adresa = item.Adresa;
                red.Zarada = item.Zarada + " €";
                red.BrojRezervacija= item.BrojRezervacija;
                tbl.Rows.Add(red);
            }

            rds.Name = "ZaradaApartmani";
            rds.Value = tbl;

            reportViewer1.LocalReport.SetParameters(rpc);
            reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.RefreshReport();
        }
        private void LoadDatumi()
        {          
            dtOd.Value = DateTime.Today.Date.AddDays(-7);
            dtDo.Value = DateTime.Today.Date;
        }

        private async void dtOd_ValueChanged(object sender, EventArgs e)
        {
            if (dtOd.Value.Date >= dtDo.Value.Date)
                dtDo.Value = dtOd.Value.Date.AddDays(1);

            reportViewer1.LocalReport.DataSources.Clear();
            await GetTabelaZaradaApartmani();
        }
        public class ZaradaApartman
        {
            public string Apartman { get; set; }
            public string Adresa { get; set; }
            public string Zarada { get; set; }
            public string BrojRezervacija { get; set; }
        }

        private void btnMjesec(object sender, EventArgs e)
        {
            if (cbPeriod.Checked)
                dtDo.Value = dtOd.Value.AddMonths(1);
            else
                dtOd.Value = dtDo.Value.AddMonths(-1);
        }

        private void btnGodina_Click(object sender, EventArgs e)
        {
            if (cbPeriod.Checked)
                dtDo.Value = dtOd.Value.AddYears(1);
            else
                dtOd.Value = dtDo.Value.AddYears(-1);
        }

        private void btnSedmica_Click(object sender, EventArgs e)
        {
            if (cbPeriod.Checked)
                dtDo.Value = dtOd.Value.AddDays(7);
            else
                dtOd.Value = dtDo.Value.AddDays(-7);
        }

        private void materialSwitch1_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPeriod.Checked)
                txtPeriod.Text = "Budućih";
            else
                txtPeriod.Text = "Prethodnih";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
