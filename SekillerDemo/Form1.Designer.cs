namespace SekillerDemo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbGenislik = new System.Windows.Forms.TextBox();
            this.tbYukseklik = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbYariCap = new System.Windows.Forms.TextBox();
            this.lYariCap = new System.Windows.Forms.Label();
            this.bHesapla = new System.Windows.Forms.Button();
            this.ddlSekil = new System.Windows.Forms.ComboBox();
            this.lSekil = new System.Windows.Forms.Label();
            this.lHesap = new System.Windows.Forms.Label();
            this.rbAlan = new System.Windows.Forms.RadioButton();
            this.rbCevre = new System.Windows.Forms.RadioButton();
            this.bCikis = new System.Windows.Forms.Button();
            this.tbSonuc = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.tbGenislik);
            this.panel1.Controls.Add(this.tbYukseklik);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(61, 128);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(253, 146);
            this.panel1.TabIndex = 0;
            this.panel1.Visible = false;
            // 
            // tbGenislik
            // 
            this.tbGenislik.Location = new System.Drawing.Point(113, 22);
            this.tbGenislik.Name = "tbGenislik";
            this.tbGenislik.Size = new System.Drawing.Size(125, 27);
            this.tbGenislik.TabIndex = 3;
            // 
            // tbYukseklik
            // 
            this.tbYukseklik.Location = new System.Drawing.Point(113, 78);
            this.tbYukseklik.Name = "tbYukseklik";
            this.tbYukseklik.Size = new System.Drawing.Size(125, 27);
            this.tbYukseklik.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Yükseklik";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Genişlik";
            // 
            // tbYariCap
            // 
            this.tbYariCap.Location = new System.Drawing.Point(85, 24);
            this.tbYariCap.Name = "tbYariCap";
            this.tbYariCap.Size = new System.Drawing.Size(125, 27);
            this.tbYariCap.TabIndex = 5;
            // 
            // lYariCap
            // 
            this.lYariCap.AutoSize = true;
            this.lYariCap.Location = new System.Drawing.Point(18, 27);
            this.lYariCap.Name = "lYariCap";
            this.lYariCap.Size = new System.Drawing.Size(61, 20);
            this.lYariCap.TabIndex = 4;
            this.lYariCap.Text = "Yarı çap";
            // 
            // bHesapla
            // 
            this.bHesapla.Location = new System.Drawing.Point(61, 292);
            this.bHesapla.Name = "bHesapla";
            this.bHesapla.Size = new System.Drawing.Size(94, 29);
            this.bHesapla.TabIndex = 1;
            this.bHesapla.Text = "Hesapla";
            this.bHesapla.UseVisualStyleBackColor = true;
            this.bHesapla.Click += new System.EventHandler(this.bHesapla_Click);
            // 
            // ddlSekil
            // 
            this.ddlSekil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlSekil.FormattingEnabled = true;
            this.ddlSekil.Location = new System.Drawing.Point(107, 24);
            this.ddlSekil.Name = "ddlSekil";
            this.ddlSekil.Size = new System.Drawing.Size(435, 28);
            this.ddlSekil.TabIndex = 2;
            this.ddlSekil.SelectedIndexChanged += new System.EventHandler(this.ddlSekil_SelectedIndexChanged);
            // 
            // lSekil
            // 
            this.lSekil.AutoSize = true;
            this.lSekil.Location = new System.Drawing.Point(61, 27);
            this.lSekil.Name = "lSekil";
            this.lSekil.Size = new System.Drawing.Size(40, 20);
            this.lSekil.TabIndex = 3;
            this.lSekil.Text = "Şekil";
            // 
            // lHesap
            // 
            this.lHesap.AutoSize = true;
            this.lHesap.Location = new System.Drawing.Point(61, 85);
            this.lHesap.Name = "lHesap";
            this.lHesap.Size = new System.Drawing.Size(51, 20);
            this.lHesap.TabIndex = 4;
            this.lHesap.Text = "Hesap";
            // 
            // rbAlan
            // 
            this.rbAlan.AutoSize = true;
            this.rbAlan.Checked = true;
            this.rbAlan.Location = new System.Drawing.Point(130, 83);
            this.rbAlan.Name = "rbAlan";
            this.rbAlan.Size = new System.Drawing.Size(60, 24);
            this.rbAlan.TabIndex = 5;
            this.rbAlan.TabStop = true;
            this.rbAlan.Text = "Alan";
            this.rbAlan.UseVisualStyleBackColor = true;
            // 
            // rbCevre
            // 
            this.rbCevre.AutoSize = true;
            this.rbCevre.Location = new System.Drawing.Point(196, 83);
            this.rbCevre.Name = "rbCevre";
            this.rbCevre.Size = new System.Drawing.Size(67, 24);
            this.rbCevre.TabIndex = 6;
            this.rbCevre.TabStop = true;
            this.rbCevre.Text = "Çevre";
            this.rbCevre.UseVisualStyleBackColor = true;
            // 
            // bCikis
            // 
            this.bCikis.Location = new System.Drawing.Point(448, 292);
            this.bCikis.Name = "bCikis";
            this.bCikis.Size = new System.Drawing.Size(94, 29);
            this.bCikis.TabIndex = 7;
            this.bCikis.Text = "Çıkış";
            this.bCikis.UseVisualStyleBackColor = true;
            this.bCikis.Click += new System.EventHandler(this.bCikis_Click);
            // 
            // tbSonuc
            // 
            this.tbSonuc.Location = new System.Drawing.Point(176, 293);
            this.tbSonuc.Name = "tbSonuc";
            this.tbSonuc.ReadOnly = true;
            this.tbSonuc.Size = new System.Drawing.Size(240, 27);
            this.tbSonuc.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tbYariCap);
            this.panel2.Controls.Add(this.lYariCap);
            this.panel2.Location = new System.Drawing.Point(320, 128);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(269, 146);
            this.panel2.TabIndex = 9;
            this.panel2.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 380);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.tbSonuc);
            this.Controls.Add(this.bCikis);
            this.Controls.Add(this.rbCevre);
            this.Controls.Add(this.rbAlan);
            this.Controls.Add(this.lHesap);
            this.Controls.Add(this.lSekil);
            this.Controls.Add(this.ddlSekil);
            this.Controls.Add(this.bHesapla);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Şekil App";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private TextBox tbGenislik;
        private TextBox tbYukseklik;
        private Label label2;
        private Label label1;
        private Button bHesapla;
        private ComboBox ddlSekil;
        private Label lSekil;
        private Label lHesap;
        private RadioButton rbAlan;
        private RadioButton rbCevre;
        private TextBox tbYariCap;
        private Label lYariCap;
        private Button bCikis;
        private TextBox tbSonuc;
        private Panel panel2;
    }
}