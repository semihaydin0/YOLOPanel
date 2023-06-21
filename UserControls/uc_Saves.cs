using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Windows.Forms;

namespace App.UserControls
{
    public partial class uc_Saves : UserControl
    {
        public uc_Saves()
        {
            InitializeComponent();
        }
        public static void fillTable(DataGridView dgvData)
        {
            using (SQLiteConnection con = new SQLiteConnection("Data Source=" + frmMain.exePath + "\\YOLO\\Data.db;Version=3;"))
            {
                frmMain.Query = @"SELECT ID AS 'Kayıt Sırası',DATE AS 'Tespit Yapılan Tarih', VEHICLES AS 'Taşıt Sayısı', PEOPLE AS 'İnsan Sayısı' FROM DATA";
                using (SQLiteDataAdapter da = new SQLiteDataAdapter(frmMain.Query, con))
                {
                    using (DataTable dt = new DataTable())
                    {
                        da.Fill(dt);
                        dgvData.DataSource = dt;
                    }
                }
            }
        }
        private void uc_Saves_Load(object sender, System.EventArgs e)
        {
            fillTable(dgvData);
            dataGridViewSettings(dgvData);
        }
        private void dataGridViewSettings(DataGridView dgv)
        {
            dgv.RowHeadersVisible = false;
            dgv.BorderStyle = BorderStyle.None;
            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void pnlDelete_MouseEnter(object sender, System.EventArgs e)
        {
            pnlDelete.BackColor = Color.FromArgb(22, 30, 32);
        }

        private void pnlDelete_MouseLeave(object sender, System.EventArgs e)
        {
            pnlDelete.BackColor = Color.FromArgb(41, 44, 51);
        }

        private void pnlDelete_Click(object sender, System.EventArgs e)
        {
            if (dgvData.SelectedRows.Count > 0)
            {
                int indexID = int.Parse(dgvData.SelectedRows[0].Cells[0].Value.ToString());
                using (SQLiteConnection con = new SQLiteConnection("Data Source=" + frmMain.exePath + "\\YOLO\\Data.db;Version=3;"))
                {
                    frmMain.Query = @"DELETE FROM Data WHERE ID=" + indexID.ToString();
                    using (SQLiteCommand cmd = new SQLiteCommand(frmMain.Query, con))
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Kayıt Silindi", "İşlem Sonucu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        fillTable(dgvData);
                    }
                }
            }
            else
            {
                MessageBox.Show("Seçim yapmadınız!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
