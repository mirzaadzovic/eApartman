
namespace eApartman.WinUI.Forms.Rezervacije
{
    partial class RezervacijePregledFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.calendar = new System.Windows.Forms.MonthCalendar();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.dgvApartmani = new System.Windows.Forms.DataGridView();
            this.cbOtkazane = new MaterialSkin.Controls.MaterialCheckbox();
            this.txtDatum = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CheckIn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CheckOut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cijena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaxOsoba = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvApartmani)).BeginInit();
            this.SuspendLayout();
            // 
            // calendar
            // 
            this.calendar.Location = new System.Drawing.Point(453, 49);
            this.calendar.Name = "calendar";
            this.calendar.TabIndex = 0;
            this.calendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.calendar_DateChanged);
            // 
            // btnDodaj
            // 
            this.btnDodaj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.btnDodaj.FlatAppearance.BorderColor = System.Drawing.Color.GhostWhite;
            this.btnDodaj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDodaj.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.btnDodaj.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDodaj.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDodaj.ImageKey = "(none)";
            this.btnDodaj.Location = new System.Drawing.Point(950, 246);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(134, 36);
            this.btnDodaj.TabIndex = 15;
            this.btnDodaj.Text = "+ DODAJ";
            this.btnDodaj.UseVisualStyleBackColor = false;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // dgvApartmani
            // 
            this.dgvApartmani.AllowUserToAddRows = false;
            this.dgvApartmani.AllowUserToDeleteRows = false;
            this.dgvApartmani.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvApartmani.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvApartmani.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvApartmani.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(35)))), ((int)(((byte)(180)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvApartmani.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvApartmani.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvApartmani.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Naziv,
            this.Ime,
            this.Prezime,
            this.CheckIn,
            this.CheckOut,
            this.Cijena,
            this.MaxOsoba,
            this.btnDelete});
            this.dgvApartmani.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvApartmani.GridColor = System.Drawing.SystemColors.MenuBar;
            this.dgvApartmani.Location = new System.Drawing.Point(21, 306);
            this.dgvApartmani.Name = "dgvApartmani";
            this.dgvApartmani.ReadOnly = true;
            this.dgvApartmani.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvApartmani.Size = new System.Drawing.Size(1163, 270);
            this.dgvApartmani.TabIndex = 14;
            this.dgvApartmani.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvApartmani_CellContentClick);
            // 
            // cbOtkazane
            // 
            this.cbOtkazane.AutoSize = true;
            this.cbOtkazane.Depth = 0;
            this.cbOtkazane.Location = new System.Drawing.Point(72, 248);
            this.cbOtkazane.Margin = new System.Windows.Forms.Padding(0);
            this.cbOtkazane.MouseLocation = new System.Drawing.Point(-1, -1);
            this.cbOtkazane.MouseState = MaterialSkin.MouseState.HOVER;
            this.cbOtkazane.Name = "cbOtkazane";
            this.cbOtkazane.Ripple = true;
            this.cbOtkazane.Size = new System.Drawing.Size(231, 37);
            this.cbOtkazane.TabIndex = 16;
            this.cbOtkazane.Text = "Prikaži otkazane rezervacije";
            this.cbOtkazane.UseVisualStyleBackColor = true;
            this.cbOtkazane.CheckedChanged += new System.EventHandler(this.cbOtkazane_CheckedChanged);
            // 
            // txtDatum
            // 
            this.txtDatum.AutoSize = true;
            this.txtDatum.Depth = 0;
            this.txtDatum.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.txtDatum.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            this.txtDatum.Location = new System.Drawing.Point(512, 257);
            this.txtDatum.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtDatum.Name = "txtDatum";
            this.txtDatum.Size = new System.Drawing.Size(104, 17);
            this.txtDatum.TabIndex = 17;
            this.txtDatum.Text = "Odabrani datum";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(499, 229);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(134, 19);
            this.materialLabel1.TabIndex = 18;
            this.materialLabel1.Text = "Pregled rezervacija";
            // 
            // Naziv
            // 
            this.Naziv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Naziv.DataPropertyName = "ApartmanNaziv";
            this.Naziv.HeaderText = "Naziv";
            this.Naziv.Name = "Naziv";
            this.Naziv.ReadOnly = true;
            // 
            // Ime
            // 
            this.Ime.DataPropertyName = "GostIme";
            this.Ime.HeaderText = "Ime";
            this.Ime.Name = "Ime";
            this.Ime.ReadOnly = true;
            this.Ime.Width = 205;
            // 
            // Prezime
            // 
            this.Prezime.DataPropertyName = "GostPrezime";
            this.Prezime.HeaderText = "Prezime";
            this.Prezime.Name = "Prezime";
            this.Prezime.ReadOnly = true;
            this.Prezime.Width = 205;
            // 
            // CheckIn
            // 
            this.CheckIn.DataPropertyName = "CheckIn";
            this.CheckIn.HeaderText = "Check-In";
            this.CheckIn.Name = "CheckIn";
            this.CheckIn.ReadOnly = true;
            // 
            // CheckOut
            // 
            this.CheckOut.DataPropertyName = "CheckOut";
            this.CheckOut.HeaderText = "Check-Out";
            this.CheckOut.Name = "CheckOut";
            this.CheckOut.ReadOnly = true;
            // 
            // Cijena
            // 
            this.Cijena.DataPropertyName = "Cijena";
            this.Cijena.HeaderText = "Cijena";
            this.Cijena.Name = "Cijena";
            this.Cijena.ReadOnly = true;
            // 
            // MaxOsoba
            // 
            this.MaxOsoba.DataPropertyName = "BrojOsoba";
            this.MaxOsoba.HeaderText = "Max Osoba";
            this.MaxOsoba.Name = "MaxOsoba";
            this.MaxOsoba.ReadOnly = true;
            // 
            // btnDelete
            // 
            this.btnDelete.HeaderText = "Otkazivanje";
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.ReadOnly = true;
            this.btnDelete.Text = "Otkaži";
            this.btnDelete.UseColumnTextForButtonValue = true;
            // 
            // RezervacijePregledFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 582);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.txtDatum);
            this.Controls.Add(this.cbOtkazane);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.dgvApartmani);
            this.Controls.Add(this.calendar);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_None;
            this.Name = "RezervacijePregledFrm";
            this.Padding = new System.Windows.Forms.Padding(3, 24, 3, 3);
            this.Text = "RezervacijePregledFrm";
            this.Load += new System.EventHandler(this.RezervacijePregledFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvApartmani)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar calendar;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.DataGridView dgvApartmani;
        private MaterialSkin.Controls.MaterialCheckbox cbOtkazane;
        private MaterialSkin.Controls.MaterialLabel txtDatum;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn CheckIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CheckOut;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cijena;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaxOsoba;
        private System.Windows.Forms.DataGridViewButtonColumn btnDelete;
    }
}