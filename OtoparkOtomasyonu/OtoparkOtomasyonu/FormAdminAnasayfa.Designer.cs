
namespace OtoparkOtomasyonu
{
    partial class FormAdminAnasayfa
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
            this.components = new System.ComponentModel.Container();
            this.buttonGirisYAP = new System.Windows.Forms.Button();
            this.labelbaslik = new System.Windows.Forms.Label();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // buttonGirisYAP
            // 
            this.buttonGirisYAP.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonGirisYAP.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonGirisYAP.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonGirisYAP.Location = new System.Drawing.Point(282, 295);
            this.buttonGirisYAP.Name = "buttonGirisYAP";
            this.buttonGirisYAP.Size = new System.Drawing.Size(166, 58);
            this.buttonGirisYAP.TabIndex = 0;
            this.buttonGirisYAP.Text = "GİRİŞ YAP";
            this.buttonGirisYAP.UseVisualStyleBackColor = false;
            this.buttonGirisYAP.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelbaslik
            // 
            this.labelbaslik.AutoSize = true;
            this.labelbaslik.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelbaslik.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelbaslik.Location = new System.Drawing.Point(247, 40);
            this.labelbaslik.Name = "labelbaslik";
            this.labelbaslik.Size = new System.Drawing.Size(262, 36);
            this.labelbaslik.TabIndex = 1;
            this.labelbaslik.Text = "ADMİN GİRİŞ YAP";
            // 
            // ımageList1
            // 
            this.ımageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.ımageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // FormAdminAnasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelbaslik);
            this.Controls.Add(this.buttonGirisYAP);
            this.Name = "FormAdminAnasayfa";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonGirisYAP;
        private System.Windows.Forms.Label labelbaslik;
        private System.Windows.Forms.ImageList ımageList1;
    }
}

