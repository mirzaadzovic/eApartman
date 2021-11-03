
namespace eApartman.WinUI.Forms.Izvjestaji
{
    partial class IzvjestajFrm
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dtOd = new System.Windows.Forms.DateTimePicker();
            this.dtDo = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.btnMonth = new System.Windows.Forms.Button();
            this.btnGodina = new System.Windows.Forms.Button();
            this.btnSedmica = new System.Windows.Forms.Button();
            this.cbPeriod = new MaterialSkin.Controls.MaterialSwitch();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPeriod = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "eApartman.WinUI.Forms.Izvjestaji.rptZaradaApartmani.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(6, 189);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1253, 443);
            this.reportViewer1.TabIndex = 0;
            // 
            // dtOd
            // 
            this.dtOd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dtOd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtOd.Location = new System.Drawing.Point(354, 74);
            this.dtOd.Name = "dtOd";
            this.dtOd.Size = new System.Drawing.Size(200, 30);
            this.dtOd.TabIndex = 1;
            this.dtOd.ValueChanged += new System.EventHandler(this.dtOd_ValueChanged);
            // 
            // dtDo
            // 
            this.dtDo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dtDo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDo.Location = new System.Drawing.Point(625, 74);
            this.dtDo.Name = "dtDo";
            this.dtDo.Size = new System.Drawing.Size(200, 30);
            this.dtDo.TabIndex = 2;
            this.dtDo.ValueChanged += new System.EventHandler(this.dtOd_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(310, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Od";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(580, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Do";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(490, 35);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(156, 19);
            this.materialLabel1.TabIndex = 5;
            this.materialLabel1.Text = "Zarada po apartmanu";
            // 
            // btnMonth
            // 
            this.btnMonth.Location = new System.Drawing.Point(280, 20);
            this.btnMonth.Name = "btnMonth";
            this.btnMonth.Size = new System.Drawing.Size(86, 34);
            this.btnMonth.TabIndex = 6;
            this.btnMonth.Text = "Mjesec";
            this.btnMonth.UseVisualStyleBackColor = true;
            this.btnMonth.Click += new System.EventHandler(this.btnMjesec);
            // 
            // btnGodina
            // 
            this.btnGodina.Location = new System.Drawing.Point(377, 22);
            this.btnGodina.Name = "btnGodina";
            this.btnGodina.Size = new System.Drawing.Size(86, 33);
            this.btnGodina.TabIndex = 7;
            this.btnGodina.Text = "Godina";
            this.btnGodina.UseVisualStyleBackColor = true;
            this.btnGodina.Click += new System.EventHandler(this.btnGodina_Click);
            // 
            // btnSedmica
            // 
            this.btnSedmica.Location = new System.Drawing.Point(178, 20);
            this.btnSedmica.Name = "btnSedmica";
            this.btnSedmica.Size = new System.Drawing.Size(86, 34);
            this.btnSedmica.TabIndex = 8;
            this.btnSedmica.Text = "Sedmicu";
            this.btnSedmica.UseVisualStyleBackColor = true;
            this.btnSedmica.Click += new System.EventHandler(this.btnSedmica_Click);
            // 
            // cbPeriod
            // 
            this.cbPeriod.AutoSize = true;
            this.cbPeriod.Depth = 0;
            this.cbPeriod.Location = new System.Drawing.Point(12, 18);
            this.cbPeriod.Margin = new System.Windows.Forms.Padding(0);
            this.cbPeriod.MouseLocation = new System.Drawing.Point(-1, -1);
            this.cbPeriod.MouseState = MaterialSkin.MouseState.HOVER;
            this.cbPeriod.Name = "cbPeriod";
            this.cbPeriod.Ripple = true;
            this.cbPeriod.Size = new System.Drawing.Size(58, 37);
            this.cbPeriod.TabIndex = 9;
            this.cbPeriod.UseVisualStyleBackColor = true;
            this.cbPeriod.CheckedChanged += new System.EventHandler(this.materialSwitch1_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPeriod);
            this.groupBox1.Controls.Add(this.cbPeriod);
            this.groupBox1.Controls.Add(this.btnMonth);
            this.groupBox1.Controls.Add(this.btnSedmica);
            this.groupBox1.Controls.Add(this.btnGodina);
            this.groupBox1.Location = new System.Drawing.Point(314, 118);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(511, 65);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Prečica";
            // 
            // txtPeriod
            // 
            this.txtPeriod.AutoSize = true;
            this.txtPeriod.Location = new System.Drawing.Point(86, 27);
            this.txtPeriod.Name = "txtPeriod";
            this.txtPeriod.Size = new System.Drawing.Size(77, 17);
            this.txtPeriod.TabIndex = 10;
            this.txtPeriod.Text = "Prethodnih";
            // 
            // IzvjestajFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1265, 661);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtDo);
            this.Controls.Add(this.dtOd);
            this.Controls.Add(this.reportViewer1);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_None;
            this.Name = "IzvjestajFrm";
            this.Padding = new System.Windows.Forms.Padding(3, 24, 3, 3);
            this.Text = "IzvjestajFrm";
            this.Load += new System.EventHandler(this.IzvjestajFrm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.DateTimePicker dtOd;
        private System.Windows.Forms.DateTimePicker dtDo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.Button btnMonth;
        private System.Windows.Forms.Button btnGodina;
        private System.Windows.Forms.Button btnSedmica;
        private MaterialSkin.Controls.MaterialSwitch cbPeriod;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label txtPeriod;
    }
}