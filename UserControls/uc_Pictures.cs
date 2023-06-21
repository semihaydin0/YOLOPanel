using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace App.UserControls
{
    public partial class uc_Pictures : UserControl
    {
        public uc_Pictures()
        {
            InitializeComponent();
        }
        private string DosyaYolu, DosyaAdi, yoloCommand;
        private void pnlPictures_MouseEnter(object sender, System.EventArgs e)
        {
            pnlPictures.BackColor = Color.FromArgb(22, 30, 32);
        }

        private void pnlPictures_MouseLeave(object sender, System.EventArgs e)
        {
            pnlPictures.BackColor = Color.FromArgb(41, 44, 51);
        }

        private void pnlPictures_Click(object sender, System.EventArgs e)
        {
            using (OpenFileDialog file = new OpenFileDialog())
            {
                DosyaAdi = ""; DosyaYolu = "";
                file.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                file.Title = "Lütfen görüntü dosyası seçiniz";
                file.Filter = "Görüntü Dosyası|*.jpg;*.jpeg;*.png;*.gif;*.tif;...";
                file.ShowDialog();
                try
                {
                    DosyaYolu = file.FileName;
                    DosyaAdi = file.SafeFileName;
                    if (DosyaAdi == "" || DosyaYolu == "")
                    {
                        MessageBox.Show("Görüntü seçilmedi!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        string exePath = Environment.CurrentDirectory;
                        if (exePath.Contains(@"\bin\Debug"))
                        {
                            exePath = exePath.Remove((exePath.Length - (@"\bin\Debug").Length));
                        }
                        yoloCommand = "cd " + exePath + "\\YOLO&python yolo_image.py --image " + DosyaYolu + " --config yolo-coco\\yolov3.cfg --weights yolo-coco\\yolov3.weights --classes yolo-coco\\yolov3.txt";
                        Process.Start("cmd.exe", "/c" + yoloCommand);
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
