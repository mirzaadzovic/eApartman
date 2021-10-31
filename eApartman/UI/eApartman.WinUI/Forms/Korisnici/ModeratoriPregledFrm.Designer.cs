
namespace eApartman.WinUI.Forms.Korisnici
{
    partial class ModeratoriPregledFrm
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
            this.txtNaslov = new MaterialSkin.Controls.MaterialLabel();
            this.btnPretrazi = new System.Windows.Forms.Button();
            this.txtUsername = new MaterialSkin.Controls.MaterialTextBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.dgvModeratori = new System.Windows.Forms.DataGridView();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ModeratorApartmani = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ModeratorRezervacije = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Brisanje = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModeratori)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNaslov
            // 
            this.txtNaslov.AutoSize = true;
            this.txtNaslov.Depth = 0;
            this.txtNaslov.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNaslov.Location = new System.Drawing.Point(400, 59);
            this.txtNaslov.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNaslov.Name = "txtNaslov";
            this.txtNaslov.Size = new System.Drawing.Size(140, 19);
            this.txtNaslov.TabIndex = 31;
            this.txtNaslov.Text = "Pregled moderatora";
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
            this.btnPretrazi.Location = new System.Drawing.Point(282, 136);
            this.btnPretrazi.Name = "btnPretrazi";
            this.btnPretrazi.Size = new System.Drawing.Size(140, 50);
            this.btnPretrazi.TabIndex = 30;
            this.btnPretrazi.Text = "PRETRAŽI";
            this.btnPretrazi.UseVisualStyleBackColor = false;
            this.btnPretrazi.Click += new System.EventHandler(this.btnPretrazi_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsername.Depth = 0;
            this.txtUsername.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtUsername.Hint = "Username";
            this.txtUsername.LeadingIcon = null;
            this.txtUsername.Location = new System.Drawing.Point(30, 136);
            this.txtUsername.MaxLength = 50;
            this.txtUsername.MouseState = MaterialSkin.MouseState.OUT;
            this.txtUsername.Multiline = false;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(199, 50);
            this.txtUsername.TabIndex = 29;
            this.txtUsername.Text = "";
            this.txtUsername.TrailingIcon = null;
            this.txtUsername.UseAccent = false;
            this.txtUsername.TextChanged += new System.EventHandler(this.txtNaziv_TextChanged);
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
            this.btnDodaj.Location = new System.Drawing.Point(720, 135);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(134, 50);
            this.btnDodaj.TabIndex = 28;
            this.btnDodaj.Text = "+ DODAJ";
            this.btnDodaj.UseVisualStyleBackColor = false;
            // 
            // dgvModeratori
            // 
            this.dgvModeratori.AllowUserToAddRows = false;
            this.dgvModeratori.AllowUserToDeleteRows = false;
            this.dgvModeratori.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvModeratori.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvModeratori.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvModeratori.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(35)))), ((int)(((byte)(180)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvModeratori.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvModeratori.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvModeratori.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Username,
            this.Ime,
            this.Prezime,
            this.ModeratorApartmani,
            this.ModeratorRezervacije,
            this.Brisanje});
            this.dgvModeratori.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvModeratori.GridColor = System.Drawing.SystemColors.MenuBar;
            this.dgvModeratori.Location = new System.Drawing.Point(30, 218);
            this.dgvModeratori.Name = "dgvModeratori";
            this.dgvModeratori.ReadOnly = true;
            this.dgvModeratori.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvModeratori.Size = new System.Drawing.Size(824, 164);
            this.dgvModeratori.TabIndex = 27;
            // 
            // Username
            // 
            this.Username.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Username.DataPropertyName = "Username";
            this.Username.HeaderText = "Korisničko ime";
            this.Username.Name = "Username";
            this.Username.ReadOnly = true;
            // 
            // Ime
            // 
            this.Ime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Ime.DataPropertyName = "Ime";
            this.Ime.HeaderText = "Ime";
            this.Ime.Name = "Ime";
            this.Ime.ReadOnly = true;
            // 
            // Prezime
            // 
            this.Prezime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Prezime.DataPropertyName = "Prezime";
            this.Prezime.HeaderText = "Prezime";
            this.Prezime.Name = "Prezime";
            this.Prezime.ReadOnly = true;
            // 
            // ModeratorApartmani
            // 
            this.ModeratorApartmani.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ModeratorApartmani.DataPropertyName = "IsModeratorApartmani";
            this.ModeratorApartmani.HeaderText = "Moderator apartmana";
            this.ModeratorApartmani.Name = "ModeratorApartmani";
            this.ModeratorApartmani.ReadOnly = true;
            // 
            // ModeratorRezervacije
            // 
            this.ModeratorRezervacije.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ModeratorRezervacije.DataPropertyName = "IsModeratorRezervacije";
            this.ModeratorRezervacije.HeaderText = "Moderator rezervacija";
            this.ModeratorRezervacije.Name = "ModeratorRezervacije";
            this.ModeratorRezervacije.ReadOnly = true;
            // 
            // Brisanje
            // 
            this.Brisanje.HeaderText = "Obriši";
            this.Brisanje.Name = "Brisanje";
            this.Brisanje.ReadOnly = true;
            this.Brisanje.Text = "Obriši";
            this.Brisanje.UseColumnTextForButtonValue = true;
            // 
            // ModeratoriPregledFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 450);
            this.Controls.Add(this.txtNaslov);
            this.Controls.Add(this.btnPretrazi);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.dgvModeratori);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_None;
            this.Name = "ModeratoriPregledFrm";
            this.Padding = new System.Windows.Forms.Padding(3, 24, 3, 3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "PregledModeratoraFrm";
            this.Load += new System.EventHandler(this.ModeratoriPregledFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvModeratori)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialLabel txtNaslov;
        private System.Windows.Forms.Button btnPretrazi;
        private MaterialSkin.Controls.MaterialTextBox txtUsername;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.DataGridView dgvModeratori;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ModeratorApartmani;
        private System.Windows.Forms.DataGridViewTextBoxColumn ModeratorRezervacije;
        private System.Windows.Forms.DataGridViewButtonColumn Brisanje;
    }
}