using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace App.UserControls
{
    public partial class uc_Video : UserControl
    {
        public uc_Video()
        {
            InitializeComponent();
        }
        private string DosyaYolu, DosyaAdi, yoloCommand, GETOUTPUT, SAVEDATA, USEGPU, GETOUTPUT_, SAVEDATA_, USEGPU_;

        private void pnlVideo_MouseEnter(object sender, EventArgs e)
        {
            pnlVideo.BackColor = Color.FromArgb(22, 30, 32);
        }

        private void pnlVideo_MouseLeave(object sender, EventArgs e)
        {
            pnlVideo.BackColor = Color.FromArgb(41, 44, 51);
        }

        private void pnlVideo_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog file = new OpenFileDialog())
            {
                DosyaAdi = ""; DosyaYolu = "";
                file.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                file.Title = "Lütfen video dosyası seçiniz";
                file.Filter = "MP4 Dosyası |*.mp4";
                file.ShowDialog();
                try
                {
                    DosyaYolu = file.FileName;
                    DosyaAdi = file.SafeFileName;
                    if (DosyaAdi == "" || DosyaYolu == "")
                    {
                        MessageBox.Show("Video seçilmedi!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        string exePath = Environment.CurrentDirectory;
                        if (exePath.Contains(@"\bin\Debug"))
                        {
                            exePath = exePath.Remove((exePath.Length - (@"\bin\Debug").Length));
                        }
                        yoloCommand = "cd " + exePath + "\\YOLO&python yolo_video.py --input " + DosyaYolu + " --yolo yolo-coco";
                        GETOUTPUT = " --output outputVideos/" + DosyaAdi + ".avi";
                        USEGPU = " --use-gpu True";
                        SAVEDATA = " --save-data True";
                        GETOUTPUT_ = "Alma"; SAVEDATA_ = "Alma"; USEGPU_ = "CPU (İşlemci)";
                        if (cbOutput.Checked == true)
                        {
                            yoloCommand += GETOUTPUT;
                            GETOUTPUT_ = "Al";
                        }
                        if (rbGPU.Checked == true)
                        {
                            yoloCommand += USEGPU;
                            USEGPU_ = "GPU (CUDA)";
                        }
                        if (cbSave.Checked == true)
                        {
                            yoloCommand += SAVEDATA;
                            SAVEDATA_ = "Al";
                        }
                        DialogResult dialogResult = MessageBox.Show("İşlem Bildirimi\nDosya Adı: " + DosyaAdi + "\nÇalıştırma Türü: " + USEGPU_ + "\nİşlem Çıktısı: " + GETOUTPUT_ + "\nKayıt Alma: " + SAVEDATA_ + "", "Bilgilendirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dialogResult == DialogResult.Yes)
                        {
                            Process.Start("cmd.exe", "/c" + yoloCommand);
                        }
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Kaynak dosyası hatası!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}