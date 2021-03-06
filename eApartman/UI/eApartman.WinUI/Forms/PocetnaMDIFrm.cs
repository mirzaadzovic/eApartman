using eApartman.WinUI.Forms.Apartmani;
using eApartman.WinUI.Forms.Izvjestaji;
using eApartman.WinUI.Forms.Korisnici;
using eApartman.WinUI.Forms.Rezervacije;
using eApartman.WinUI.Helpers;
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

namespace eApartman.WinUI.Forms
{
    public partial class PocetnaMDIFrm : MaterialForm
    {
        private int childFormNumber = 0;

        public PocetnaMDIFrm()
        {
            InitializeComponent();
        }
        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }
        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }
        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }
        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dialogResult = MessageBox.Show("Jeste li sigurni da želite zatvoriti sve prozore?", "Poruka"
                , MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(dialogResult==DialogResult.Yes)
            {
                foreach (Form childForm in MdiChildren)
                {
                    childForm.Close();
                }
            }
        }
        private void pregledApartmanaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(APIService.Korisnik.IsVlasnik==true || APIService.Korisnik.IsModeratorApartmani==true)
            {
                ApartmaniPregledFrm frm = new ApartmaniPregledFrm();
                frm.MdiParent = this;
                frm.Show();
            }
            else
                MessageBox.Show("Nemate pravo pristupa ovoj funkcionalnosti!", "Poruka", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        private void PocetnaMDIFrm_Load(object sender, EventArgs e)
        {
            try
            {
                LoadKorisnik();               
            }
            catch
            {
                MessageBox.Show("Potrebno se ponovo logirati!");
            }
        }
        private void LoadKorisnik()
        {
            var korisnik = APIService.Korisnik;
            txtUsername.Text = korisnik.Username;
            if (korisnik.Slika.Count() != 0)
                pbSlika.Image = ImageBytesConverter.BytesToImage(korisnik.Slika);
        }
        private void dodavanjeApartmanaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(APIService.Korisnik.IsVlasnik == true || APIService.Korisnik.IsModeratorApartmani==true)
            {
                ApartmaniDodavanjeFrm frm = new ApartmaniDodavanjeFrm();
                frm.MdiParent = this;
                frm.Show();
            }
            else
                MessageBox.Show("Nemate pravo pristupa ovoj funkcionalnosti!", "Poruka", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void checked_Change(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(63, 81, 181);
        }

        private void mojNalogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MojNalogFrm frm = new MojNalogFrm();
            frm.MdiParent = this;
            frm.Show();
        }

        private void dodavanjeModeratoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Da li korisnik ima ulogu "Vlasnik"
            if (APIService.Korisnik.IsVlasnik==true)
            {
                ModeratoriDodavanjeFrm frm = new ModeratoriDodavanjeFrm();
                frm.MdiParent = this;
                frm.Show();
            }
            else
                MessageBox.Show("Nemate pravo pristupa ovoj funkcionalnosti!", "Poruka", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void pregledModeratoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Da li korisnik ima ulogu "Vlasnik"
            if (APIService.Korisnik.IsVlasnik==true)
            {
                ModeratoriPregledFrm frm = new ModeratoriPregledFrm();
                frm.MdiParent = this;
                frm.Show();
            }
            else
                MessageBox.Show("Nemate pravo pristupa ovoj funkcionalnosti!", "Poruka", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void txtUsername_Click(object sender, EventArgs e)
        {
            mojNalogToolStripMenuItem_Click(sender, e);
        }

        private void dodavanjeRezervacijaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (APIService.Korisnik.IsVlasnik == true || APIService.Korisnik.IsModeratorRezervacije == true)
            {
                RezervacijeDodavanjeFrm frm = new RezervacijeDodavanjeFrm();
                frm.MdiParent = this;
                frm.Show();
            }
            else
                MessageBox.Show("Nemate pravo pristupa ovoj funkcionalnosti!", "Poruka", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void pregledRezervacijaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (APIService.Korisnik.IsVlasnik == true || APIService.Korisnik.IsModeratorRezervacije == true)
            {
                RezervacijePregledFrm frm = new RezervacijePregledFrm();
                frm.MdiParent = this;
                frm.Show();
            }
            else
                MessageBox.Show("Nemate pravo pristupa ovoj funkcionalnosti!", "Poruka", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void pbSlika_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void zaradaPoApartmanimaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(APIService.Korisnik.IsVlasnik==true)
            {
                IzvjestajFrm frm = new IzvjestajFrm();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                MessageBox.Show("Nemate pravo printanja izvještaja!");
            }
        }
    }
}
