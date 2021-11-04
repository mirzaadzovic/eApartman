
namespace eApartman.WinUI.Forms.Korisnici
{
    partial class MojNalogFrm
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
            this.components = new System.ComponentModel.Container();
            this.txtTelefon = new MaterialSkin.Controls.MaterialTextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.txtPotvrdaPassword = new MaterialSkin.Controls.MaterialTextBox();
            this.txtPassword = new MaterialSkin.Controls.MaterialTextBox();
            this.txtOldPassword = new MaterialSkin.Controls.MaterialTextBox();
            this.txtPrezime = new MaterialSkin.Controls.MaterialTextBox();
            this.txtIme = new MaterialSkin.Controls.MaterialTextBox();
            this.pbSlika = new System.Windows.Forms.PictureBox();
            this.btnSlika = new System.Windows.Forms.Button();
            this.ofdSlika = new System.Windows.Forms.OpenFileDialog();
            this.ttPassword = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbSlika)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTelefon
            // 
            this.txtTelefon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTelefon.Depth = 0;
            this.txtTelefon.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtTelefon.Hint = "Telefon";
            this.txtTelefon.LeadingIcon = null;
            this.txtTelefon.Location = new System.Drawing.Point(617, 278);
            this.txtTelefon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTelefon.MaxLength = 50;
            this.txtTelefon.MouseState = MaterialSkin.MouseState.OUT;
            this.txtTelefon.Multiline = false;
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(259, 50);
            this.txtTelefon.TabIndex = 21;
            this.txtTelefon.Text = "";
            this.txtTelefon.TrailingIcon = null;
            this.txtTelefon.UseAccent = false;
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
            this.btnRegister.Location = new System.Drawing.Point(321, 458);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(287, 57);
            this.btnRegister.TabIndex = 20;
            this.btnRegister.Text = "SAČUVAJ";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // txtPotvrdaPassword
            // 
            this.txtPotvrdaPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPotvrdaPassword.Depth = 0;
            this.txtPotvrdaPassword.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPotvrdaPassword.Hint = "Potvrda lozinke";
            this.txtPotvrdaPassword.LeadingIcon = null;
            this.txtPotvrdaPassword.Location = new System.Drawing.Point(617, 358);
            this.txtPotvrdaPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPotvrdaPassword.MaxLength = 50;
            this.txtPotvrdaPassword.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPotvrdaPassword.Multiline = false;
            this.txtPotvrdaPassword.Name = "txtPotvrdaPassword";
            this.txtPotvrdaPassword.Password = true;
            this.txtPotvrdaPassword.Size = new System.Drawing.Size(259, 50);
            this.txtPotvrdaPassword.TabIndex = 19;
            this.txtPotvrdaPassword.Text = "";
            this.ttPassword.SetToolTip(this.txtPotvrdaPassword, "Unosite samo ako želite promijeniti lozinku");
            this.txtPotvrdaPassword.TrailingIcon = null;
            this.txtPotvrdaPassword.UseAccent = false;
            // 
            // txtPassword
            // 
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Depth = 0;
            this.txtPassword.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPassword.Hint = "Nova lozinka";
            this.txtPassword.LeadingIcon = null;
            this.txtPassword.Location = new System.Drawing.Point(337, 358);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPassword.MaxLength = 50;
            this.txtPassword.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPassword.Multiline = false;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Password = true;
            this.txtPassword.Size = new System.Drawing.Size(259, 50);
            this.txtPassword.TabIndex = 18;
            this.txtPassword.Text = "";
            this.ttPassword.SetToolTip(this.txtPassword, "Unosite samo ako želite promijeniti lozinku");
            this.txtPassword.TrailingIcon = null;
            this.txtPassword.UseAccent = false;
            // 
            // txtOldPassword
            // 
            this.txtOldPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtOldPassword.Depth = 0;
            this.txtOldPassword.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtOldPassword.Hint = "Stara lozinka";
            this.txtOldPassword.LeadingIcon = null;
            this.txtOldPassword.Location = new System.Drawing.Point(57, 358);
            this.txtOldPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtOldPassword.MaxLength = 50;
            this.txtOldPassword.MouseState = MaterialSkin.MouseState.OUT;
            this.txtOldPassword.Multiline = false;
            this.txtOldPassword.Name = "txtOldPassword";
            this.txtOldPassword.Password = true;
            this.txtOldPassword.Size = new System.Drawing.Size(259, 50);
            this.txtOldPassword.TabIndex = 17;
            this.txtOldPassword.Text = "";
            this.txtOldPassword.TrailingIcon = null;
            this.txtOldPassword.UseAccent = false;
            // 
            // txtPrezime
            // 
            this.txtPrezime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrezime.Depth = 0;
            this.txtPrezime.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPrezime.Hint = "Prezime";
            this.txtPrezime.LeadingIcon = null;
            this.txtPrezime.Location = new System.Drawing.Point(337, 278);
            this.txtPrezime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPrezime.MaxLength = 50;
            this.txtPrezime.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPrezime.Multiline = false;
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(259, 50);
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
            this.txtIme.Location = new System.Drawing.Point(57, 278);
            this.txtIme.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIme.MaxLength = 50;
            this.txtIme.MouseState = MaterialSkin.MouseState.OUT;
            this.txtIme.Multiline = false;
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(259, 50);
            this.txtIme.TabIndex = 14;
            this.txtIme.Text = "";
            this.txtIme.TrailingIcon = null;
            this.txtIme.UseAccent = false;
            // 
            // pbSlika
            // 
            this.pbSlika.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pbSlika.Location = new System.Drawing.Point(379, 54);
            this.pbSlika.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbSlika.Name = "pbSlika";
            this.pbSlika.Size = new System.Drawing.Size(179, 150);
            this.pbSlika.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSlika.TabIndex = 22;
            this.pbSlika.TabStop = false;
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
            this.btnSlika.Location = new System.Drawing.Point(413, 212);
            this.btnSlika.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSlika.Name = "btnSlika";
            this.btnSlika.Size = new System.Drawing.Size(104, 39);
            this.btnSlika.TabIndex = 23;
            this.btnSlika.Text = "...";
            this.btnSlika.UseVisualStyleBackColor = false;
            this.btnSlika.Click += new System.EventHandler(this.btnSlika_Click);
            // 
            // ttPassword
            // 
            this.ttPassword.AutoPopDelay = 5000;
            this.ttPassword.InitialDelay = 200;
            this.ttPassword.ReshowDelay = 100;
            this.ttPassword.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ttPassword.ToolTipTitle = "Info";
            // 
            // MojNalogFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 554);
            this.Controls.Add(this.btnSlika);
            this.Controls.Add(this.pbSlika);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.txtPotvrdaPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtOldPassword);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(this.txtIme);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MojNalogFrm";
            this.Padding = new System.Windows.Forms.Padding(4, 30, 4, 4);
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MojNalogFrm";
            this.Load += new System.EventHandler(this.MojNalogFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbSlika)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox txtTelefon;
        private System.Windows.Forms.Button btnRegister;
        private MaterialSkin.Controls.MaterialTextBox txtPotvrdaPassword;
        private MaterialSkin.Controls.MaterialTextBox txtPassword;
        private MaterialSkin.Controls.MaterialTextBox txtOldPassword;
        private MaterialSkin.Controls.MaterialTextBox txtPrezime;
        private MaterialSkin.Controls.MaterialTextBox txtIme;
        private System.Windows.Forms.PictureBox pbSlika;
        private System.Windows.Forms.Button btnSlika;
        private System.Windows.Forms.OpenFileDialog ofdSlika;
        private System.Windows.Forms.ToolTip ttPassword;
    }
}