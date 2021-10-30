
namespace eApartman.WinUI.Forms.Korisnici
{
    partial class ModeratoriDodavanjeFrm
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
            this.txtTelefon = new MaterialSkin.Controls.MaterialTextBox();
            this.txtEmail = new MaterialSkin.Controls.MaterialTextBox();
            this.txtUsername = new MaterialSkin.Controls.MaterialTextBox();
            this.txtPrezime = new MaterialSkin.Controls.MaterialTextBox();
            this.txtIme = new MaterialSkin.Controls.MaterialTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbRezervacije = new MaterialSkin.Controls.MaterialSwitch();
            this.cmbApartmani = new MaterialSkin.Controls.MaterialSwitch();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.txtPassword = new MaterialSkin.Controls.MaterialTextBox();
            this.txtPasswordPotvrda = new MaterialSkin.Controls.MaterialTextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTelefon
            // 
            this.txtTelefon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTelefon.Depth = 0;
            this.txtTelefon.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtTelefon.Hint = "Telefon";
            this.txtTelefon.LeadingIcon = null;
            this.txtTelefon.Location = new System.Drawing.Point(255, 134);
            this.txtTelefon.MaxLength = 50;
            this.txtTelefon.MouseState = MaterialSkin.MouseState.OUT;
            this.txtTelefon.Multiline = false;
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(194, 50);
            this.txtTelefon.TabIndex = 20;
            this.txtTelefon.Text = "";
            this.txtTelefon.TrailingIcon = null;
            this.txtTelefon.UseAccent = false;
            // 
            // txtEmail
            // 
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Depth = 0;
            this.txtEmail.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtEmail.Hint = "Email";
            this.txtEmail.LeadingIcon = null;
            this.txtEmail.Location = new System.Drawing.Point(46, 134);
            this.txtEmail.MaxLength = 50;
            this.txtEmail.MouseState = MaterialSkin.MouseState.OUT;
            this.txtEmail.Multiline = false;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(194, 50);
            this.txtEmail.TabIndex = 17;
            this.txtEmail.Text = "";
            this.txtEmail.TrailingIcon = null;
            this.txtEmail.UseAccent = false;
            // 
            // txtUsername
            // 
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsername.Depth = 0;
            this.txtUsername.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtUsername.Hint = "Korisničko ime";
            this.txtUsername.LeadingIcon = null;
            this.txtUsername.Location = new System.Drawing.Point(464, 68);
            this.txtUsername.MaxLength = 50;
            this.txtUsername.MouseState = MaterialSkin.MouseState.OUT;
            this.txtUsername.Multiline = false;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(194, 50);
            this.txtUsername.TabIndex = 16;
            this.txtUsername.Text = "";
            this.txtUsername.TrailingIcon = null;
            this.txtUsername.UseAccent = false;
            // 
            // txtPrezime
            // 
            this.txtPrezime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrezime.Depth = 0;
            this.txtPrezime.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPrezime.Hint = "Prezime";
            this.txtPrezime.LeadingIcon = null;
            this.txtPrezime.Location = new System.Drawing.Point(255, 68);
            this.txtPrezime.MaxLength = 50;
            this.txtPrezime.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPrezime.Multiline = false;
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(194, 50);
            this.txtPrezime.TabIndex = 15;
            this.txtPrezime.Text = "";
            this.txtPrezime.TrailingIcon = null;
            this.txtPrezime.UseAccent = false;
            // 
            // txtIme
            // 
            this.txtIme.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIme.Depth = 0;
            this.txtIme.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtIme.Hint = "Ime";
            this.txtIme.LeadingIcon = null;
            this.txtIme.Location = new System.Drawing.Point(46, 68);
            this.txtIme.MaxLength = 50;
            this.txtIme.MouseState = MaterialSkin.MouseState.OUT;
            this.txtIme.Multiline = false;
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(194, 50);
            this.txtIme.TabIndex = 14;
            this.txtIme.Text = "";
            this.txtIme.TrailingIcon = null;
            this.txtIme.UseAccent = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbRezervacije);
            this.groupBox1.Controls.Add(this.cmbApartmani);
            this.groupBox1.Location = new System.Drawing.Point(464, 124);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(225, 129);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Uloge";
            // 
            // cmbRezervacije
            // 
            this.cmbRezervacije.AutoSize = true;
            this.cmbRezervacije.Depth = 0;
            this.cmbRezervacije.Location = new System.Drawing.Point(7, 73);
            this.cmbRezervacije.Margin = new System.Windows.Forms.Padding(0);
            this.cmbRezervacije.MouseLocation = new System.Drawing.Point(-1, -1);
            this.cmbRezervacije.MouseState = MaterialSkin.MouseState.HOVER;
            this.cmbRezervacije.Name = "cmbRezervacije";
            this.cmbRezervacije.Ripple = true;
            this.cmbRezervacije.Size = new System.Drawing.Size(211, 37);
            this.cmbRezervacije.TabIndex = 1;
            this.cmbRezervacije.Text = "ModeratorRezervacije";
            this.cmbRezervacije.UseVisualStyleBackColor = true;
            // 
            // cmbApartmani
            // 
            this.cmbApartmani.AutoSize = true;
            this.cmbApartmani.Depth = 0;
            this.cmbApartmani.Location = new System.Drawing.Point(7, 23);
            this.cmbApartmani.Margin = new System.Windows.Forms.Padding(0);
            this.cmbApartmani.MouseLocation = new System.Drawing.Point(-1, -1);
            this.cmbApartmani.MouseState = MaterialSkin.MouseState.HOVER;
            this.cmbApartmani.Name = "cmbApartmani";
            this.cmbApartmani.Ripple = true;
            this.cmbApartmani.Size = new System.Drawing.Size(205, 37);
            this.cmbApartmani.TabIndex = 0;
            this.cmbApartmani.Text = "ModeratorApartmani";
            this.cmbApartmani.UseVisualStyleBackColor = true;
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
            this.btnDodaj.Location = new System.Drawing.Point(255, 290);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(207, 46);
            this.btnDodaj.TabIndex = 22;
            this.btnDodaj.Text = "DODAJ";
            this.btnDodaj.UseVisualStyleBackColor = false;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Depth = 0;
            this.txtPassword.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPassword.Hint = "Lozinka";
            this.txtPassword.LeadingIcon = null;
            this.txtPassword.Location = new System.Drawing.Point(46, 203);
            this.txtPassword.MaxLength = 50;
            this.txtPassword.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPassword.Multiline = false;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(194, 50);
            this.txtPassword.TabIndex = 30;
            this.txtPassword.Text = "";
            this.txtPassword.TrailingIcon = null;
            this.txtPassword.UseAccent = false;
            // 
            // txtPasswordPotvrda
            // 
            this.txtPasswordPotvrda.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPasswordPotvrda.Depth = 0;
            this.txtPasswordPotvrda.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPasswordPotvrda.Hint = "Lozinka potvrda";
            this.txtPasswordPotvrda.LeadingIcon = null;
            this.txtPasswordPotvrda.Location = new System.Drawing.Point(255, 203);
            this.txtPasswordPotvrda.MaxLength = 50;
            this.txtPasswordPotvrda.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPasswordPotvrda.Multiline = false;
            this.txtPasswordPotvrda.Name = "txtPasswordPotvrda";
            this.txtPasswordPotvrda.Size = new System.Drawing.Size(194, 50);
            this.txtPasswordPotvrda.TabIndex = 31;
            this.txtPasswordPotvrda.Text = "";
            this.txtPasswordPotvrda.TrailingIcon = null;
            this.txtPasswordPotvrda.UseAccent = false;
            // 
            // DodajModeratoraFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 382);
            this.Controls.Add(this.txtPasswordPotvrda);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(this.txtIme);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_None;
            this.Name = "DodajModeratoraFrm";
            this.Padding = new System.Windows.Forms.Padding(3, 24, 3, 3);
            this.Text = "DodajModeratoraFrm";
            this.Load += new System.EventHandler(this.DodajModeratoraFrm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox txtTelefon;
        private MaterialSkin.Controls.MaterialTextBox txtEmail;
        private MaterialSkin.Controls.MaterialTextBox txtUsername;
        private MaterialSkin.Controls.MaterialTextBox txtPrezime;
        private MaterialSkin.Controls.MaterialTextBox txtIme;
        private System.Windows.Forms.GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialSwitch cmbRezervacije;
        private MaterialSkin.Controls.MaterialSwitch cmbApartmani;
        private System.Windows.Forms.Button btnDodaj;
        private MaterialSkin.Controls.MaterialTextBox txtPassword;
        private MaterialSkin.Controls.MaterialTextBox txtPasswordPotvrda;
    }
}