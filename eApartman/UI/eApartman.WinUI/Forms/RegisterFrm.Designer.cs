
namespace eApartman.UI.Forms
{
    partial class RegisterFrm
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
            this.txtIme = new MaterialSkin.Controls.MaterialTextBox();
            this.txtPrezime = new MaterialSkin.Controls.MaterialTextBox();
            this.txtEmail = new MaterialSkin.Controls.MaterialTextBox();
            this.txtUsername = new MaterialSkin.Controls.MaterialTextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.txtTelefon = new MaterialSkin.Controls.MaterialTextBox();
            this.txtLoading = new MaterialSkin.Controls.MaterialLabel();
            this.btnSlika = new System.Windows.Forms.Button();
            this.pbSlika = new System.Windows.Forms.PictureBox();
            this.ofdSlika = new System.Windows.Forms.OpenFileDialog();
            this.txtPassword = new MaterialSkin.Controls.MaterialTextBox();
            this.txtPotvrdaPassword = new MaterialSkin.Controls.MaterialTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbSlika)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIme
            // 
            this.txtIme.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIme.Depth = 0;
            this.txtIme.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtIme.Hint = "Ime";
            this.txtIme.LeadingIcon = null;
            this.txtIme.Location = new System.Drawing.Point(32, 154);
            this.txtIme.Margin = new System.Windows.Forms.Padding(4);
            this.txtIme.MaxLength = 50;
            this.txtIme.MouseState = MaterialSkin.MouseState.OUT;
            this.txtIme.Multiline = false;
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(259, 50);
            this.txtIme.TabIndex = 0;
            this.txtIme.Text = "";
            this.txtIme.TrailingIcon = null;
            this.txtIme.UseAccent = false;
            // 
            // txtPrezime
            // 
            this.txtPrezime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrezime.Depth = 0;
            this.txtPrezime.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPrezime.Hint = "Prezime";
            this.txtPrezime.LeadingIcon = null;
            this.txtPrezime.Location = new System.Drawing.Point(311, 154);
            this.txtPrezime.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrezime.MaxLength = 50;
            this.txtPrezime.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPrezime.Multiline = false;
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(259, 50);
            this.txtPrezime.TabIndex = 1;
            this.txtPrezime.Text = "";
            this.txtPrezime.TrailingIcon = null;
            this.txtPrezime.UseAccent = false;
            // 
            // txtEmail
            // 
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Depth = 0;
            this.txtEmail.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtEmail.Hint = "Email";
            this.txtEmail.LeadingIcon = null;
            this.txtEmail.Location = new System.Drawing.Point(311, 239);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.MaxLength = 50;
            this.txtEmail.MouseState = MaterialSkin.MouseState.OUT;
            this.txtEmail.Multiline = false;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(259, 50);
            this.txtEmail.TabIndex = 4;
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
            this.txtUsername.Location = new System.Drawing.Point(32, 239);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsername.MaxLength = 50;
            this.txtUsername.MouseState = MaterialSkin.MouseState.OUT;
            this.txtUsername.Multiline = false;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(259, 50);
            this.txtUsername.TabIndex = 3;
            this.txtUsername.Text = "";
            this.txtUsername.TrailingIcon = null;
            this.txtUsername.UseAccent = false;
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.btnRegister.FlatAppearance.BorderColor = System.Drawing.Color.GhostWhite;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.btnRegister.ForeColor = System.Drawing.SystemColors.Control;
            this.btnRegister.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegister.ImageKey = "(none)";
            this.btnRegister.Location = new System.Drawing.Point(163, 552);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(276, 57);
            this.btnRegister.TabIndex = 8;
            this.btnRegister.Text = "REGISTER";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // txtTelefon
            // 
            this.txtTelefon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTelefon.Depth = 0;
            this.txtTelefon.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtTelefon.Hint = "Telefon";
            this.txtTelefon.LeadingIcon = null;
            this.txtTelefon.Location = new System.Drawing.Point(32, 318);
            this.txtTelefon.Margin = new System.Windows.Forms.Padding(4);
            this.txtTelefon.MaxLength = 50;
            this.txtTelefon.MouseState = MaterialSkin.MouseState.OUT;
            this.txtTelefon.Multiline = false;
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(259, 50);
            this.txtTelefon.TabIndex = 5;
            this.txtTelefon.Text = "";
            this.txtTelefon.TrailingIcon = null;
            this.txtTelefon.UseAccent = false;
            // 
            // txtLoading
            // 
            this.txtLoading.AutoSize = true;
            this.txtLoading.Depth = 0;
            this.txtLoading.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtLoading.Location = new System.Drawing.Point(257, 118);
            this.txtLoading.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtLoading.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtLoading.Name = "txtLoading";
            this.txtLoading.Size = new System.Drawing.Size(1, 0);
            this.txtLoading.TabIndex = 14;
            this.txtLoading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSlika
            // 
            this.btnSlika.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.btnSlika.FlatAppearance.BorderColor = System.Drawing.Color.GhostWhite;
            this.btnSlika.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSlika.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.btnSlika.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSlika.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSlika.ImageKey = "(none)";
            this.btnSlika.Location = new System.Drawing.Point(387, 486);
            this.btnSlika.Margin = new System.Windows.Forms.Padding(4);
            this.btnSlika.Name = "btnSlika";
            this.btnSlika.Size = new System.Drawing.Size(104, 39);
            this.btnSlika.TabIndex = 7;
            this.btnSlika.Text = "...";
            this.btnSlika.UseVisualStyleBackColor = false;
            this.btnSlika.Click += new System.EventHandler(this.btnSlika_Click);
            // 
            // pbSlika
            // 
            this.pbSlika.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pbSlika.Location = new System.Drawing.Point(353, 328);
            this.pbSlika.Margin = new System.Windows.Forms.Padding(4);
            this.pbSlika.Name = "pbSlika";
            this.pbSlika.Size = new System.Drawing.Size(179, 150);
            this.pbSlika.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSlika.TabIndex = 24;
            this.pbSlika.TabStop = false;
            // 
            // txtPassword
            // 
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Depth = 0;
            this.txtPassword.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPassword.Hint = "Lozinka";
            this.txtPassword.LeadingIcon = null;
            this.txtPassword.Location = new System.Drawing.Point(32, 395);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.MaxLength = 50;
            this.txtPassword.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPassword.Multiline = false;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(259, 50);
            this.txtPassword.TabIndex = 6;
            this.txtPassword.Text = "";
            this.txtPassword.TrailingIcon = null;
            this.txtPassword.UseAccent = false;
            // 
            // txtPotvrdaPassword
            // 
            this.txtPotvrdaPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPotvrdaPassword.Depth = 0;
            this.txtPotvrdaPassword.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPotvrdaPassword.Hint = "Lozinka potvrda";
            this.txtPotvrdaPassword.LeadingIcon = null;
            this.txtPotvrdaPassword.Location = new System.Drawing.Point(32, 475);
            this.txtPotvrdaPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPotvrdaPassword.MaxLength = 50;
            this.txtPotvrdaPassword.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPotvrdaPassword.Multiline = false;
            this.txtPotvrdaPassword.Name = "txtPotvrdaPassword";
            this.txtPotvrdaPassword.Size = new System.Drawing.Size(259, 50);
            this.txtPotvrdaPassword.TabIndex = 7;
            this.txtPotvrdaPassword.Text = "";
            this.txtPotvrdaPassword.TrailingIcon = null;
            this.txtPotvrdaPassword.UseAccent = false;
            // 
            // RegisterFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 620);
            this.Controls.Add(this.txtPotvrdaPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.btnSlika);
            this.Controls.Add(this.pbSlika);
            this.Controls.Add(this.txtLoading);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(this.txtIme);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_48;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "RegisterFrm";
            this.Padding = new System.Windows.Forms.Padding(4, 89, 4, 4);
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "eApartman";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.registerFormClosed);
            this.Load += new System.EventHandler(this.RegisterFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbSlika)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox txtIme;
        private MaterialSkin.Controls.MaterialTextBox txtPrezime;
        private MaterialSkin.Controls.MaterialTextBox txtEmail;
        private MaterialSkin.Controls.MaterialTextBox txtUsername;
        private System.Windows.Forms.Button btnRegister;
        private MaterialSkin.Controls.MaterialTextBox txtTelefon;
        private MaterialSkin.Controls.MaterialLabel txtLoading;
        private System.Windows.Forms.Button btnSlika;
        private System.Windows.Forms.PictureBox pbSlika;
        private System.Windows.Forms.OpenFileDialog ofdSlika;
        private MaterialSkin.Controls.MaterialTextBox txtPassword;
        private MaterialSkin.Controls.MaterialTextBox txtPotvrdaPassword;
    }
}