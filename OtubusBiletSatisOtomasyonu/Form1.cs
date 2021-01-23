using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using  System.Data.SqlClient;
namespace OtubusBiletSatisOtomasyonu
{
    public partial class AnaSayfa : Form
    {
        SqlConnection baglanti = new SqlConnection("server=.;Initial Catalog=OtobusBiletDB;Integrated Security=true");
        public AnaSayfa()
        {
            InitializeComponent();
        }

        private void AnaSayfa_Load(object sender, EventArgs e)
        {
            Listele();
            lblName.Text = AdminPaneli.isim.ToString();
            lblSurname.Text = AdminPaneli.soyisim.ToString();
        }

        void Temizle()
        {
           txtAd.Clear();
            txtSoyad.Clear();
            mtbTelefon.Clear();
            txtPosta.Clear();
            txtAdres.Clear();
            cmbBinisYeri.Items.Remove(cmbBinisYeri.Text);
            mkdBinisSaati.Clear();
            cmbVarisYeri.Items.Remove(cmbVarisYeri.Text);
            mkdVarisSaati.Clear();
            mtbTarih.Clear();
            cmbKoltukNo.Items.Remove(cmbKoltukNo.Text);
            txtFiyat.Clear();
            cmbCinsiyet.Items.Remove(cmbCinsiyet.Text);
        }
       
        private void btnRadyo_Click(object sender, EventArgs e)
        {
            Radyo radyo = new Radyo();
            radyo.Show();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            DialogResult sonuc;
            sonuc = MessageBox.Show("Çıkmak istediğinize emin misiniz ?", "Çıkış", MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);
            if (sonuc == DialogResult.Yes)
            {
                this.Close();
                Application.Exit();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtAd.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtSoyad.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            mtbTelefon.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtPosta.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtAdres.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            cmbBinisYeri.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            mkdBinisSaati.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            cmbVarisYeri.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            mkdVarisSaati.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            mtbTarih.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
            cmbKoltukNo.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();
            txtFiyat.Text = dataGridView1.CurrentRow.Cells[12].Value.ToString();
            cmbCinsiyet.Text = dataGridView1.CurrentRow.Cells[13].Value.ToString();
        }

        private void btnBiletSat_Click(object sender, EventArgs e)
        {
            
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = baglanti;
                cmd.CommandText = "insert into Kayıtlar(Adi,Soyadi,Telefon,Eposta,Adres,BinisYeri,BinisSaati,VarisYeri,VarisSaati,Tarih,KoltukNo,Fiyat,Cinsiyet) values ('" + txtAd.Text + "','" + txtSoyad.Text + "','" + mtbTelefon.Text + "','" + txtPosta.Text + "','" + txtAdres.Text + "','" + cmbBinisYeri.Text + "','" + mkdBinisSaati.Text + "','" + cmbVarisYeri.Text + "','" + mkdVarisSaati.Text + "','" + mtbTarih.Text + "','" + cmbKoltukNo.Text + "','" + txtFiyat.Text + "','" + cmbCinsiyet.Text + "')";
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                baglanti.Close();
                Listele();
                Temizle();
                MessageBox.Show("kayıt tamamlanmıştır");
            }
            
        }
        void Listele()
        {
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = baglanti;
                cmd.CommandText = "select * from Kayıtlar";
                SqlDataAdapter adpr = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adpr.Fill(ds, "Kayıtlar");
                dataGridView1.DataSource = ds.Tables["Kayıtlar"];
                baglanti.Close();
            }
        }

        private void btnBiletİptal_Click(object sender, EventArgs e)
        {
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = baglanti;
                cmd.CommandText = "delete from Kayıtlar where id = @numara";
                cmd.Parameters.AddWithValue("@numara", dataGridView1.CurrentRow.Cells[0].Value.ToString());
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                baglanti.Close();
                Listele();
                MessageBox.Show("İptal Edilmiştir.");
            }
        }

        private void btnBiletGuncelle_Click(object sender, EventArgs e)
        {
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = baglanti;
                cmd.CommandText = "update Kayıtlar set Adi='" + txtAd.Text + "',Soyadi='" + txtSoyad.Text + "',Telefon='" + mtbTelefon.Text + "',Eposta='" + txtPosta.Text + "',Adres='" + txtAdres.Text + "',BinisYeri='" + cmbBinisYeri.Text + "',BinisSaati='" + mkdBinisSaati.Text + "',VarisYeri='" + cmbVarisYeri.Text + "',VarisSaati='" + mkdVarisSaati.Text + "',Tarih='" + mtbTarih.Text + "',KoltukNo='" + cmbKoltukNo.Text + "',Fiyat='" + txtFiyat.Text + "',Cinsiyet='" + cmbCinsiyet.Text + "' where id =@numara";
                cmd.Parameters.AddWithValue("@numara", dataGridView1.CurrentRow.Cells[0].Value.ToString());
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                baglanti.Close();
                Listele();
                MessageBox.Show("Güncelleme Başarılı");
            }
        }

        private void btnRapor_Click(object sender, EventArgs e)
        {
            Raporlama raporlama = new Raporlama();
            raporlama.Show();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }
    }
}
