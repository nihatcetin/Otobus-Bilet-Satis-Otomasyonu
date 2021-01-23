using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace OtubusBiletSatisOtomasyonu
{
    public partial class AdminPaneli : Form
    {
        public AdminPaneli()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=.;Initial Catalog=OtobusBiletDB;Integrated Security=True");

        private void btnAdminGiris_Click(object sender, EventArgs e)
        {
            Getir();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from AdminPaneli where kullaniciAdi ='" + tBoxAdi.Text + "' and sifre='" + tBoxSifre.Text + "'", baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                AnaSayfa anaSayfa = new AnaSayfa();
                anaSayfa.Show();
                this.Hide();
            }
            else if (tBoxAdi.Text == "" && tBoxSifre.Text == "")
            {
                MessageBox.Show("!!! Alanlar boş geçilemez.!!!");
            }
            else
            {
                MessageBox.Show("!!! Kullanıcı adı veya şifre yanlış !!!");
                tBoxAdi.Clear();
                tBoxSifre.Clear();
            }
            baglanti.Close();
        }
        public static string isim;
        public static string soyisim;
        private void Getir()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select Adi,SoyAdi from AdminPaneli  where kullaniciAdi ='" + tBoxAdi.Text + "' and sifre ='" + tBoxSifre.Text + "'", baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                isim = dr[0].ToString();
                soyisim = dr[1].ToString();
            }
            baglanti.Close();
        }

        private void AdminPaneli_Load(object sender, EventArgs e)
        {

        }
    }
}
