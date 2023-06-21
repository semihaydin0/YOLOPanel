namespace App.UserControls
{
    partial class uc_Video
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
            this.gbRun = new System.Windows.Forms.GroupBox();
            this.rbGPU = new System.Windows.Forms.RadioButton();
            this.rbCPU = new System.Windows.Forms.RadioButton();
            this.gbSettings = new System.Windows.Forms.GroupBox();
            this.cbSave = new System.Windows.Forms.CheckBox();
            this.cbOutput = new System.Windows.Forms.CheckBox();
            this.pnlVideo = new System.Windows.Forms.Panel();
            this.lblVideo = new System.Windows.Forms.Label();
            this.pbVideo = new System.Windows.Forms.PictureBox();
            this.gbRun.SuspendLayout();
            this.gbSettings.SuspendLayout();
            this.pnlVideo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbVideo)).BeginInit();
            this.SuspendLayout();
            // 
            // gbRun
            // 
            this.gbRun.Controls.Add(this.rbGPU);
            this.gbRun.Controls.Add(this.rbCPU);
            this.gbRun.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbRun.ForeColor = System.Drawing.Color.White;
            this.gbRun.Location = new System.Drawing.Point(134, 284);
            this.gbRun.Name = "gbRun";
            this.gbRun.Size = new System.Drawing.Size(231, 140);
            this.gbRun.TabIndex = 0;
            this.gbRun.TabStop = false;
            this.gbRun.Text = "Çalıştırma Seçenekleri";
            // 
            // rbGPU
            // 
            this.rbGPU.AutoSize = true;
            this.rbGPU.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbGPU.Location = new System.Drawing.Point(45, 83);
            this.rbGPU.Name = "rbGPU";
            this.rbGPU.Size = new System.Drawing.Size(142, 25);
            this.rbGPU.TabIndex = 1;
            this.rbGPU.Text = "CUDA (GPU)";
            this.rbGPU.UseVisualStyleBackColor = true;
            // 
            // rbCPU
            // 
            this.rbCPU.AutoSize = true;
            this.rbCPU.Checked = true;
            this.rbCPU.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbCPU.Location = new System.Drawing.Point(43, 43);
            this.rbCPU.Name = "rbCPU";
            this.rbCPU.Size = new System.Drawing.Size(145, 25);
            this.rbCPU.TabIndex = 0;
            this.rbCPU.TabStop = true;
            this.rbCPU.Text = "İşlemci (CPU)";
            this.rbCPU.UseVisualStyleBackColor = true;
            // 
            // gbSettings
            // 
            this.gbSettings.Controls.Add(this.cbSave);
            this.gbSettings.Controls.Add(this.cbOutput);
            this.gbSettings.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbSettings.ForeColor = System.Drawing.Color.White;
            this.gbSettings.Location = new System.Drawing.Point(556, 284);
            this.gbSettings.Name = "gbSettings";
            this.gbSettings.Size = new System.Drawing.Size(231, 140);
            this.gbSettings.TabIndex = 1;
            this.gbSettings.TabStop = false;
            this.gbSettings.Text = "Genel Ayarlar";
            // 
            // cbSave
            // 
            this.cbSave.AutoSize = true;
            this.cbSave.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbSave.Location = new System.Drawing.Point(51, 85);
            this.cbSave.Name = "cbSave";
            this.cbSave.Size = new System.Drawing.Size(128, 25);
            this.cbSave.TabIndex = 1;
            this.cbSave.Text = "Kayıt Alma";
            this.cbSave.UseVisualStyleBackColor = true;
            // 
            // cbOutput
            // 
            this.cbOutput.AutoSize = true;
            this.cbOutput.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbOutput.Location = new System.Drawing.Point(51, 45);
            this.cbOutput.Name = "cbOutput";
            this.cbOutput.Size = new System.Drawing.Size(128, 25);
            this.cbOutput.TabIndex = 0;
            this.cbOutput.Text = "İşlem Çıktısı";
            this.cbOutput.UseVisualStyleBackColor = true;
            // 
            // pnlVideo
            // 
            this.pnlVideo.Controls.Add(this.lblVideo);
            this.pnlVideo.Controls.Add(this.pbVideo);
            this.pnlVideo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlVideo.Location = new System.Drawing.Point(347, 135);
            this.pnlVideo.Name = "pnlVideo";
            this.pnlVideo.Size = new System.Drawing.Size(225, 56);
            this.pnlVideo.TabIndex = 2;
            this.pnlVideo.Click += new System.EventHandler(this.pnlVideo_Click);
            this.pnlVideo.MouseEnter += new System.EventHandler(this.pnlVideo_MouseEnter);
            this.pnlVideo.MouseLeave += new System.EventHandler(this.pnlVideo_MouseLeave);
            // 
            // lblVideo
            // 
            this.lblVideo.AutoSize = true;
            this.lblVideo.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblVideo.ForeColor = System.Drawing.Color.White;
            this.lblVideo.Location = new System.Drawing.Point(59, 10);
            this.lblVideo.Name = "lblVideo";
            this.lblVideo.Size = new System.Drawing.Size(156, 34);
            this.lblVideo.TabIndex = 1;
            this.lblVideo.Text = "Video Seç";
            this.lblVideo.Click += new System.EventHandler(this.pnlVideo_Click);
            this.lblVideo.MouseEnter += new System.EventHandler(this.pnlVideo_MouseEnter);
            // 
            // pbVideo
            // 
            this.pbVideo.Image = global::App.Properties.Resources.video_camera;
            this.pbVideo.Location = new System.Drawing.Point(13, 7);
            this.pbVideo.Name = "pbVideo";
            this.pbVideo.Size = new System.Drawing.Size(42, 41);
            this.pbVideo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbVideo.TabIndex = 0;
            this.pbVideo.TabStop = false;
            this.pbVideo.Click += new System.EventHandler(this.pnlVideo_Click);
            this.pbVideo.MouseEnter += new System.EventHandler(this.pnlVideo_MouseEnter);
            // 
            // uc_Video
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.Controls.Add(this.pnlVideo);
            this.Controls.Add(this.gbSettings);
            this.Controls.Add(this.gbRun);
            this.Name = "uc_Video";
            this.Size = new System.Drawing.Size(920, 555);
            this.gbRun.ResumeLayout(false);
            this.gbRun.PerformLayout();
            this.gbSettings.ResumeLayout(false);
            this.gbSettings.PerformLayout();
            this.pnlVideo.ResumeLayout(false);
            this.pnlVideo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbVideo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbRun;
        private System.Windows.Forms.GroupBox gbSettings;
        private System.Windows.Forms.Panel pnlVideo;
        private System.Windows.Forms.PictureBox pbVideo;
        private System.Windows.Forms.Label lblVideo;
        private System.Windows.Forms.RadioButton rbGPU;
        private System.Windows.Forms.RadioButton rbCPU;
        private System.Windows.Forms.CheckBox cbSave;
        private System.Windows.Forms.CheckBox cbOutput;
    }
}
