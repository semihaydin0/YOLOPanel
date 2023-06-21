namespace App
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.pnlMenu6 = new System.Windows.Forms.Panel();
            this.lblYolo = new System.Windows.Forms.Label();
            this.lblDisc = new System.Windows.Forms.Label();
            this.pnlMenu1 = new System.Windows.Forms.Panel();
            this.lblMenu1 = new System.Windows.Forms.Label();
            this.pbMenu1 = new System.Windows.Forms.PictureBox();
            this.pnlMenu2 = new System.Windows.Forms.Panel();
            this.lblMenu2 = new System.Windows.Forms.Label();
            this.pbMenu2 = new System.Windows.Forms.PictureBox();
            this.pnlMenu3 = new System.Windows.Forms.Panel();
            this.lblMenu3 = new System.Windows.Forms.Label();
            this.pbMenu3 = new System.Windows.Forms.PictureBox();
            this.pnlMenu4 = new System.Windows.Forms.Panel();
            this.lblMenu4 = new System.Windows.Forms.Label();
            this.pbMenu4 = new System.Windows.Forms.PictureBox();
            this.pnlMenu5 = new System.Windows.Forms.Panel();
            this.lblMenu5 = new System.Windows.Forms.Label();
            this.pbMenu5 = new System.Windows.Forms.PictureBox();
            this.lblMenu6 = new System.Windows.Forms.Label();
            this.lblMenu7 = new System.Windows.Forms.Label();
            this.pbExit = new System.Windows.Forms.PictureBox();
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.pnlMenu1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMenu1)).BeginInit();
            this.pnlMenu2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMenu2)).BeginInit();
            this.pnlMenu3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMenu3)).BeginInit();
            this.pnlMenu4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMenu4)).BeginInit();
            this.pnlMenu5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMenu5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMenu6
            // 
            this.pnlMenu6.BackColor = System.Drawing.Color.White;
            this.pnlMenu6.Location = new System.Drawing.Point(275, 0);
            this.pnlMenu6.Name = "pnlMenu6";
            this.pnlMenu6.Size = new System.Drawing.Size(5, 585);
            this.pnlMenu6.TabIndex = 0;
            // 
            // lblYolo
            // 
            this.lblYolo.AutoSize = true;
            this.lblYolo.Font = new System.Drawing.Font("! PEPSI !", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYolo.ForeColor = System.Drawing.Color.White;
            this.lblYolo.Location = new System.Drawing.Point(37, 34);
            this.lblYolo.Name = "lblYolo";
            this.lblYolo.Size = new System.Drawing.Size(202, 67);
            this.lblYolo.TabIndex = 2;
            this.lblYolo.Text = "Yolo";
            // 
            // lblDisc
            // 
            this.lblDisc.AutoSize = true;
            this.lblDisc.Font = new System.Drawing.Font("! PEPSI !", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDisc.ForeColor = System.Drawing.Color.White;
            this.lblDisc.Location = new System.Drawing.Point(18, 115);
            this.lblDisc.Name = "lblDisc";
            this.lblDisc.Size = new System.Drawing.Size(229, 14);
            this.lblDisc.TabIndex = 3;
            this.lblDisc.Text = "Gercek Zamanli Nesne Algilama";
            // 
            // pnlMenu1
            // 
            this.pnlMenu1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.pnlMenu1.Controls.Add(this.lblMenu1);
            this.pnlMenu1.Controls.Add(this.pbMenu1);
            this.pnlMenu1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnlMenu1.Location = new System.Drawing.Point(0, 184);
            this.pnlMenu1.Name = "pnlMenu1";
            this.pnlMenu1.Size = new System.Drawing.Size(275, 56);
            this.pnlMenu1.TabIndex = 4;
            this.pnlMenu1.Click += new System.EventHandler(this.pnlMenu1_Click);
            this.pnlMenu1.MouseEnter += new System.EventHandler(this.pnlMenu1_MouseEnter);
            this.pnlMenu1.MouseLeave += new System.EventHandler(this.pnlMenu1_MouseLeave);
            // 
            // lblMenu1
            // 
            this.lblMenu1.AutoSize = true;
            this.lblMenu1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMenu1.ForeColor = System.Drawing.Color.White;
            this.lblMenu1.Location = new System.Drawing.Point(50, 15);
            this.lblMenu1.Name = "lblMenu1";
            this.lblMenu1.Size = new System.Drawing.Size(158, 27);
            this.lblMenu1.TabIndex = 1;
            this.lblMenu1.Text = "Video Tespiti";
            this.lblMenu1.Click += new System.EventHandler(this.pnlMenu1_Click);
            this.lblMenu1.MouseEnter += new System.EventHandler(this.pnlMenu1_MouseEnter);
            // 
            // pbMenu1
            // 
            this.pbMenu1.Image = global::App.Properties.Resources.video_camera;
            this.pbMenu1.Location = new System.Drawing.Point(15, 15);
            this.pbMenu1.Name = "pbMenu1";
            this.pbMenu1.Size = new System.Drawing.Size(27, 27);
            this.pbMenu1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMenu1.TabIndex = 0;
            this.pbMenu1.TabStop = false;
            this.pbMenu1.Click += new System.EventHandler(this.pnlMenu1_Click);
            this.pbMenu1.MouseEnter += new System.EventHandler(this.pnlMenu1_MouseEnter);
            // 
            // pnlMenu2
            // 
            this.pnlMenu2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.pnlMenu2.Controls.Add(this.lblMenu2);
            this.pnlMenu2.Controls.Add(this.pbMenu2);
            this.pnlMenu2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnlMenu2.Location = new System.Drawing.Point(0, 240);
            this.pnlMenu2.Name = "pnlMenu2";
            this.pnlMenu2.Size = new System.Drawing.Size(275, 56);
            this.pnlMenu2.TabIndex = 5;
            this.pnlMenu2.Click += new System.EventHandler(this.pnlMenu2_Click);
            this.pnlMenu2.MouseEnter += new System.EventHandler(this.pnlMenu2_MouseEnter);
            this.pnlMenu2.MouseLeave += new System.EventHandler(this.pnlMenu2_MouseLeave);
            // 
            // lblMenu2
            // 
            this.lblMenu2.AutoSize = true;
            this.lblMenu2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMenu2.ForeColor = System.Drawing.Color.White;
            this.lblMenu2.Location = new System.Drawing.Point(50, 15);
            this.lblMenu2.Name = "lblMenu2";
            this.lblMenu2.Size = new System.Drawing.Size(181, 27);
            this.lblMenu2.TabIndex = 1;
            this.lblMenu2.Text = "Görüntü Tespiti";
            this.lblMenu2.Click += new System.EventHandler(this.pnlMenu2_Click);
            this.lblMenu2.MouseEnter += new System.EventHandler(this.pnlMenu2_MouseEnter);
            // 
            // pbMenu2
            // 
            this.pbMenu2.Image = global::App.Properties.Resources.gallery;
            this.pbMenu2.Location = new System.Drawing.Point(15, 15);
            this.pbMenu2.Name = "pbMenu2";
            this.pbMenu2.Size = new System.Drawing.Size(27, 27);
            this.pbMenu2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMenu2.TabIndex = 0;
            this.pbMenu2.TabStop = false;
            this.pbMenu2.Click += new System.EventHandler(this.pnlMenu2_Click);
            this.pbMenu2.MouseEnter += new System.EventHandler(this.pnlMenu2_MouseEnter);
            // 
            // pnlMenu3
            // 
            this.pnlMenu3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.pnlMenu3.Controls.Add(this.lblMenu3);
            this.pnlMenu3.Controls.Add(this.pbMenu3);
            this.pnlMenu3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnlMenu3.Location = new System.Drawing.Point(0, 296);
            this.pnlMenu3.Name = "pnlMenu3";
            this.pnlMenu3.Size = new System.Drawing.Size(275, 56);
            this.pnlMenu3.TabIndex = 6;
            this.pnlMenu3.Click += new System.EventHandler(this.pnlMenu3_Click);
            this.pnlMenu3.MouseEnter += new System.EventHandler(this.pnlMenu3_MouseEnter);
            this.pnlMenu3.MouseLeave += new System.EventHandler(this.pnlMenu3_MouseLeave);
            // 
            // lblMenu3
            // 
            this.lblMenu3.AutoSize = true;
            this.lblMenu3.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMenu3.ForeColor = System.Drawing.Color.White;
            this.lblMenu3.Location = new System.Drawing.Point(50, 15);
            this.lblMenu3.Name = "lblMenu3";
            this.lblMenu3.Size = new System.Drawing.Size(98, 27);
            this.lblMenu3.TabIndex = 1;
            this.lblMenu3.Text = "Kayıtlar";
            this.lblMenu3.Click += new System.EventHandler(this.pnlMenu3_Click);
            this.lblMenu3.MouseEnter += new System.EventHandler(this.pnlMenu3_MouseEnter);
            // 
            // pbMenu3
            // 
            this.pbMenu3.Image = global::App.Properties.Resources.save;
            this.pbMenu3.Location = new System.Drawing.Point(15, 15);
            this.pbMenu3.Name = "pbMenu3";
            this.pbMenu3.Size = new System.Drawing.Size(27, 27);
            this.pbMenu3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMenu3.TabIndex = 0;
            this.pbMenu3.TabStop = false;
            this.pbMenu3.Click += new System.EventHandler(this.pnlMenu3_Click);
            this.pbMenu3.MouseEnter += new System.EventHandler(this.pnlMenu3_MouseEnter);
            // 
            // pnlMenu4
            // 
            this.pnlMenu4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.pnlMenu4.Controls.Add(this.lblMenu4);
            this.pnlMenu4.Controls.Add(this.pbMenu4);
            this.pnlMenu4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnlMenu4.Location = new System.Drawing.Point(0, 353);
            this.pnlMenu4.Name = "pnlMenu4";
            this.pnlMenu4.Size = new System.Drawing.Size(275, 56);
            this.pnlMenu4.TabIndex = 7;
            this.pnlMenu4.Click += new System.EventHandler(this.pnlMenu4_Click);
            this.pnlMenu4.MouseEnter += new System.EventHandler(this.pnlMenu4_MouseEnter);
            this.pnlMenu4.MouseLeave += new System.EventHandler(this.pnlMenu4_MouseLeave);
            // 
            // lblMenu4
            // 
            this.lblMenu4.AutoSize = true;
            this.lblMenu4.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMenu4.ForeColor = System.Drawing.Color.White;
            this.lblMenu4.Location = new System.Drawing.Point(50, 15);
            this.lblMenu4.Name = "lblMenu4";
            this.lblMenu4.Size = new System.Drawing.Size(143, 27);
            this.lblMenu4.TabIndex = 1;
            this.lblMenu4.Text = "Yolo Nedir?";
            this.lblMenu4.Click += new System.EventHandler(this.pnlMenu4_Click);
            this.lblMenu4.MouseEnter += new System.EventHandler(this.pnlMenu4_MouseEnter);
            // 
            // pbMenu4
            // 
            this.pbMenu4.Image = global::App.Properties.Resources.question_mark;
            this.pbMenu4.Location = new System.Drawing.Point(15, 15);
            this.pbMenu4.Name = "pbMenu4";
            this.pbMenu4.Size = new System.Drawing.Size(27, 27);
            this.pbMenu4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMenu4.TabIndex = 0;
            this.pbMenu4.TabStop = false;
            this.pbMenu4.Click += new System.EventHandler(this.pnlMenu4_Click);
            this.pbMenu4.MouseEnter += new System.EventHandler(this.pnlMenu4_MouseEnter);
            // 
            // pnlMenu5
            // 
            this.pnlMenu5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.pnlMenu5.Controls.Add(this.lblMenu5);
            this.pnlMenu5.Controls.Add(this.pbMenu5);
            this.pnlMenu5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnlMenu5.Location = new System.Drawing.Point(0, 410);
            this.pnlMenu5.Name = "pnlMenu5";
            this.pnlMenu5.Size = new System.Drawing.Size(275, 56);
            this.pnlMenu5.TabIndex = 8;
            this.pnlMenu5.Click += new System.EventHandler(this.pnlMenu5_Click);
            this.pnlMenu5.MouseEnter += new System.EventHandler(this.pnlMenu5_MouseEnter);
            this.pnlMenu5.MouseLeave += new System.EventHandler(this.pnlMenu5_MouseLeave);
            // 
            // lblMenu5
            // 
            this.lblMenu5.AutoSize = true;
            this.lblMenu5.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMenu5.ForeColor = System.Drawing.Color.White;
            this.lblMenu5.Location = new System.Drawing.Point(50, 15);
            this.lblMenu5.Name = "lblMenu5";
            this.lblMenu5.Size = new System.Drawing.Size(120, 27);
            this.lblMenu5.TabIndex = 1;
            this.lblMenu5.Text = "Hakkında";
            this.lblMenu5.Click += new System.EventHandler(this.pnlMenu5_Click);
            this.lblMenu5.MouseEnter += new System.EventHandler(this.pnlMenu5_MouseEnter);
            // 
            // pbMenu5
            // 
            this.pbMenu5.Image = global::App.Properties.Resources.info;
            this.pbMenu5.Location = new System.Drawing.Point(15, 15);
            this.pbMenu5.Name = "pbMenu5";
            this.pbMenu5.Size = new System.Drawing.Size(27, 27);
            this.pbMenu5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMenu5.TabIndex = 0;
            this.pbMenu5.TabStop = false;
            this.pbMenu5.Click += new System.EventHandler(this.pnlMenu5_Click);
            this.pbMenu5.MouseEnter += new System.EventHandler(this.pnlMenu5_MouseEnter);
            // 
            // lblMenu6
            // 
            this.lblMenu6.AutoSize = true;
            this.lblMenu6.Font = new System.Drawing.Font("! PEPSI !", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMenu6.ForeColor = System.Drawing.Color.White;
            this.lblMenu6.Location = new System.Drawing.Point(107, 535);
            this.lblMenu6.Name = "lblMenu6";
            this.lblMenu6.Size = new System.Drawing.Size(61, 20);
            this.lblMenu6.TabIndex = 9;
            this.lblMenu6.Text = "Yolo";
            // 
            // lblMenu7
            // 
            this.lblMenu7.AutoSize = true;
            this.lblMenu7.Font = new System.Drawing.Font("! PEPSI !", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMenu7.ForeColor = System.Drawing.Color.White;
            this.lblMenu7.Location = new System.Drawing.Point(119, 555);
            this.lblMenu7.Name = "lblMenu7";
            this.lblMenu7.Size = new System.Drawing.Size(37, 20);
            this.lblMenu7.TabIndex = 10;
            this.lblMenu7.Text = "v3";
            // 
            // pbExit
            // 
            this.pbExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbExit.Image = global::App.Properties.Resources.exit;
            this.pbExit.Location = new System.Drawing.Point(1173, 12);
            this.pbExit.Name = "pbExit";
            this.pbExit.Size = new System.Drawing.Size(15, 15);
            this.pbExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbExit.TabIndex = 1;
            this.pbExit.TabStop = false;
            this.pbExit.Click += new System.EventHandler(this.pbExit_Click);
            // 
            // pnlContainer
            // 
            this.pnlContainer.Location = new System.Drawing.Point(280, 30);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(920, 555);
            this.pnlContainer.TabIndex = 11;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1200, 585);
            this.Controls.Add(this.pnlContainer);
            this.Controls.Add(this.lblMenu7);
            this.Controls.Add(this.lblMenu6);
            this.Controls.Add(this.pnlMenu5);
            this.Controls.Add(this.pnlMenu4);
            this.Controls.Add(this.pnlMenu3);
            this.Controls.Add(this.pnlMenu2);
            this.Controls.Add(this.pnlMenu1);
            this.Controls.Add(this.lblDisc);
            this.Controls.Add(this.lblYolo);
            this.Controls.Add(this.pbExit);
            this.Controls.Add(this.pnlMenu6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "YOLO Gerçek Zamanlı Nesne Algılamaa";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmMain_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmMain_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frmMain_MouseUp);
            this.pnlMenu1.ResumeLayout(false);
            this.pnlMenu1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMenu1)).EndInit();
            this.pnlMenu2.ResumeLayout(false);
            this.pnlMenu2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMenu2)).EndInit();
            this.pnlMenu3.ResumeLayout(false);
            this.pnlMenu3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMenu3)).EndInit();
            this.pnlMenu4.ResumeLayout(false);
            this.pnlMenu4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMenu4)).EndInit();
            this.pnlMenu5.ResumeLayout(false);
            this.pnlMenu5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMenu5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu6;
        private System.Windows.Forms.PictureBox pbExit;
        private System.Windows.Forms.Label lblYolo;
        private System.Windows.Forms.Label lblDisc;
        private System.Windows.Forms.Panel pnlMenu1;
        private System.Windows.Forms.PictureBox pbMenu1;
        private System.Windows.Forms.Label lblMenu1;
        private System.Windows.Forms.Panel pnlMenu2;
        private System.Windows.Forms.Label lblMenu2;
        private System.Windows.Forms.PictureBox pbMenu2;
        private System.Windows.Forms.Panel pnlMenu3;
        private System.Windows.Forms.Label lblMenu3;
        private System.Windows.Forms.PictureBox pbMenu3;
        private System.Windows.Forms.Panel pnlMenu4;
        private System.Windows.Forms.Label lblMenu4;
        private System.Windows.Forms.PictureBox pbMenu4;
        private System.Windows.Forms.Panel pnlMenu5;
        private System.Windows.Forms.Label lblMenu5;
        private System.Windows.Forms.PictureBox pbMenu5;
        private System.Windows.Forms.Label lblMenu6;
        private System.Windows.Forms.Label lblMenu7;
        private System.Windows.Forms.Panel pnlContainer;
    }
}

