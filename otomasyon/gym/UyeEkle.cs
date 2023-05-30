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
    public partial class UyeEkle : Form
    {
        public UyeEkle()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Tolunay\Documents\sporr.DB.mdf;Integrated Security=True;Connect Timeout=30");
        private void button1_Click(object sender, EventArgs e)
        {
            if (AdSoyadTB.Text == "" || TelefonTB.Text == "" || OdemeTB.Text == "" || YasTB.Text == "")
            {
                MessageBox.Show("Eksik Bilgi");
            }
            else
            {
                try
                {
                    baglanti.Open();
                    string query = "insert into UyeTbl values('" + AdSoyadTB.Text + "','" + TelefonTB.Text + "','" + CinsiyetCB.SelectedItem.ToString() + "','" + YasTB.Text + "','" + OdemeTB.Text + "')";
                    SqlCommand komut = new SqlCommand(query, baglanti);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Üye başaryla eklendi");
                    baglanti.Close();
                    AdSoyadTB.Text = "";
                    TelefonTB.Text = "";
                    YasTB.Text = "";
                    CinsiyetCB.Text = "";
                    OdemeTB.Text = "";


                }
                catch (Exception Ex)
                {
                    MessageBox.Show("Ex.Message");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdSoyadTB.Text = "";
            TelefonTB.Text = "";
            YasTB.Text = "";
            CinsiyetCB.Text = "";
            OdemeTB.Text = "";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            AnaSayfa anasayfa = new AnaSayfa();
            anasayfa.Show();
            this.Hide();
        }
    }
}
