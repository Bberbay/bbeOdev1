namespace bbeOdev1
{
    partial class FrmTopla
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtSayi1 = new System.Windows.Forms.TextBox();
            this.txtSayi2 = new System.Windows.Forms.TextBox();
            this.txtSonuc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnTopla = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnOncekiSonuclar = new System.Windows.Forms.Button();
            this.listSonuclar = new System.Windows.Forms.ListBox();
            this.GrpBoxSonuclar = new System.Windows.Forms.GroupBox();
            this.GrpBoxSonuclar.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSayi1
            // 
            this.txtSayi1.Location = new System.Drawing.Point(55, 25);
            this.txtSayi1.Name = "txtSayi1";
            this.txtSayi1.Size = new System.Drawing.Size(111, 20);
            this.txtSayi1.TabIndex = 0;
            this.txtSayi1.TextChanged += new System.EventHandler(this.TxtSayi1_TextChanged);
            this.txtSayi1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtSayi1_KeyPress);
            // 
            // txtSayi2
            // 
            this.txtSayi2.Location = new System.Drawing.Point(54, 51);
            this.txtSayi2.Name = "txtSayi2";
            this.txtSayi2.Size = new System.Drawing.Size(112, 20);
            this.txtSayi2.TabIndex = 1;
            this.txtSayi2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtSayi2_KeyPress);
            // 
            // txtSonuc
            // 
            this.txtSonuc.Enabled = false;
            this.txtSonuc.Location = new System.Drawing.Point(54, 119);
            this.txtSonuc.Name = "txtSonuc";
            this.txtSonuc.ReadOnly = true;
            this.txtSonuc.Size = new System.Drawing.Size(112, 20);
            this.txtSonuc.TabIndex = 2;
            this.txtSonuc.TextChanged += new System.EventHandler(this.TxtSonuc_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Sayı 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Sayı 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Sonuç";
            // 
            // BtnTopla
            // 
            this.BtnTopla.Location = new System.Drawing.Point(15, 77);
            this.BtnTopla.Name = "BtnTopla";
            this.BtnTopla.Size = new System.Drawing.Size(74, 27);
            this.BtnTopla.TabIndex = 6;
            this.BtnTopla.Text = "Topla";
            this.BtnTopla.UseVisualStyleBackColor = true;
            this.BtnTopla.Click += new System.EventHandler(this.BtnTopla_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(92, 77);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(74, 27);
            this.btnTemizle.TabIndex = 7;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btnOncekiSonuclar
            // 
            this.btnOncekiSonuclar.Location = new System.Drawing.Point(15, 145);
            this.btnOncekiSonuclar.Name = "btnOncekiSonuclar";
            this.btnOncekiSonuclar.Size = new System.Drawing.Size(156, 27);
            this.btnOncekiSonuclar.TabIndex = 9;
            this.btnOncekiSonuclar.Text = "Önceki Sonuçları Göster";
            this.btnOncekiSonuclar.UseVisualStyleBackColor = true;
            this.btnOncekiSonuclar.Click += new System.EventHandler(this.BtnOncekiSonuclar_Click);
            // 
            // listSonuclar
            // 
            this.listSonuclar.FormattingEnabled = true;
            this.listSonuclar.Location = new System.Drawing.Point(6, 19);
            this.listSonuclar.Name = "listSonuclar";
            this.listSonuclar.Size = new System.Drawing.Size(68, 121);
            this.listSonuclar.TabIndex = 8;
            this.listSonuclar.SelectedIndexChanged += new System.EventHandler(this.ListSonuclar_SelectedIndexChanged);
            // 
            // GrpBoxSonuclar
            // 
            this.GrpBoxSonuclar.Controls.Add(this.listSonuclar);
            this.GrpBoxSonuclar.Location = new System.Drawing.Point(190, 25);
            this.GrpBoxSonuclar.Name = "GrpBoxSonuclar";
            this.GrpBoxSonuclar.Size = new System.Drawing.Size(88, 147);
            this.GrpBoxSonuclar.TabIndex = 10;
            this.GrpBoxSonuclar.TabStop = false;
            this.GrpBoxSonuclar.Text = "Sonuçlar";
            this.GrpBoxSonuclar.Visible = false;
            // 
            // FrmTopla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 210);
            this.Controls.Add(this.GrpBoxSonuclar);
            this.Controls.Add(this.btnOncekiSonuclar);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.BtnTopla);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSonuc);
            this.Controls.Add(this.txtSayi2);
            this.Controls.Add(this.txtSayi1);
            this.Name = "FrmTopla";
            this.Text = "Toplama";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.GrpBoxSonuclar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSayi1;
        private System.Windows.Forms.TextBox txtSayi2;
        private System.Windows.Forms.TextBox txtSonuc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnTopla;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnOncekiSonuclar;
        private System.Windows.Forms.ListBox listSonuclar;
        private System.Windows.Forms.GroupBox GrpBoxSonuclar;
    }
}

