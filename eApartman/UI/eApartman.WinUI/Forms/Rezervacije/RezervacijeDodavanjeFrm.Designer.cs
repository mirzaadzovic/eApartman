
namespace eApartman.WinUI.Forms.Rezervacije
{
    partial class RezervacijeDodavanjeFrm
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
            this.txtNaslov = new MaterialSkin.Controls.MaterialLabel();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.txtIme = new MaterialSkin.Controls.MaterialTextBox();
            this.cmbApartman = new MaterialSkin.Controls.MaterialComboBox();
            this.pbUser = new System.Windows.Forms.PictureBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.sldOsoba = new MaterialSkin.Controls.MaterialSlider();
            this.txtPrezime = new MaterialSkin.Controls.MaterialTextBox();
            this.dtOd = new System.Windows.Forms.DateTimePicker();
            this.dtDo = new System.Windows.Forms.DateTimePicker();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.txtStatus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbUser)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNaslov
            // 
            this.txtNaslov.AutoSize = true;
            this.txtNaslov.Depth = 0;
            this.txtNaslov.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNaslov.Location = new System.Drawing.Point(243, 180);
            this.txtNaslov.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNaslov.Name = "txtNaslov";
            this.txtNaslov.Size = new System.Drawing.Size(157, 19);
            this.txtNaslov.TabIndex = 30;
            this.txtNaslov.Text = "Dodavanje rezervacija";
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
            this.btnSacuvaj.Location = new System.Drawing.Point(315, 558);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(441, 36);
            this.btnSacuvaj.TabIndex = 29;
            this.btnSacuvaj.Text = "SAČUVAJ";
            this.btnSacuvaj.UseVisualStyleBackColor = false;
            // 
            // txtIme
            // 
            this.txtIme.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIme.Depth = 0;
            this.txtIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtIme.Hint = "Ime";
            this.txtIme.LeadingIcon = null;
            this.txtIme.Location = new System.Drawing.Point(60, 282);
            this.txtIme.MaxLength = 50;
            this.txtIme.MouseState = MaterialSkin.MouseState.OUT;
            this.txtIme.Multiline = false;
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(238, 50);
            this.txtIme.TabIndex = 27;
            this.txtIme.Text = "";
            this.txtIme.TrailingIcon = null;
            this.txtIme.UseAccent = false;
            // 
            // cmbApartman
            // 
            this.cmbApartman.AutoResize = false;
            this.cmbApartman.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbApartman.Depth = 0;
            this.cmbApartman.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbApartman.DropDownHeight = 118;
            this.cmbApartman.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbApartman.DropDownWidth = 121;
            this.cmbApartman.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbApartman.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbApartman.FormattingEnabled = true;
            this.cmbApartman.Hint = "Apartmani loading...";
            this.cmbApartman.IntegralHeight = false;
            this.cmbApartman.ItemHeight = 29;
            this.cmbApartman.Location = new System.Drawing.Point(60, 228);
            this.cmbApartman.MaxDropDownItems = 4;
            this.cmbApartman.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbApartman.Name = "cmbApartman";
            this.cmbApartman.Size = new System.Drawing.Size(238, 35);
            this.cmbApartman.StartIndex = 0;
            this.cmbApartman.TabIndex = 26;
            this.cmbApartman.UseAccent = false;
            this.cmbApartman.UseTallSize = false;
            this.cmbApartman.SelectedIndexChanged += new System.EventHandler(this.cmbApartman_SelectedIndexChanged);
            // 
            // pbUser
            // 
            this.pbUser.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.pbUser.Location = new System.Drawing.Point(252, 39);
            this.pbUser.Name = "pbUser";
            this.pbUser.Size = new System.Drawing.Size(133, 117);
            this.pbUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbUser.TabIndex = 25;
            this.pbUser.TabStop = false;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.GhostWhite;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.ImageKey = "(none)";
            this.btnSave.Location = new System.Drawing.Point(85, 451);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(442, 36);
            this.btnSave.TabIndex = 31;
            this.btnSave.Text = "SAČUVAJ";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // sldOsoba
            // 
            this.sldOsoba.Depth = 0;
            this.sldOsoba.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.sldOsoba.Location = new System.Drawing.Point(356, 228);
            this.sldOsoba.MouseState = MaterialSkin.MouseState.HOVER;
            this.sldOsoba.Name = "sldOsoba";
            this.sldOsoba.RangeMax = 5;
            this.sldOsoba.Size = new System.Drawing.Size(171, 40);
            this.sldOsoba.TabIndex = 32;
            this.sldOsoba.Text = "Osoba";
            this.sldOsoba.Value = 0;
            // 
            // txtPrezime
            // 
            this.txtPrezime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrezime.Depth = 0;
            this.txtPrezime.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPrezime.Hint = "Prezime";
            this.txtPrezime.LeadingIcon = null;
            this.txtPrezime.Location = new System.Drawing.Point(60, 354);
            this.txtPrezime.MaxLength = 50;
            this.txtPrezime.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPrezime.Multiline = false;
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(238, 50);
            this.txtPrezime.TabIndex = 33;
            this.txtPrezime.Text = "";
            this.txtPrezime.TrailingIcon = null;
            this.txtPrezime.UseAccent = false;
            // 
            // dtOd
            // 
            this.dtOd.CalendarMonthBackground = System.Drawing.SystemColors.ButtonFace;
            this.dtOd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtOd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtOd.Location = new System.Drawing.Point(350, 303);
            this.dtOd.Name = "dtOd";
            this.dtOd.Size = new System.Drawing.Size(201, 29);
            this.dtOd.TabIndex = 34;
            this.dtOd.ValueChanged += new System.EventHandler(this.dtOd_ValueChanged);
            // 
            // dtDo
            // 
            this.dtDo.CalendarMonthBackground = System.Drawing.SystemColors.ButtonFace;
            this.dtDo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtDo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDo.Location = new System.Drawing.Point(350, 375);
            this.dtDo.Name = "dtDo";
            this.dtDo.Size = new System.Drawing.Size(201, 29);
            this.dtDo.TabIndex = 35;
            this.dtDo.ValueChanged += new System.EventHandler(this.dtOd_ValueChanged);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(353, 282);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(61, 19);
            this.materialLabel1.TabIndex = 36;
            this.materialLabel1.Text = "Check-In";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(353, 353);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(73, 19);
            this.materialLabel2.TabIndex = 37;
            this.materialLabel2.Text = "Check-Out";
            // 
            // txtStatus
            // 
            this.txtStatus.AutoSize = true;
            this.txtStatus.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStatus.Location = new System.Drawing.Point(476, 407);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(0, 20);
            this.txtStatus.TabIndex = 38;
            // 
            // RezervacijeDodavanjeFrm
            // 
            this.AcceptButton = this.btnSacuvaj;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 493);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.dtDo);
            this.Controls.Add(this.dtOd);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(this.sldOsoba);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtNaslov);
            this.Controls.Add(this.btnSacuvaj);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.cmbApartman);
            this.Controls.Add(this.pbUser);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_None;
            this.Name = "RezervacijeDodavanjeFrm";
            this.Padding = new System.Windows.Forms.Padding(3, 24, 3, 3);
            this.Sizable = false;
            this.Text = "RezervacijeDodavanjeFr";
            this.Load += new System.EventHandler(this.RezervacijeDodavanjeFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel txtNaslov;
        private System.Windows.Forms.Button btnSacuvaj;
        private MaterialSkin.Controls.MaterialTextBox txtIme;
        private MaterialSkin.Controls.MaterialComboBox cmbApartman;
        private System.Windows.Forms.PictureBox pbUser;
        private System.Windows.Forms.Button btnSave;
        private MaterialSkin.Controls.MaterialSlider sldOsoba;
        private MaterialSkin.Controls.MaterialTextBox txtPrezime;
        private System.Windows.Forms.DateTimePicker dtOd;
        private System.Windows.Forms.DateTimePicker dtDo;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.Label txtStatus;
    }
}