using System;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace App
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        public static string Query;
        public static string exePath;
        public static UserControls.uc_Video vid;
        public static UserControls.uc_Pictures pic;
        public static UserControls.uc_Saves sav;
        public static UserControls.uc_About abo;
        public static UserControls.uc_Info inf;
        public void ChangeControl(UserControl uc)
        {
            pnlContainer.Controls.Clear();
            pnlContainer.Controls.Add(uc);
        }
        private void IsDatabaseAvailable()
        {
            exePath = Environment.CurrentDirectory;
            if (exePath.Contains(@"\bin\Debug"))
            {
                exePath = exePath.Remove((exePath.Length - (@"\bin\Debug").Length));
            }
            try
            {
                if (!File.Exists(exePath + "\\YOLO\\Data.db"))
                {
                    SQLiteConnection.CreateFile(exePath + "\\YOLO\\Data.db");
                    using (SQLiteConnection con = new SQLiteConnection("Data Source=" + exePath + "\\YOLO\\Data.db;Version=3;"))
                    {
                        Query = @"CREATE TABLE Data(
                               ID INTEGER PRIMARY KEY AUTOINCREMENT,
                               DATE TEXT,
                               VEHICLES TEXT,
                               PEOPLE TEXT
                            )";
                        using (SQLiteCommand cmd = new SQLiteCommand(Query, con))
                        {
                            con.Open();
                            cmd.ExecuteNonQuery();
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Veritabanı oluşturma esnasında bir hata meydana geldi.\nGörüntü tespit kayıtları tutulmayacak.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            vid = new UserControls.uc_Video();
            pic = new UserControls.uc_Pictures();
            sav = new UserControls.uc_Saves();
            abo = new UserControls.uc_About();
            inf = new UserControls.uc_Info();
            pnlContainer.Controls.Add(vid);
            IsDatabaseAvailable();
        }

        private void pbExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pnlMenu1_MouseEnter(object sender, EventArgs e)
        {
            pnlMenu1.BackColor = Color.FromArgb(22, 30, 32);
        }

        private void pnlMenu1_MouseLeave(object sender, EventArgs e)
        {
            pnlMenu1.BackColor = Color.FromArgb(41, 44, 51);
        }

        private void pnlMenu2_MouseEnter(object sender, EventArgs e)
        {
            pnlMenu2.BackColor = Color.FromArgb(22, 30, 32);
        }

        private void pnlMenu2_MouseLeave(object sender, EventArgs e)
        {
            pnlMenu2.BackColor = Color.FromArgb(41, 44, 51);
        }

        private void pnlMenu3_MouseEnter(object sender, EventArgs e)
        {
            pnlMenu3.BackColor = Color.FromArgb(22, 30, 32);
        }

        private void pnlMenu3_MouseLeave(object sender, EventArgs e)
        {
            pnlMenu3.BackColor = Color.FromArgb(41, 44, 51);
        }

        private void pnlMenu4_MouseEnter(object sender, EventArgs e)
        {
            pnlMenu4.BackColor = Color.FromArgb(22, 30, 32);
        }

        private void pnlMenu4_MouseLeave(object sender, EventArgs e)
        {
            pnlMenu4.BackColor = Color.FromArgb(41, 44, 51);
        }

        private void pnlMenu5_MouseEnter(object sender, EventArgs e)
        {
            pnlMenu5.BackColor = Color.FromArgb(22, 30, 32);
        }

        private void pnlMenu5_MouseLeave(object sender, EventArgs e)
        {
            pnlMenu5.BackColor = Color.FromArgb(41, 44, 51);
        }

        private void frmMain_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void frmMain_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }
        private void frmMain_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
        private void pnlMenu1_Click(object sender, EventArgs e)
        {
            ChangeControl(vid);
        }

        private void pnlMenu2_Click(object sender, EventArgs e)
        {
            ChangeControl(pic);
        }

        private void pnlMenu3_Click(object sender, EventArgs e)
        {
            ChangeControl(sav);
        }
        private void pnlMenu4_Click(object sender, EventArgs e)
        {
            ChangeControl(inf);
        }
        private void pnlMenu5_Click(object sender, EventArgs e)
        {
            ChangeControl(abo);
        }
    }
}