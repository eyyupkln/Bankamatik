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

namespace Bankamatik
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        SqlConnection baglantı = new SqlConnection(@"Data Source=DESKTOP-AJM9AQ8\SQLEXPRESS;Initial Catalog=Bankamatik;Integrated Security=True");
        private void btnkaydet_Click(object sender, EventArgs e)
        {
            baglantı .Open ();
            SqlCommand komut = new SqlCommand("insert into tblkişiler (AD,SOYAD,TC,TELEFON,HESAPNO,ŞİFRE) VALUES (@p1,@p2,@p3,@p4,@p5,@p6)", baglantı);
            komut.Parameters.AddWithValue("@p1", txtad.Text);
            komut .Parameters .AddWithValue ("@p2",txtsoyad .Text );
            komut .Parameters .AddWithValue ("@p3",msktc .Text );
            komut.Parameters.AddWithValue("@p4", msktelefon.Text);
            komut .Parameters .AddWithValue ( "@p5",mskhesapno .Text );
            komut .Parameters .AddWithValue ("@p6",txtşifre .Text );
            komut .ExecuteNonQuery ();

            baglantı .Close ();
            MessageBox.Show("Müşteri Bilgileri Sisteme Kaydedildi");


            baglantı .Open ();
            SqlCommand komut2 = new SqlCommand("insert into tblhesap (HESAPNO,BAKİYE) VALUES (@p1,@p2)", baglantı);
            komut2.Parameters.AddWithValue("@p1", mskhesapno.Text);
            komut2.Parameters.AddWithValue("@p2", 00);
            komut2.ExecuteNonQuery();
            baglantı.Close();
        }

        private void btnhesapno_Click(object sender, EventArgs e)
        {
            Random rastgele = new Random();
            int sayı = rastgele.Next(100000, 1000000);
            mskhesapno .Text = sayı.ToString();
        }
    }
}
