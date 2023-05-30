using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gym
{
    public partial class GüncelleSil : Form
    {
        public GüncelleSil()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Tolunay\Documents\sporr.DB.mdf;Integrated Security=True;Connect Timeout=30");
        private void uyeler()
        {
            baglanti.Open();
            string query = "select *from UyeTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, baglanti);
            SqlCommandBuilder builder = new SqlCommandBuilder();
            var ds = new DataSet();
            sda.Fill(ds);
            UyeDGV.DataSource = ds.Tables[0];
            baglanti.Close();
        }

        private void GüncelleSil_Load(object sender, EventArgs e)
        {
            uyeler();
        }
        int key = 0;

        private void UyeDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (UyeDGV.SelectedRows.Count > 0 && UyeDGV.SelectedRows[0].Index < UyeDGV.Rows.Count)
            {
                key = Convert.ToInt32(UyeDGV.SelectedRows[0].Cells[0].Value.ToString());
                AdSoyadTb.Text = UyeDGV.SelectedRows[0].Cells[1].Value.ToString();
                TelefonTb.Text = UyeDGV.SelectedRows[0].Cells[2].Value.ToString();
                CinsiyetCb.Text = UyeDGV.SelectedRows[0].Cells[3].Value.ToString();
                YasTb.Text = UyeDGV.SelectedRows[0].Cells[4].Value.ToString();
                OdemeTb.Text = UyeDGV.SelectedRows[0].Cells[5].Value.ToString();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            AdSoyadTb.Text = "";
            TelefonTb.Text = "";
            YasTb.Text = "";
            OdemeTb.Text = "";
            CinsiyetCb.Text = "";
        }
        private void button4_Click(object sender, EventArgs e)
        {
            AnaSayfa anasayfa = new AnaSayfa();
            anasayfa.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (key == 0 || AdSoyadTb.Text == "" || TelefonTb.Text == "" || CinsiyetCb.Text == "" || YasTb.Text == "" || OdemeTb.Text == "")
            {
                MessageBox.Show("Eksik Bilgi");
            }
            else
            {
                try
                {
                    baglanti.Open();
                    string query = "update UyeTbl set UAdSoyad='" + AdSoyadTb.Text + "',UTelefon='" + TelefonTb.Text + "',UCinsiyet='" + CinsiyetCb.Text + "',UYas='" + YasTb.Text + "',UOdeme='" + OdemeTb.Text + "' where UId=" + key + " ;";
                    SqlCommand komut = new SqlCommand(query, baglanti);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Üye Güncellendi");
                    baglanti.Close();
                    uyeler();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("Silinecek Üyeyi Seçiniz");
            }
            else
            {
                try
                {
                    baglanti.Open();
                    string query = "delete from UyeTbl where UId=" + key + ";";
                    SqlCommand komut = new SqlCommand(query, baglanti);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Üye Silindi");
                    baglanti.Close();
                    uyeler();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }




    }
}
