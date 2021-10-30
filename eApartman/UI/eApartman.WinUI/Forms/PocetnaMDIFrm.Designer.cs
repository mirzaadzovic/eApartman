
namespace eApartman.WinUI.Forms
{
    partial class PocetnaMDIFrm
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.zatvoriSveProzoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.apartmaniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pregledApartmanaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodavanjeApartmanaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rezervacijeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pregledRezervacijaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodavanjeRezervacijaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.korisniciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mojNalogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pregledModeratoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodavanjeModeratoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izvještajiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.btnRegister = new System.Windows.Forms.Button();
            this.txtUsername = new System.Windows.Forms.Label();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.menuStrip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.menuStrip.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.apartmaniToolStripMenuItem,
            this.rezervacijeToolStripMenuItem,
            this.korisniciToolStripMenuItem,
            this.izvještajiToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(3, 64);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.menuStrip.Size = new System.Drawing.Size(1311, 25);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // fileMenu
            // 
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zatvoriSveProzoreToolStripMenuItem,
            this.logOutToolStripMenuItem});
            this.fileMenu.ForeColor = System.Drawing.SystemColors.Control;
            this.fileMenu.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder;
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(40, 21);
            this.fileMenu.Text = "&File";
            this.fileMenu.CheckedChanged += new System.EventHandler(this.checked_Change);
            // 
            // zatvoriSveProzoreToolStripMenuItem
            // 
            this.zatvoriSveProzoreToolStripMenuItem.Name = "zatvoriSveProzoreToolStripMenuItem";
            this.zatvoriSveProzoreToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.zatvoriSveProzoreToolStripMenuItem.Text = "Zatvori sve prozore";
            this.zatvoriSveProzoreToolStripMenuItem.Click += new System.EventHandler(this.CloseAllToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.logOutToolStripMenuItem.Text = "Log out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.ExitToolsStripMenuItem_Click);
            // 
            // apartmaniToolStripMenuItem
            // 
            this.apartmaniToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pregledApartmanaToolStripMenuItem,
            this.dodavanjeApartmanaToolStripMenuItem});
            this.apartmaniToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apartmaniToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.apartmaniToolStripMenuItem.Name = "apartmaniToolStripMenuItem";
            this.apartmaniToolStripMenuItem.Size = new System.Drawing.Size(84, 21);
            this.apartmaniToolStripMenuItem.Text = "Apartmani";
            this.apartmaniToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.apartmaniToolStripMenuItem.CheckedChanged += new System.EventHandler(this.checked_Change);
            // 
            // pregledApartmanaToolStripMenuItem
            // 
            this.pregledApartmanaToolStripMenuItem.Name = "pregledApartmanaToolStripMenuItem";
            this.pregledApartmanaToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.pregledApartmanaToolStripMenuItem.Text = "Pregled apartmana";
            this.pregledApartmanaToolStripMenuItem.Click += new System.EventHandler(this.pregledApartmanaToolStripMenuItem_Click);
            // 
            // dodavanjeApartmanaToolStripMenuItem
            // 
            this.dodavanjeApartmanaToolStripMenuItem.Name = "dodavanjeApartmanaToolStripMenuItem";
            this.dodavanjeApartmanaToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.dodavanjeApartmanaToolStripMenuItem.Text = "Dodavanje apartmana";
            this.dodavanjeApartmanaToolStripMenuItem.Click += new System.EventHandler(this.dodavanjeApartmanaToolStripMenuItem_Click);
            // 
            // rezervacijeToolStripMenuItem
            // 
            this.rezervacijeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pregledRezervacijaToolStripMenuItem,
            this.dodavanjeRezervacijaToolStripMenuItem});
            this.rezervacijeToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.rezervacijeToolStripMenuItem.Name = "rezervacijeToolStripMenuItem";
            this.rezervacijeToolStripMenuItem.Size = new System.Drawing.Size(87, 21);
            this.rezervacijeToolStripMenuItem.Text = "Rezervacije";
            // 
            // pregledRezervacijaToolStripMenuItem
            // 
            this.pregledRezervacijaToolStripMenuItem.Name = "pregledRezervacijaToolStripMenuItem";
            this.pregledRezervacijaToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.pregledRezervacijaToolStripMenuItem.Text = "Pregled rezervacija";
            // 
            // dodavanjeRezervacijaToolStripMenuItem
            // 
            this.dodavanjeRezervacijaToolStripMenuItem.Name = "dodavanjeRezervacijaToolStripMenuItem";
            this.dodavanjeRezervacijaToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.dodavanjeRezervacijaToolStripMenuItem.Text = "Dodavanje rezervacija";
            // 
            // korisniciToolStripMenuItem
            // 
            this.korisniciToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mojNalogToolStripMenuItem,
            this.pregledModeratoraToolStripMenuItem,
            this.dodavanjeModeratoraToolStripMenuItem});
            this.korisniciToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.korisniciToolStripMenuItem.Name = "korisniciToolStripMenuItem";
            this.korisniciToolStripMenuItem.Size = new System.Drawing.Size(70, 21);
            this.korisniciToolStripMenuItem.Text = "Korisnici";
            // 
            // mojNalogToolStripMenuItem
            // 
            this.mojNalogToolStripMenuItem.Name = "mojNalogToolStripMenuItem";
            this.mojNalogToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.mojNalogToolStripMenuItem.Text = "Moj nalog";
            this.mojNalogToolStripMenuItem.Click += new System.EventHandler(this.mojNalogToolStripMenuItem_Click);
            // 
            // pregledModeratoraToolStripMenuItem
            // 
            this.pregledModeratoraToolStripMenuItem.Name = "pregledModeratoraToolStripMenuItem";
            this.pregledModeratoraToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.pregledModeratoraToolStripMenuItem.Text = "Pregled moderatora";
            this.pregledModeratoraToolStripMenuItem.Click += new System.EventHandler(this.pregledModeratoraToolStripMenuItem_Click);
            // 
            // dodavanjeModeratoraToolStripMenuItem
            // 
            this.dodavanjeModeratoraToolStripMenuItem.Name = "dodavanjeModeratoraToolStripMenuItem";
            this.dodavanjeModeratoraToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.dodavanjeModeratoraToolStripMenuItem.Text = "Dodavanje moderatora";
            this.dodavanjeModeratoraToolStripMenuItem.Click += new System.EventHandler(this.dodavanjeModeratoraToolStripMenuItem_Click);
            // 
            // izvještajiToolStripMenuItem
            // 
            this.izvještajiToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.izvještajiToolStripMenuItem.Name = "izvještajiToolStripMenuItem";
            this.izvještajiToolStripMenuItem.Size = new System.Drawing.Size(71, 21);
            this.izvještajiToolStripMenuItem.Text = "Izvještaji";
            // 
            // toolTip
            // 
            this.toolTip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.toolTip.ForeColor = System.Drawing.SystemColors.Control;
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.btnRegister.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnRegister.ForeColor = System.Drawing.SystemColors.Control;
            this.btnRegister.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegister.ImageKey = "(none)";
            this.btnRegister.Location = new System.Drawing.Point(1100, 58);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(74, 31);
            this.btnRegister.TabIndex = 13;
            this.btnRegister.Text = "Logout";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.ExitToolsStripMenuItem_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.AutoSize = true;
            this.txtUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.txtUsername.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.txtUsername.ForeColor = System.Drawing.SystemColors.Control;
            this.txtUsername.Location = new System.Drawing.Point(1105, 30);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(96, 25);
            this.txtUsername.TabIndex = 14;
            this.txtUsername.Text = "Username";
            this.txtUsername.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.txtUsername.Click += new System.EventHandler(this.txtUsername_Click);
            // 
            // PocetnaMDIFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1317, 650);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.menuStrip);
            this.DrawerAutoHide = false;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "PocetnaMDIFrm";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "eApartman";
            this.Load += new System.EventHandler(this.PocetnaMDIFrm_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileMenu;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem apartmaniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pregledApartmanaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodavanjeApartmanaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rezervacijeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pregledRezervacijaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodavanjeRezervacijaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem korisniciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mojNalogToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodavanjeModeratoraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izvještajiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label txtUsername;
        private System.Windows.Forms.ToolStripMenuItem zatvoriSveProzoreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pregledModeratoraToolStripMenuItem;
    }
}



