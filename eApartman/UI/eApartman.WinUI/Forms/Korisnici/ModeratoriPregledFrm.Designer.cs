
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtNaslov = new MaterialSkin.Controls.MaterialLabel();
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
            this.txtNaslov.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.txtNaslov.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.txtNaslov.Location = new System.Drawing.Point(484, 73);
            this.txtNaslov.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtNaslov.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNaslov.Name = "txtNaslov";
            this.txtNaslov.Size = new System.Drawing.Size(215, 29);
            this.txtNaslov.TabIndex = 31;
            this.txtNaslov.Text = "Pregled moderatora";
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
            this.btnDodaj.Location = new System.Drawing.Point(908, 127);
            this.btnDodaj.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(179, 62);
            this.btnDodaj.TabIndex = 28;
            this.btnDodaj.Text = "+ DODAJ";
            this.btnDodaj.UseVisualStyleBackColor = false;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // dgvModeratori
            // 
            this.dgvModeratori.AllowUserToAddRows = false;
            this.dgvModeratori.AllowUserToDeleteRows = false;
            this.dgvModeratori.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvModeratori.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvModeratori.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvModeratori.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(35)))), ((int)(((byte)(180)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvModeratori.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
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
            this.dgvModeratori.Location = new System.Drawing.Point(47, 197);
            this.dgvModeratori.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvModeratori.Name = "dgvModeratori";
            this.dgvModeratori.ReadOnly = true;
            this.dgvModeratori.RowHeadersWidth = 51;
            this.dgvModeratori.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvModeratori.Size = new System.Drawing.Size(1099, 202);
            this.dgvModeratori.TabIndex = 27;
            // 
            // Username
            // 
            this.Username.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Username.DataPropertyName = "Username";
            this.Username.HeaderText = "Korisničko ime";
            this.Username.MinimumWidth = 6;
            this.Username.Name = "Username";
            this.Username.ReadOnly = true;
            // 
            // Ime
            // 
            this.Ime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Ime.DataPropertyName = "Ime";
            this.Ime.HeaderText = "Ime";
            this.Ime.MinimumWidth = 6;
            this.Ime.Name = "Ime";
            this.Ime.ReadOnly = true;
            // 
            // Prezime
            // 
            this.Prezime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Prezime.DataPropertyName = "Prezime";
            this.Prezime.HeaderText = "Prezime";
            this.Prezime.MinimumWidth = 6;
            this.Prezime.Name = "Prezime";
            this.Prezime.ReadOnly = true;
            // 
            // ModeratorApartmani
            // 
            this.ModeratorApartmani.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ModeratorApartmani.DataPropertyName = "IsModeratorApartmani";
            this.ModeratorApartmani.HeaderText = "Moderator apartmana";
            this.ModeratorApartmani.MinimumWidth = 6;
            this.ModeratorApartmani.Name = "ModeratorApartmani";
            this.ModeratorApartmani.ReadOnly = true;
            // 
            // ModeratorRezervacije
            // 
            this.ModeratorRezervacije.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ModeratorRezervacije.DataPropertyName = "IsModeratorRezervacije";
            this.ModeratorRezervacije.HeaderText = "Moderator rezervacija";
            this.ModeratorRezervacije.MinimumWidth = 6;
            this.ModeratorRezervacije.Name = "ModeratorRezervacije";
            this.ModeratorRezervacije.ReadOnly = true;
            // 
            // Brisanje
            // 
            this.Brisanje.HeaderText = "Obriši";
            this.Brisanje.MinimumWidth = 6;
            this.Brisanje.Name = "Brisanje";
            this.Brisanje.ReadOnly = true;
            this.Brisanje.Text = "Obriši";
            this.Brisanje.UseColumnTextForButtonValue = true;
            this.Brisanje.Width = 125;
            // 
            // ModeratoriPregledFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1223, 496);
            this.Controls.Add(this.txtNaslov);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.dgvModeratori);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ModeratoriPregledFrm";
            this.Padding = new System.Windows.Forms.Padding(4, 30, 4, 4);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "PregledModeratoraFrm";
            this.Load += new System.EventHandler(this.ModeratoriPregledFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvModeratori)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialLabel txtNaslov;
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