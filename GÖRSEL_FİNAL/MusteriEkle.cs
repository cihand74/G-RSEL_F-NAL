using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;




namespace GÖRSEL_FİNAL
{
    public partial class MusteriEkle : Form
    {
        public MusteriEkle()
        {
            InitializeComponent();
        }
       
        private string baglantiCumlesi = @"Data Source=DESKTOP-0MD2QHP;Initial Catalog=YTAracKilralama;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
      
        
        private void MusteriEkle_Load(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {


            SqlConnection baglanti = new SqlConnection(baglantiCumlesi);
            baglanti.Open();

            String komutCümlesi = "Insert Into Musteriler Values (@Tcno,@AdSoyad,@TelefonNo,@Mail,@Adres)";
            SqlCommand komut = new SqlCommand(komutCümlesi, baglanti);

            komut.Parameters.AddWithValue("@Tcno", txtTcNo.Text);
            komut.Parameters.AddWithValue("@AdSoyad", txtAdSoyad.Text);
            komut.Parameters.AddWithValue("@TelefonNo", maskedTextBox1.Text);
            komut.Parameters.AddWithValue("@Mail", txtMail.Text);
            komut.Parameters.AddWithValue("@Adres", txtAdres.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kayıt Başarılı");


        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
