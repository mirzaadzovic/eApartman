
namespace eApartman.WinUI.Forms.Apartmani
{
    partial class ApartmaniPregledFrm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvApartmani = new System.Windows.Forms.DataGridView();
            this.pbApartman = new System.Windows.Forms.PictureBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.txtNaziv = new MaterialSkin.Controls.MaterialTextBox();
            this.btnPretrazi = new System.Windows.Forms.Button();
            this.txtNaslov = new MaterialSkin.Controls.MaterialLabel();
            this.cmbApartmanTip = new MaterialSkin.Controls.MaterialComboBox();
            this.Slika = new System.Windows.Forms.DataGridViewImageColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GradId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DrzavaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApartmanTipId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApartmanTip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cijena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaxOsoba = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Parking = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Balkon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvApartmani)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbApartman)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvApartmani
            // 
            this.dgvApartmani.AllowUserToAddRows = false;
            this.dgvApartmani.AllowUserToDeleteRows = false;
            this.dgvApartmani.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvApartmani.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvApartmani.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvApartmani.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(35)))), ((int)(((byte)(180)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvApartmani.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvApartmani.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvApartmani.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Slika,
            this.Naziv,
            this.Grad,
            this.GradId,
            this.DrzavaId,
            this.ApartmanTipId,
            this.Adresa,
            this.ApartmanTip,
            this.Cijena,
            this.MaxOsoba,
            this.Parking,
            this.Balkon,
            this.btnDelete});
            this.dgvApartmani.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvApartmani.GridColor = System.Drawing.SystemColors.MenuBar;
            this.dgvApartmani.Location = new System.Drawing.Point(19, 370);
            this.dgvApartmani.Name = "dgvApartmani";
            this.dgvApartmani.ReadOnly = true;
            this.dgvApartmani.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvApartmani.Size = new System.Drawing.Size(1163, 164);
            this.dgvApartmani.TabIndex = 0;
            this.dgvApartmani.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvApartmani_CellContentClick_1);
            this.dgvApartmani.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvApartmani_CellContentClick);
            // 
            // pbApartman
            // 
            this.pbApartman.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pbApartman.Location = new System.Drawing.Point(484, 53);
            this.pbApartman.Name = "pbApartman";
            this.pbApartman.Size = new System.Drawing.Size(282, 182);
            this.pbApartman.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbApartman.TabIndex = 2;
            this.pbApartman.TabStop = false;
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
            this.btnDodaj.Location = new System.Drawing.Point(958, 300);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(134, 50);
            this.btnDodaj.TabIndex = 13;
            this.btnDodaj.Text = "+ DODAJ";
            this.btnDodaj.UseVisualStyleBackColor = false;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // txtNaziv
            // 
            this.txtNaziv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNaziv.Depth = 0;
            this.txtNaziv.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNaziv.Hint = "Naziv apartmana";
            this.txtNaziv.LeadingIcon = null;
            this.txtNaziv.Location = new System.Drawing.Point(48, 300);
            this.txtNaziv.MaxLength = 50;
            this.txtNaziv.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNaziv.Multiline = false;
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(210, 50);
            this.txtNaziv.TabIndex = 17;
            this.txtNaziv.Text = "";
            this.txtNaziv.TrailingIcon = null;
            this.txtNaziv.UseAccent = false;
            // 
            // btnPretrazi
            // 
            this.btnPretrazi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.btnPretrazi.FlatAppearance.BorderColor = System.Drawing.Color.GhostWhite;
            this.btnPretrazi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPretrazi.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.btnPretrazi.ForeColor = System.Drawing.SystemColors.Control;
            this.btnPretrazi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPretrazi.ImageKey = "(none)";
            this.btnPretrazi.Location = new System.Drawing.Point(562, 300);
            this.btnPretrazi.Name = "btnPretrazi";
            this.btnPretrazi.Size = new System.Drawing.Size(140, 50);
            this.btnPretrazi.TabIndex = 18;
            this.btnPretrazi.Text = "PRETRAŽI";
            this.btnPretrazi.UseVisualStyleBackColor = false;
            this.btnPretrazi.Click += new System.EventHandler(this.btnPretrazi_Click);
            // 
            // txtNaslov
            // 
            this.txtNaslov.AutoSize = true;
            this.txtNaslov.Depth = 0;
            this.txtNaslov.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNaslov.Location = new System.Drawing.Point(551, 253);
            this.txtNaslov.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNaslov.Name = "txtNaslov";
            this.txtNaslov.Size = new System.Drawing.Size(136, 19);
            this.txtNaslov.TabIndex = 25;
            this.txtNaslov.Text = "Pregled apartmana";
            // 
            // cmbApartmanTip
            // 
            this.cmbApartmanTip.AutoResize = false;
            this.cmbApartmanTip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbApartmanTip.Depth = 0;
            this.cmbApartmanTip.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbApartmanTip.DropDownHeight = 174;
            this.cmbApartmanTip.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbApartmanTip.DropDownWidth = 121;
            this.cmbApartmanTip.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbApartmanTip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbApartmanTip.FormattingEnabled = true;
            this.cmbApartmanTip.Hint = "Loading...";
            this.cmbApartmanTip.IntegralHeight = false;
            this.cmbApartmanTip.ItemHeight = 43;
            this.cmbApartmanTip.Location = new System.Drawing.Point(292, 300);
            this.cmbApartmanTip.MaxDropDownItems = 4;
            this.cmbApartmanTip.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbApartmanTip.Name = "cmbApartmanTip";
            this.cmbApartmanTip.Size = new System.Drawing.Size(199, 49);
            this.cmbApartmanTip.StartIndex = 0;
            this.cmbApartmanTip.TabIndex = 26;
            // 
            // Slika
            // 
            this.Slika.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Slika.DataPropertyName = "SlikaProfilnaFile";
            this.Slika.FillWeight = 150F;
            this.Slika.HeaderText = "Slika";
            this.Slika.MinimumWidth = 220;
            this.Slika.Name = "Slika";
            this.Slika.ReadOnly = true;
            // 
            // Naziv
            // 
            this.Naziv.DataPropertyName = "Naziv";
            this.Naziv.HeaderText = "Naziv";
            this.Naziv.Name = "Naziv";
            this.Naziv.ReadOnly = true;
            // 
            // Grad
            // 
            this.Grad.DataPropertyName = "GradNaziv";
            this.Grad.HeaderText = "Grad";
            this.Grad.Name = "Grad";
            this.Grad.ReadOnly = true;
            // 
            // GradId
            // 
            this.GradId.DataPropertyName = "GradId";
            this.GradId.HeaderText = "GradId";
            this.GradId.Name = "GradId";
            this.GradId.ReadOnly = true;
            this.GradId.Visible = false;
            // 
            // DrzavaId
            // 
            this.DrzavaId.DataPropertyName = "DrzavaId";
            this.DrzavaId.HeaderText = "DrzavaID";
            this.DrzavaId.Name = "DrzavaId";
            this.DrzavaId.ReadOnly = true;
            this.DrzavaId.Visible = false;
            // 
            // ApartmanTipId
            // 
            this.ApartmanTipId.DataPropertyName = "ApartmanTipId";
            this.ApartmanTipId.HeaderText = "ApartmanTipId";
            this.ApartmanTipId.Name = "ApartmanTipId";
            this.ApartmanTipId.ReadOnly = true;
            this.ApartmanTipId.Visible = false;
            // 
            // Adresa
            // 
            this.Adresa.DataPropertyName = "AdresaNaziv";
            this.Adresa.HeaderText = "Adresa";
            this.Adresa.Name = "Adresa";
            this.Adresa.ReadOnly = true;
            // 
            // ApartmanTip
            // 
            this.ApartmanTip.DataPropertyName = "ApartmanTipNaziv";
            this.ApartmanTip.HeaderText = "Tip Apartmana";
            this.ApartmanTip.Name = "ApartmanTip";
            this.ApartmanTip.ReadOnly = true;
            // 
            // Cijena
            // 
            this.Cijena.DataPropertyName = "CijenaInt";
            this.Cijena.HeaderText = "Cijena";
            this.Cijena.Name = "Cijena";
            this.Cijena.ReadOnly = true;
            // 
            // MaxOsoba
            // 
            this.MaxOsoba.DataPropertyName = "MaxOsoba";
            this.MaxOsoba.HeaderText = "Max Osoba";
            this.MaxOsoba.Name = "MaxOsoba";
            this.MaxOsoba.ReadOnly = true;
            // 
            // Parking
            // 
            this.Parking.DataPropertyName = "ImaParking";
            this.Parking.HeaderText = "Parking";
            this.Parking.Name = "Parking";
            this.Parking.ReadOnly = true;
            // 
            // Balkon
            // 
            this.Balkon.DataPropertyName = "ImaBalkon";
            this.Balkon.HeaderText = "Balkon";
            this.Balkon.Name = "Balkon";
            this.Balkon.ReadOnly = true;
            // 
            // btnDelete
            // 
            this.btnDelete.HeaderText = "Brisanje";
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.ReadOnly = true;
            this.btnDelete.Text = "Obriši ";
            this.btnDelete.UseColumnTextForButtonValue = true;
            // 
            // ApartmaniPregledFrm
            // 
            this.AcceptButton = this.btnPretrazi;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1214, 576);
            this.Controls.Add(this.cmbApartmanTip);
            this.Controls.Add(this.txtNaslov);
            this.Controls.Add(this.btnPretrazi);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.pbApartman);
            this.Controls.Add(this.dgvApartmani);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_None;
            this.Name = "ApartmaniPregledFrm";
            this.Padding = new System.Windows.Forms.Padding(3, 24, 3, 3);
            this.Text = "eApartman";
            this.Load += new System.EventHandler(this.ApartmaniPregledFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvApartmani)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbApartman)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvApartmani;
        private System.Windows.Forms.PictureBox pbApartman;
        private System.Windows.Forms.Button btnDodaj;
        private MaterialSkin.Controls.MaterialTextBox txtNaziv;
        private System.Windows.Forms.Button btnPretrazi;
        private MaterialSkin.Controls.MaterialLabel txtNaslov;
        private MaterialSkin.Controls.MaterialComboBox cmbApartmanTip;
        private System.Windows.Forms.DataGridViewImageColumn Slika;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grad;
        private System.Windows.Forms.DataGridViewTextBoxColumn GradId;
        private System.Windows.Forms.DataGridViewTextBoxColumn DrzavaId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApartmanTipId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApartmanTip;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cijena;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaxOsoba;
        private System.Windows.Forms.DataGridViewTextBoxColumn Parking;
        private System.Windows.Forms.DataGridViewTextBoxColumn Balkon;
        private System.Windows.Forms.DataGridViewButtonColumn btnDelete;
    }
}