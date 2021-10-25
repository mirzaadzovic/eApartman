
namespace eApartman.WinUI.Forms.Apartmani
{
    partial class ApartmaniGradoviFrm
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
            this.txtNaziv = new MaterialSkin.Controls.MaterialTextBox();
            this.txtPostanskiBroj = new MaterialSkin.Controls.MaterialTextBox();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.txtDrzava = new MaterialSkin.Controls.MaterialTextBox();
            this.SuspendLayout();
            // 
            // txtNaslov
            // 
            this.txtNaslov.AutoSize = true;
            this.txtNaslov.Depth = 0;
            this.txtNaslov.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNaslov.Location = new System.Drawing.Point(119, 67);
            this.txtNaslov.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNaslov.Name = "txtNaslov";
            this.txtNaslov.Size = new System.Drawing.Size(139, 19);
            this.txtNaslov.TabIndex = 0;
            this.txtNaslov.Text = "Dodavanje gradova";
            // 
            // txtNaziv
            // 
            this.txtNaziv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNaziv.Depth = 0;
            this.txtNaziv.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNaziv.Hint = "Naziv grada";
            this.txtNaziv.LeadingIcon = null;
            this.txtNaziv.Location = new System.Drawing.Point(59, 126);
            this.txtNaziv.MaxLength = 50;
            this.txtNaziv.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNaziv.Multiline = false;
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(257, 50);
            this.txtNaziv.TabIndex = 1;
            this.txtNaziv.Text = "";
            this.txtNaziv.TrailingIcon = null;
            this.txtNaziv.UseAccent = false;
            // 
            // txtPostanskiBroj
            // 
            this.txtPostanskiBroj.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPostanskiBroj.Depth = 0;
            this.txtPostanskiBroj.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPostanskiBroj.Hint = "Poštanski broj";
            this.txtPostanskiBroj.LeadingIcon = null;
            this.txtPostanskiBroj.Location = new System.Drawing.Point(59, 271);
            this.txtPostanskiBroj.MaxLength = 50;
            this.txtPostanskiBroj.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPostanskiBroj.Multiline = false;
            this.txtPostanskiBroj.Name = "txtPostanskiBroj";
            this.txtPostanskiBroj.Size = new System.Drawing.Size(257, 50);
            this.txtPostanskiBroj.TabIndex = 2;
            this.txtPostanskiBroj.Text = "";
            this.txtPostanskiBroj.TrailingIcon = null;
            this.txtPostanskiBroj.UseAccent = false;
            this.txtPostanskiBroj.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumber_KeyPress);
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
            this.btnSacuvaj.Location = new System.Drawing.Point(59, 353);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(257, 36);
            this.btnSacuvaj.TabIndex = 20;
            this.btnSacuvaj.Text = "SAČUVAJ";
            this.btnSacuvaj.UseVisualStyleBackColor = false;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // txtDrzava
            // 
            this.txtDrzava.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDrzava.Depth = 0;
            this.txtDrzava.Enabled = false;
            this.txtDrzava.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtDrzava.Hint = "Država";
            this.txtDrzava.LeadingIcon = null;
            this.txtDrzava.Location = new System.Drawing.Point(59, 198);
            this.txtDrzava.MaxLength = 50;
            this.txtDrzava.MouseState = MaterialSkin.MouseState.OUT;
            this.txtDrzava.Multiline = false;
            this.txtDrzava.Name = "txtDrzava";
            this.txtDrzava.ReadOnly = true;
            this.txtDrzava.Size = new System.Drawing.Size(257, 50);
            this.txtDrzava.TabIndex = 21;
            this.txtDrzava.Text = "";
            this.txtDrzava.TrailingIcon = null;
            this.txtDrzava.UseAccent = false;
            // 
            // ApartmaniGradoviFrm
            // 
            this.AcceptButton = this.btnSacuvaj;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 440);
            this.Controls.Add(this.txtDrzava);
            this.Controls.Add(this.btnSacuvaj);
            this.Controls.Add(this.txtPostanskiBroj);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.txtNaslov);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_None;
            this.Name = "ApartmaniGradoviFrm";
            this.Padding = new System.Windows.Forms.Padding(3, 24, 3, 3);
            this.ShowIcon = false;
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ApartmaniGradoviFrm";
            this.Load += new System.EventHandler(this.ApartmaniGradoviFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel txtNaslov;
        private MaterialSkin.Controls.MaterialTextBox txtNaziv;
        private MaterialSkin.Controls.MaterialTextBox txtPostanskiBroj;
        private System.Windows.Forms.Button btnSacuvaj;
        private MaterialSkin.Controls.MaterialTextBox txtDrzava;
    }
}