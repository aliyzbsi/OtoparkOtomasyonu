
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdminAnasayfa));
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.ımageList2 = new System.Windows.Forms.ImageList(this.components);
            this.labelbaslik = new System.Windows.Forms.Label();
            this.buttonGirisYAP = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxsifre = new System.Windows.Forms.TextBox();
            this.textBoxtc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ımageList1
            // 
            this.ımageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.ımageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.ImageKey = "previous.png";
            this.button1.ImageList = this.ımageList2;
            this.button1.Location = new System.Drawing.Point(23, 365);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(72, 64);
            this.button1.TabIndex = 60;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // ımageList2
            // 
            this.ımageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList2.ImageStream")));
            this.ımageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList2.Images.SetKeyName(0, "admin.png");
            this.ımageList2.Images.SetKeyName(1, "operator.png");
            this.ımageList2.Images.SetKeyName(2, "previous.png");
            // 
            // labelbaslik
            // 
            this.labelbaslik.AutoSize = true;
            this.labelbaslik.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelbaslik.Font = new System.Drawing.Font("Microsoft YaHei", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelbaslik.Location = new System.Drawing.Point(210, 69);
            this.labelbaslik.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelbaslik.Name = "labelbaslik";
            this.labelbaslik.Size = new System.Drawing.Size(262, 36);
            this.labelbaslik.TabIndex = 59;
            this.labelbaslik.Text = "ADMİN GİRİŞ YAP";
            // 
            // buttonGirisYAP
            // 
            this.buttonGirisYAP.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonGirisYAP.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGirisYAP.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonGirisYAP.Location = new System.Drawing.Point(262, 260);
            this.buttonGirisYAP.Margin = new System.Windows.Forms.Padding(2);
            this.buttonGirisYAP.Name = "buttonGirisYAP";
            this.buttonGirisYAP.Size = new System.Drawing.Size(151, 38);
            this.buttonGirisYAP.TabIndex = 58;
            this.buttonGirisYAP.Text = "GİRİŞ YAP";
            this.buttonGirisYAP.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft New Tai Lue", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(168, 222);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 20);
            this.label6.TabIndex = 57;
            this.label6.Text = "Şifreniz";
            // 
            // textBoxsifre
            // 
            this.textBoxsifre.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxsifre.Location = new System.Drawing.Point(262, 222);
            this.textBoxsifre.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxsifre.MaxLength = 15;
            this.textBoxsifre.Name = "textBoxsifre";
            this.textBoxsifre.PasswordChar = '*';
            this.textBoxsifre.Size = new System.Drawing.Size(151, 20);
            this.textBoxsifre.TabIndex = 56;
            // 
            // textBoxtc
            // 
            this.textBoxtc.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxtc.Location = new System.Drawing.Point(262, 189);
            this.textBoxtc.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxtc.MaxLength = 11;
            this.textBoxtc.Name = "textBoxtc";
            this.textBoxtc.Size = new System.Drawing.Size(151, 20);
            this.textBoxtc.TabIndex = 55;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft New Tai Lue", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(168, 189);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 54;
            this.label1.Text = "TC NO";
            // 
            // FormAdminAnasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(628, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelbaslik);
            this.Controls.Add(this.buttonGirisYAP);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxsifre);
            this.Controls.Add(this.textBoxtc);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "FormAdminAnasayfa";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ImageList ımageList2;
        private System.Windows.Forms.Label labelbaslik;
        private System.Windows.Forms.Button buttonGirisYAP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxsifre;
        private System.Windows.Forms.TextBox textBoxtc;
        private System.Windows.Forms.Label label1;
    }
}

