
namespace eApartman.WinUI.Forms.Apartmani
{
    partial class ApartmaniDodavanjeFrm
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
            this.pbUser = new System.Windows.Forms.PictureBox();
            this.txtUsername = new MaterialSkin.Controls.MaterialLabel();
            this.txtNaziv = new MaterialSkin.Controls.MaterialTextBox();
            this.txtAdresa = new MaterialSkin.Controls.MaterialTextBox();
            this.cmbDrzava = new MaterialSkin.Controls.MaterialComboBox();
            this.cmbGrad = new MaterialSkin.Controls.MaterialComboBox();
            this.txtBroj = new MaterialSkin.Controls.MaterialTextBox();
            this.txtCijena = new MaterialSkin.Controls.MaterialTextBox();
            this.txtOsoba = new MaterialSkin.Controls.MaterialTextBox();
            this.cbParking = new MaterialSkin.Controls.MaterialSwitch();
            this.cbBalkon = new MaterialSkin.Controls.MaterialSwitch();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.pbSlika = new System.Windows.Forms.PictureBox();
            this.btnSlika = new System.Windows.Forms.Button();
            this.btnGalerija = new System.Windows.Forms.Button();
            this.txtNaslov = new MaterialSkin.Controls.MaterialLabel();
            this.cmbTipApartmana = new MaterialSkin.Controls.MaterialComboBox();
            this.ofdSlika = new System.Windows.Forms.OpenFileDialog();
            this.btnDodajGrad = new System.Windows.Forms.Button();
            this.ofdGalerija = new System.Windows.Forms.OpenFileDialog();
            this.txtGalerijaCount = new MaterialSkin.Controls.MaterialLabel();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.txtProfilna = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pbUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSlika)).BeginInit();
            this.SuspendLayout();
            // 
            // pbUser
            // 
            this.pbUser.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.pbUser.Location = new System.Drawing.Point(379, 62);
            this.pbUser.Name = "pbUser";
            this.pbUser.Size = new System.Drawing.Size(132, 117);
            this.pbUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbUser.TabIndex = 4;
            this.pbUser.TabStop = false;
            // 
            // txtUsername
            // 
            this.txtUsername.AutoSize = true;
            this.txtUsername.Depth = 0;
            this.txtUsername.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.txtUsername.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.txtUsername.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.txtUsername.Location = new System.Drawing.Point(400, 195);
            this.txtUsername.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(92, 24);
            this.txtUsername.TabIndex = 3;
            this.txtUsername.Text = "Username";
            this.txtUsername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNaziv
            // 
            this.txtNaziv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNaziv.Depth = 0;
            this.txtNaziv.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNaziv.Hint = "Naziv apartmana";
            this.txtNaziv.LeadingIcon = null;
            this.txtNaziv.Location = new System.Drawing.Point(72, 287);
            this.txtNaziv.MaxLength = 50;
            this.txtNaziv.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNaziv.Multiline = false;
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(302, 50);
            this.txtNaziv.TabIndex = 5;
            this.txtNaziv.Text = "";
            this.txtNaziv.TrailingIcon = null;
            this.txtNaziv.UseAccent = false;
            // 
            // txtAdresa
            // 
            this.txtAdresa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAdresa.Depth = 0;
            this.txtAdresa.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtAdresa.Hint = "Adresa";
            this.txtAdresa.LeadingIcon = null;
            this.txtAdresa.Location = new System.Drawing.Point(72, 449);
            this.txtAdresa.MaxLength = 50;
            this.txtAdresa.MouseState = MaterialSkin.MouseState.OUT;
            this.txtAdresa.Multiline = false;
            this.txtAdresa.Name = "txtAdresa";
            this.txtAdresa.Size = new System.Drawing.Size(218, 50);
            this.txtAdresa.TabIndex = 6;
            this.txtAdresa.Text = "";
            this.txtAdresa.TrailingIcon = null;
            this.txtAdresa.UseAccent = false;
            // 
            // cmbDrzava
            // 
            this.cmbDrzava.AutoResize = false;
            this.cmbDrzava.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbDrzava.Depth = 0;
            this.cmbDrzava.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbDrzava.DropDownHeight = 118;
            this.cmbDrzava.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDrzava.DropDownWidth = 121;
            this.cmbDrzava.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbDrzava.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbDrzava.FormattingEnabled = true;
            this.cmbDrzava.Hint = "Država";
            this.cmbDrzava.IntegralHeight = false;
            this.cmbDrzava.ItemHeight = 29;
            this.cmbDrzava.Location = new System.Drawing.Point(72, 356);
            this.cmbDrzava.MaxDropDownItems = 4;
            this.cmbDrzava.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbDrzava.Name = "cmbDrzava";
            this.cmbDrzava.Size = new System.Drawing.Size(302, 35);
            this.cmbDrzava.StartIndex = 0;
            this.cmbDrzava.TabIndex = 7;
            this.cmbDrzava.UseAccent = false;
            this.cmbDrzava.UseTallSize = false;
            this.cmbDrzava.SelectedIndexChanged += new System.EventHandler(this.cmbDrzava_SelectedIndexChanged);
            // 
            // cmbGrad
            // 
            this.cmbGrad.AutoResize = false;
            this.cmbGrad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbGrad.Depth = 0;
            this.cmbGrad.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbGrad.DropDownHeight = 118;
            this.cmbGrad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGrad.DropDownWidth = 121;
            this.cmbGrad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbGrad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbGrad.FormattingEnabled = true;
            this.cmbGrad.Hint = "Grad";
            this.cmbGrad.IntegralHeight = false;
            this.cmbGrad.ItemHeight = 29;
            this.cmbGrad.Location = new System.Drawing.Point(72, 397);
            this.cmbGrad.MaxDropDownItems = 4;
            this.cmbGrad.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbGrad.Name = "cmbGrad";
            this.cmbGrad.Size = new System.Drawing.Size(218, 35);
            this.cmbGrad.StartIndex = 0;
            this.cmbGrad.TabIndex = 8;
            this.cmbGrad.UseAccent = false;
            this.cmbGrad.UseTallSize = false;
            // 
            // txtBroj
            // 
            this.txtBroj.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBroj.Depth = 0;
            this.txtBroj.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtBroj.Hint = "Broj";
            this.txtBroj.LeadingIcon = null;
            this.txtBroj.Location = new System.Drawing.Point(306, 449);
            this.txtBroj.MaxLength = 3;
            this.txtBroj.MouseState = MaterialSkin.MouseState.OUT;
            this.txtBroj.Multiline = false;
            this.txtBroj.Name = "txtBroj";
            this.txtBroj.Size = new System.Drawing.Size(68, 50);
            this.txtBroj.TabIndex = 9;
            this.txtBroj.Text = "";
            this.txtBroj.TrailingIcon = null;
            this.txtBroj.UseAccent = false;
            this.txtBroj.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumber_KeyPress);
            // 
            // txtCijena
            // 
            this.txtCijena.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCijena.Depth = 0;
            this.txtCijena.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCijena.Hint = "Cijena(€)";
            this.txtCijena.LeadingIcon = null;
            this.txtCijena.Location = new System.Drawing.Point(432, 287);
            this.txtCijena.MaxLength = 50;
            this.txtCijena.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCijena.Multiline = false;
            this.txtCijena.Name = "txtCijena";
            this.txtCijena.Size = new System.Drawing.Size(97, 50);
            this.txtCijena.TabIndex = 10;
            this.txtCijena.Text = "";
            this.txtCijena.TrailingIcon = null;
            this.txtCijena.UseAccent = false;
            this.txtCijena.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumber_KeyPress);
            // 
            // txtOsoba
            // 
            this.txtOsoba.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtOsoba.Depth = 0;
            this.txtOsoba.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtOsoba.Hint = "Osoba";
            this.txtOsoba.LeadingIcon = null;
            this.txtOsoba.Location = new System.Drawing.Point(432, 355);
            this.txtOsoba.MaxLength = 50;
            this.txtOsoba.MouseState = MaterialSkin.MouseState.OUT;
            this.txtOsoba.Multiline = false;
            this.txtOsoba.Name = "txtOsoba";
            this.txtOsoba.Size = new System.Drawing.Size(97, 50);
            this.txtOsoba.TabIndex = 11;
            this.txtOsoba.Text = "";
            this.txtOsoba.TrailingIcon = null;
            this.txtOsoba.UseAccent = false;
            this.txtOsoba.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumber_KeyPress);
            // 
            // cbParking
            // 
            this.cbParking.AutoSize = true;
            this.cbParking.Depth = 0;
            this.cbParking.Location = new System.Drawing.Point(404, 420);
            this.cbParking.Margin = new System.Windows.Forms.Padding(0);
            this.cbParking.MouseLocation = new System.Drawing.Point(-1, -1);
            this.cbParking.MouseState = MaterialSkin.MouseState.HOVER;
            this.cbParking.Name = "cbParking";
            this.cbParking.Ripple = true;
            this.cbParking.Size = new System.Drawing.Size(112, 37);
            this.cbParking.TabIndex = 12;
            this.cbParking.Text = "Parking";
            this.cbParking.UseVisualStyleBackColor = true;
            // 
            // cbBalkon
            // 
            this.cbBalkon.AutoSize = true;
            this.cbBalkon.Depth = 0;
            this.cbBalkon.Location = new System.Drawing.Point(404, 473);
            this.cbBalkon.Margin = new System.Windows.Forms.Padding(0);
            this.cbBalkon.MouseLocation = new System.Drawing.Point(-1, -1);
            this.cbBalkon.MouseState = MaterialSkin.MouseState.HOVER;
            this.cbBalkon.Name = "cbBalkon";
            this.cbBalkon.Ripple = true;
            this.cbBalkon.Size = new System.Drawing.Size(107, 37);
            this.cbBalkon.TabIndex = 13;
            this.cbBalkon.Text = "Balkon";
            this.cbBalkon.UseVisualStyleBackColor = true;
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.btnSacuvaj.FlatAppearance.BorderColor = System.Drawing.Color.GhostWhite;
            this.btnSacuvaj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSacuvaj.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.btnSacuvaj.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSacuvaj.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSacuvaj.ImageKey = "(none)";
            this.btnSacuvaj.Location = new System.Drawing.Point(252, 581);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(441, 36);
            this.btnSacuvaj.TabIndex = 19;
            this.btnSacuvaj.Text = "SAČUVAJ";
            this.btnSacuvaj.UseVisualStyleBackColor = false;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // pbSlika
            // 
            this.pbSlika.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.pbSlika.Location = new System.Drawing.Point(584, 287);
            this.pbSlika.Name = "pbSlika";
            this.pbSlika.Size = new System.Drawing.Size(266, 157);
            this.pbSlika.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSlika.TabIndex = 20;
            this.pbSlika.TabStop = false;
            // 
            // btnSlika
            // 
            this.btnSlika.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.btnSlika.FlatAppearance.BorderColor = System.Drawing.Color.Honeydew;
            this.btnSlika.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSlika.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.btnSlika.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSlika.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSlika.ImageKey = "(none)";
            this.btnSlika.Location = new System.Drawing.Point(617, 463);
            this.btnSlika.Name = "btnSlika";
            this.btnSlika.Size = new System.Drawing.Size(203, 36);
            this.btnSlika.TabIndex = 22;
            this.btnSlika.Text = "DODAJ PROFILNU...";
            this.btnSlika.UseVisualStyleBackColor = false;
            this.btnSlika.Click += new System.EventHandler(this.btnSlika_Click);
            // 
            // btnGalerija
            // 
            this.btnGalerija.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.btnGalerija.FlatAppearance.BorderColor = System.Drawing.Color.GhostWhite;
            this.btnGalerija.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGalerija.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.btnGalerija.ForeColor = System.Drawing.SystemColors.Control;
            this.btnGalerija.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGalerija.ImageKey = "(none)";
            this.btnGalerija.Location = new System.Drawing.Point(617, 513);
            this.btnGalerija.Name = "btnGalerija";
            this.btnGalerija.Size = new System.Drawing.Size(203, 36);
            this.btnGalerija.TabIndex = 23;
            this.btnGalerija.Text = "DODAJ GALERIJU...";
            this.btnGalerija.UseVisualStyleBackColor = false;
            this.btnGalerija.Click += new System.EventHandler(this.btnGalerija_Click);
            // 
            // txtNaslov
            // 
            this.txtNaslov.AutoSize = true;
            this.txtNaslov.Depth = 0;
            this.txtNaslov.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNaslov.Location = new System.Drawing.Point(370, 233);
            this.txtNaslov.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNaslov.Name = "txtNaslov";
            this.txtNaslov.Size = new System.Drawing.Size(159, 19);
            this.txtNaslov.TabIndex = 24;
            this.txtNaslov.Text = "Dodavanje apartmana";
            // 
            // cmbTipApartmana
            // 
            this.cmbTipApartmana.AutoResize = false;
            this.cmbTipApartmana.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbTipApartmana.Depth = 0;
            this.cmbTipApartmana.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbTipApartmana.DropDownHeight = 118;
            this.cmbTipApartmana.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipApartmana.DropDownWidth = 121;
            this.cmbTipApartmana.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbTipApartmana.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbTipApartmana.FormattingEnabled = true;
            this.cmbTipApartmana.Hint = "Tip apartmana";
            this.cmbTipApartmana.IntegralHeight = false;
            this.cmbTipApartmana.ItemHeight = 29;
            this.cmbTipApartmana.Location = new System.Drawing.Point(72, 518);
            this.cmbTipApartmana.MaxDropDownItems = 4;
            this.cmbTipApartmana.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbTipApartmana.Name = "cmbTipApartmana";
            this.cmbTipApartmana.Size = new System.Drawing.Size(302, 35);
            this.cmbTipApartmana.StartIndex = 0;
            this.cmbTipApartmana.TabIndex = 25;
            this.cmbTipApartmana.UseAccent = false;
            this.cmbTipApartmana.UseTallSize = false;
            // 
            // btnDodajGrad
            // 
            this.btnDodajGrad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.btnDodajGrad.FlatAppearance.BorderColor = System.Drawing.Color.Honeydew;
            this.btnDodajGrad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDodajGrad.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.btnDodajGrad.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDodajGrad.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDodajGrad.ImageKey = "(none)";
            this.btnDodajGrad.Location = new System.Drawing.Point(306, 399);
            this.btnDodajGrad.Name = "btnDodajGrad";
            this.btnDodajGrad.Size = new System.Drawing.Size(68, 33);
            this.btnDodajGrad.TabIndex = 26;
            this.btnDodajGrad.Text = "...";
            this.btnDodajGrad.UseVisualStyleBackColor = false;
            this.btnDodajGrad.Click += new System.EventHandler(this.btnDodajGrad_Click);
            // 
            // txtGalerijaCount
            // 
            this.txtGalerijaCount.AutoSize = true;
            this.txtGalerijaCount.Depth = 0;
            this.txtGalerijaCount.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtGalerijaCount.FontType = MaterialSkin.MaterialSkinManager.fontType.Body2;
            this.txtGalerijaCount.Location = new System.Drawing.Point(825, 526);
            this.txtGalerijaCount.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtGalerijaCount.Name = "txtGalerijaCount";
            this.txtGalerijaCount.Size = new System.Drawing.Size(12, 17);
            this.txtGalerijaCount.TabIndex = 27;
            this.txtGalerijaCount.Text = "0 ";
            // 
            // btnPrev
            // 
            this.btnPrev.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.btnPrev.FlatAppearance.BorderColor = System.Drawing.Color.Honeydew;
            this.btnPrev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrev.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.btnPrev.ForeColor = System.Drawing.SystemColors.Control;
            this.btnPrev.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrev.ImageKey = "(none)";
            this.btnPrev.Location = new System.Drawing.Point(548, 346);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(30, 36);
            this.btnPrev.TabIndex = 28;
            this.btnPrev.Text = "<";
            this.btnPrev.UseVisualStyleBackColor = false;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.btnNext.FlatAppearance.BorderColor = System.Drawing.Color.Honeydew;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.btnNext.ForeColor = System.Drawing.SystemColors.Control;
            this.btnNext.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNext.ImageKey = "(none)";
            this.btnNext.Location = new System.Drawing.Point(856, 349);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(30, 36);
            this.btnNext.TabIndex = 29;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // txtProfilna
            // 
            this.txtProfilna.AutoSize = true;
            this.txtProfilna.Depth = 0;
            this.txtProfilna.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtProfilna.Location = new System.Drawing.Point(666, 265);
            this.txtProfilna.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtProfilna.Name = "txtProfilna";
            this.txtProfilna.Size = new System.Drawing.Size(94, 19);
            this.txtProfilna.TabIndex = 30;
            this.txtProfilna.Text = "Profilna slika";
            // 
            // ApartmaniDodavanjeFrm
            // 
            this.AcceptButton = this.btnSacuvaj;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(914, 648);
            this.Controls.Add(this.txtProfilna);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.txtGalerijaCount);
            this.Controls.Add(this.btnDodajGrad);
            this.Controls.Add(this.cmbTipApartmana);
            this.Controls.Add(this.txtNaslov);
            this.Controls.Add(this.btnGalerija);
            this.Controls.Add(this.btnSlika);
            this.Controls.Add(this.pbSlika);
            this.Controls.Add(this.btnSacuvaj);
            this.Controls.Add(this.cbBalkon);
            this.Controls.Add(this.cbParking);
            this.Controls.Add(this.txtOsoba);
            this.Controls.Add(this.txtCijena);
            this.Controls.Add(this.txtBroj);
            this.Controls.Add(this.cmbGrad);
            this.Controls.Add(this.cmbDrzava);
            this.Controls.Add(this.txtAdresa);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.pbUser);
            this.Controls.Add(this.txtUsername);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_None;
            this.Name = "ApartmaniDodavanjeFrm";
            this.Padding = new System.Windows.Forms.Padding(3, 24, 3, 3);
            this.ShowIcon = false;
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "eApartman";
            this.Load += new System.EventHandler(this.ApartmaniDodavanjeFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSlika)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbUser;
        private MaterialSkin.Controls.MaterialLabel txtUsername;
        private MaterialSkin.Controls.MaterialTextBox txtNaziv;
        private MaterialSkin.Controls.MaterialTextBox txtAdresa;
        private MaterialSkin.Controls.MaterialComboBox cmbDrzava;
        private MaterialSkin.Controls.MaterialTextBox txtBroj;
        private MaterialSkin.Controls.MaterialTextBox txtCijena;
        private MaterialSkin.Controls.MaterialTextBox txtOsoba;
        private MaterialSkin.Controls.MaterialSwitch cbParking;
        private MaterialSkin.Controls.MaterialSwitch cbBalkon;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.PictureBox pbSlika;
        private System.Windows.Forms.Button btnSlika;
        private System.Windows.Forms.Button btnGalerija;
        private MaterialSkin.Controls.MaterialLabel txtNaslov;
        private MaterialSkin.Controls.MaterialComboBox cmbTipApartmana;
        private System.Windows.Forms.OpenFileDialog ofdSlika;
        private System.Windows.Forms.Button btnDodajGrad;
        private MaterialSkin.Controls.MaterialComboBox cmbGrad;
        private System.Windows.Forms.OpenFileDialog ofdGalerija;
        private MaterialSkin.Controls.MaterialLabel txtGalerijaCount;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnNext;
        private MaterialSkin.Controls.MaterialLabel txtProfilna;
    }
}