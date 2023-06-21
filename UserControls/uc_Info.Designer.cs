namespace App.UserControls
{
    partial class uc_Info
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

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblInfo1 = new System.Windows.Forms.Label();
            this.lblInfo2 = new System.Windows.Forms.Label();
            this.lblInfo3 = new System.Windows.Forms.Label();
            this.lblInfo4 = new System.Windows.Forms.Label();
            this.lblYolo = new System.Windows.Forms.Label();
            this.lblInfo5 = new System.Windows.Forms.Label();
            this.lblInfo6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblInfo1
            // 
            this.lblInfo1.AutoSize = true;
            this.lblInfo1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblInfo1.ForeColor = System.Drawing.Color.White;
            this.lblInfo1.Location = new System.Drawing.Point(139, 228);
            this.lblInfo1.Name = "lblInfo1";
            this.lblInfo1.Size = new System.Drawing.Size(642, 20);
            this.lblInfo1.TabIndex = 0;
            this.lblInfo1.Text = "YOLO, konvolüsyonel sinir ağlarını (CNN) kullanarak nesne tespiti yapan bir algor" +
    "itmadır. ";
            // 
            // lblInfo2
            // 
            this.lblInfo2.AutoSize = true;
            this.lblInfo2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblInfo2.ForeColor = System.Drawing.Color.White;
            this.lblInfo2.Location = new System.Drawing.Point(190, 268);
            this.lblInfo2.Name = "lblInfo2";
            this.lblInfo2.Size = new System.Drawing.Size(541, 20);
            this.lblInfo2.TabIndex = 1;
            this.lblInfo2.Text = "Açılımı ise şu şekildedir “You Only Look Once“, yani “Sadece Bir Kez Bak“. ";
            // 
            // lblInfo3
            // 
            this.lblInfo3.AutoSize = true;
            this.lblInfo3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblInfo3.ForeColor = System.Drawing.Color.White;
            this.lblInfo3.Location = new System.Drawing.Point(92, 308);
            this.lblInfo3.Name = "lblInfo3";
            this.lblInfo3.Size = new System.Drawing.Size(736, 20);
            this.lblInfo3.TabIndex = 2;
            this.lblInfo3.Text = "Bu adın seçilmesinin nedeni algoritmanın nesne tespitini tek seferde yapabilecek " +
    "kadar hızlı olmasıdır.";
            // 
            // lblInfo4
            // 
            this.lblInfo4.AutoSize = true;
            this.lblInfo4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblInfo4.ForeColor = System.Drawing.Color.White;
            this.lblInfo4.Location = new System.Drawing.Point(9, 348);
            this.lblInfo4.Name = "lblInfo4";
            this.lblInfo4.Size = new System.Drawing.Size(902, 20);
            this.lblInfo4.TabIndex = 3;
            this.lblInfo4.Text = "YOLO algoritması çalışmaya başladığında görüntülerdeki veya videolardaki nesneler" +
    "in koordinatlarını aynı anda tespit eder.";
            // 
            // lblYolo
            // 
            this.lblYolo.AutoSize = true;
            this.lblYolo.Font = new System.Drawing.Font("! PEPSI !", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYolo.ForeColor = System.Drawing.Color.White;
            this.lblYolo.Location = new System.Drawing.Point(334, 90);
            this.lblYolo.Name = "lblYolo";
            this.lblYolo.Size = new System.Drawing.Size(269, 89);
            this.lblYolo.TabIndex = 4;
            this.lblYolo.Text = "Yolo";
            // 
            // lblInfo5
            // 
            this.lblInfo5.AutoSize = true;
            this.lblInfo5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblInfo5.ForeColor = System.Drawing.Color.White;
            this.lblInfo5.Location = new System.Drawing.Point(28, 388);
            this.lblInfo5.Name = "lblInfo5";
            this.lblInfo5.Size = new System.Drawing.Size(850, 20);
            this.lblInfo5.TabIndex = 5;
            this.lblInfo5.Text = "  Video ve resim işleme arasında tek fark resimlerin tek bir kareden (frame), vid" +
    "eoların ise birçok kareden oluşmasıdır.";
            // 
            // lblInfo6
            // 
            this.lblInfo6.AutoSize = true;
            this.lblInfo6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblInfo6.ForeColor = System.Drawing.Color.White;
            this.lblInfo6.Location = new System.Drawing.Point(113, 428);
            this.lblInfo6.Name = "lblInfo6";
            this.lblInfo6.Size = new System.Drawing.Size(693, 20);
            this.lblInfo6.TabIndex = 6;
            this.lblInfo6.Text = "Resimlerde algoritma tek bir kare için çalışırken, videolarda tüm kareler için te" +
    "krar tekrar çalışır.";
            // 
            // uc_Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.Controls.Add(this.lblInfo6);
            this.Controls.Add(this.lblInfo5);
            this.Controls.Add(this.lblYolo);
            this.Controls.Add(this.lblInfo4);
            this.Controls.Add(this.lblInfo3);
            this.Controls.Add(this.lblInfo2);
            this.Controls.Add(this.lblInfo1);
            this.Name = "uc_Info";
            this.Size = new System.Drawing.Size(920, 555);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInfo1;
        private System.Windows.Forms.Label lblInfo2;
        private System.Windows.Forms.Label lblInfo3;
        private System.Windows.Forms.Label lblInfo4;
        private System.Windows.Forms.Label lblYolo;
        private System.Windows.Forms.Label lblInfo5;
        private System.Windows.Forms.Label lblInfo6;
    }
}
