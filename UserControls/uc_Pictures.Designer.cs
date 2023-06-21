namespace App.UserControls
{
    partial class uc_Pictures
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
            this.pnlPictures = new System.Windows.Forms.Panel();
            this.lblPictures = new System.Windows.Forms.Label();
            this.pbPictures = new System.Windows.Forms.PictureBox();
            this.gbSettings = new System.Windows.Forms.GroupBox();
            this.cbSave = new System.Windows.Forms.CheckBox();
            this.cbOutput = new System.Windows.Forms.CheckBox();
            this.gbRun = new System.Windows.Forms.GroupBox();
            this.rbGPU = new System.Windows.Forms.RadioButton();
            this.rbCPU = new System.Windows.Forms.RadioButton();
            this.pnlPictures.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPictures)).BeginInit();
            this.gbSettings.SuspendLayout();
            this.gbRun.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlPictures
            // 
            this.pnlPictures.Controls.Add(this.lblPictures);
            this.pnlPictures.Controls.Add(this.pbPictures);
            this.pnlPictures.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlPictures.Location = new System.Drawing.Point(335, 135);
            this.pnlPictures.Name = "pnlPictures";
            this.pnlPictures.Size = new System.Drawing.Size(250, 56);
            this.pnlPictures.TabIndex = 3;
            this.pnlPictures.Click += new System.EventHandler(this.pnlPictures_Click);
            this.pnlPictures.MouseEnter += new System.EventHandler(this.pnlPictures_MouseEnter);
            this.pnlPictures.MouseLeave += new System.EventHandler(this.pnlPictures_MouseLeave);
            // 
            // lblPictures
            // 
            this.lblPictures.AutoSize = true;
            this.lblPictures.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPictures.ForeColor = System.Drawing.Color.White;
            this.lblPictures.Location = new System.Drawing.Point(59, 10);
            this.lblPictures.Name = "lblPictures";
            this.lblPictures.Size = new System.Drawing.Size(184, 34);
            this.lblPictures.TabIndex = 1;
            this.lblPictures.Text = "Görüntü Seç";
            this.lblPictures.Click += new System.EventHandler(this.pnlPictures_Click);
            this.lblPictures.MouseEnter += new System.EventHandler(this.pnlPictures_MouseEnter);
            // 
            // pbPictures
            // 
            this.pbPictures.Image = global::App.Properties.Resources.gallery;
            this.pbPictures.Location = new System.Drawing.Point(12, 9);
            this.pbPictures.Name = "pbPictures";
            this.pbPictures.Size = new System.Drawing.Size(42, 41);
            this.pbPictures.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPictures.TabIndex = 0;
            this.pbPictures.TabStop = false;
            this.pbPictures.Click += new System.EventHandler(this.pnlPictures_Click);
            this.pbPictures.MouseEnter += new System.EventHandler(this.pnlPictures_MouseEnter);
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
            this.gbSettings.TabIndex = 5;
            this.gbSettings.TabStop = false;
            this.gbSettings.Text = "Genel Ayarlar";
            // 
            // cbSave
            // 
            this.cbSave.AutoSize = true;
            this.cbSave.Enabled = false;
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
            this.cbOutput.Checked = true;
            this.cbOutput.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbOutput.Enabled = false;
            this.cbOutput.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbOutput.Location = new System.Drawing.Point(51, 45);
            this.cbOutput.Name = "cbOutput";
            this.cbOutput.Size = new System.Drawing.Size(128, 25);
            this.cbOutput.TabIndex = 0;
            this.cbOutput.Text = "İşlem Çıktısı";
            this.cbOutput.UseVisualStyleBackColor = true;
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
            this.gbRun.TabIndex = 4;
            this.gbRun.TabStop = false;
            this.gbRun.Text = "Çalıştırma Seçenekleri";
            // 
            // rbGPU
            // 
            this.rbGPU.AutoSize = true;
            this.rbGPU.Enabled = false;
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
            this.rbCPU.Enabled = false;
            this.rbCPU.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbCPU.Location = new System.Drawing.Point(43, 43);
            this.rbCPU.Name = "rbCPU";
            this.rbCPU.Size = new System.Drawing.Size(145, 25);
            this.rbCPU.TabIndex = 0;
            this.rbCPU.TabStop = true;
            this.rbCPU.Text = "İşlemci (CPU)";
            this.rbCPU.UseVisualStyleBackColor = true;
            // 
            // uc_Pictures
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.Controls.Add(this.gbSettings);
            this.Controls.Add(this.gbRun);
            this.Controls.Add(this.pnlPictures);
            this.Name = "uc_Pictures";
            this.Size = new System.Drawing.Size(920, 555);
            this.pnlPictures.ResumeLayout(false);
            this.pnlPictures.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPictures)).EndInit();
            this.gbSettings.ResumeLayout(false);
            this.gbSettings.PerformLayout();
            this.gbRun.ResumeLayout(false);
            this.gbRun.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlPictures;
        private System.Windows.Forms.Label lblPictures;
        private System.Windows.Forms.PictureBox pbPictures;
        private System.Windows.Forms.GroupBox gbSettings;
        private System.Windows.Forms.CheckBox cbSave;
        private System.Windows.Forms.CheckBox cbOutput;
        private System.Windows.Forms.GroupBox gbRun;
        private System.Windows.Forms.RadioButton rbGPU;
        private System.Windows.Forms.RadioButton rbCPU;
    }
}
