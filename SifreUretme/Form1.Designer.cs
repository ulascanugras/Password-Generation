
namespace SifreUretme
{
    partial class Form1
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
            this.checkKücükHarf = new System.Windows.Forms.CheckBox();
            this.checkBuyukHarf = new System.Windows.Forms.CheckBox();
            this.checkRakam = new System.Windows.Forms.CheckBox();
            this.checkOzelKarakterler = new System.Windows.Forms.CheckBox();
            this.numSifreSayısı = new System.Windows.Forms.NumericUpDown();
            this.numSifreUzunlugu = new System.Windows.Forms.NumericUpDown();
            this.lblSifreSayısı = new System.Windows.Forms.Label();
            this.lblSifreUzunlugu = new System.Windows.Forms.Label();
            this.btnUret = new System.Windows.Forms.Button();
            this.txtSifre = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numSifreSayısı)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSifreUzunlugu)).BeginInit();
            this.SuspendLayout();
            // 
            // checkKücükHarf
            // 
            this.checkKücükHarf.AutoSize = true;
            this.checkKücükHarf.Location = new System.Drawing.Point(34, 46);
            this.checkKücükHarf.Name = "checkKücükHarf";
            this.checkKücükHarf.Size = new System.Drawing.Size(80, 17);
            this.checkKücükHarf.TabIndex = 0;
            this.checkKücükHarf.Text = "Kücük Harf";
            this.checkKücükHarf.UseVisualStyleBackColor = true;
            // 
            // checkBuyukHarf
            // 
            this.checkBuyukHarf.AutoSize = true;
            this.checkBuyukHarf.Location = new System.Drawing.Point(34, 69);
            this.checkBuyukHarf.Name = "checkBuyukHarf";
            this.checkBuyukHarf.Size = new System.Drawing.Size(79, 17);
            this.checkBuyukHarf.TabIndex = 1;
            this.checkBuyukHarf.Text = "Büyük Harf";
            this.checkBuyukHarf.UseVisualStyleBackColor = true;
            // 
            // checkRakam
            // 
            this.checkRakam.AutoSize = true;
            this.checkRakam.Location = new System.Drawing.Point(34, 92);
            this.checkRakam.Name = "checkRakam";
            this.checkRakam.Size = new System.Drawing.Size(60, 17);
            this.checkRakam.TabIndex = 2;
            this.checkRakam.Text = "Rakam";
            this.checkRakam.UseVisualStyleBackColor = true;
            // 
            // checkOzelKarakterler
            // 
            this.checkOzelKarakterler.AutoSize = true;
            this.checkOzelKarakterler.Location = new System.Drawing.Point(34, 115);
            this.checkOzelKarakterler.Name = "checkOzelKarakterler";
            this.checkOzelKarakterler.Size = new System.Drawing.Size(101, 17);
            this.checkOzelKarakterler.TabIndex = 3;
            this.checkOzelKarakterler.Text = "Özel Karakterler";
            this.checkOzelKarakterler.UseVisualStyleBackColor = true;
            // 
            // numSifreSayısı
            // 
            this.numSifreSayısı.Location = new System.Drawing.Point(133, 162);
            this.numSifreSayısı.Name = "numSifreSayısı";
            this.numSifreSayısı.Size = new System.Drawing.Size(120, 20);
            this.numSifreSayısı.TabIndex = 4;
            // 
            // numSifreUzunlugu
            // 
            this.numSifreUzunlugu.Location = new System.Drawing.Point(133, 190);
            this.numSifreUzunlugu.Name = "numSifreUzunlugu";
            this.numSifreUzunlugu.Size = new System.Drawing.Size(120, 20);
            this.numSifreUzunlugu.TabIndex = 5;
            // 
            // lblSifreSayısı
            // 
            this.lblSifreSayısı.AutoSize = true;
            this.lblSifreSayısı.Location = new System.Drawing.Point(36, 162);
            this.lblSifreSayısı.Name = "lblSifreSayısı";
            this.lblSifreSayısı.Size = new System.Drawing.Size(58, 13);
            this.lblSifreSayısı.TabIndex = 6;
            this.lblSifreSayısı.Text = "Şifre Sayısı";
            // 
            // lblSifreUzunlugu
            // 
            this.lblSifreUzunlugu.AutoSize = true;
            this.lblSifreUzunlugu.Location = new System.Drawing.Point(36, 190);
            this.lblSifreUzunlugu.Name = "lblSifreUzunlugu";
            this.lblSifreUzunlugu.Size = new System.Drawing.Size(76, 13);
            this.lblSifreUzunlugu.TabIndex = 7;
            this.lblSifreUzunlugu.Text = "Sifre Uzunlugu";
            // 
            // btnUret
            // 
            this.btnUret.Location = new System.Drawing.Point(178, 230);
            this.btnUret.Name = "btnUret";
            this.btnUret.Size = new System.Drawing.Size(75, 23);
            this.btnUret.TabIndex = 8;
            this.btnUret.Text = "Üret";
            this.btnUret.UseVisualStyleBackColor = true;
            this.btnUret.Click += new System.EventHandler(this.btnUret_Click);
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(407, 12);
            this.txtSifre.Multiline = true;
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.ReadOnly = true;
            this.txtSifre.Size = new System.Drawing.Size(354, 411);
            this.txtSifre.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.btnUret);
            this.Controls.Add(this.lblSifreUzunlugu);
            this.Controls.Add(this.lblSifreSayısı);
            this.Controls.Add(this.numSifreUzunlugu);
            this.Controls.Add(this.numSifreSayısı);
            this.Controls.Add(this.checkOzelKarakterler);
            this.Controls.Add(this.checkRakam);
            this.Controls.Add(this.checkBuyukHarf);
            this.Controls.Add(this.checkKücükHarf);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numSifreSayısı)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSifreUzunlugu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkKücükHarf;
        private System.Windows.Forms.CheckBox checkBuyukHarf;
        private System.Windows.Forms.CheckBox checkRakam;
        private System.Windows.Forms.CheckBox checkOzelKarakterler;
        private System.Windows.Forms.NumericUpDown numSifreSayısı;
        private System.Windows.Forms.NumericUpDown numSifreUzunlugu;
        private System.Windows.Forms.Label lblSifreSayısı;
        private System.Windows.Forms.Label lblSifreUzunlugu;
        private System.Windows.Forms.Button btnUret;
        private System.Windows.Forms.TextBox txtSifre;
    }
}

