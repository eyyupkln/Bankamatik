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
using System.Data.SqlClient;

namespace Bankamatik
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public string hesap;

        SqlConnection baglantı = new SqlConnection(@"Data Source=DESKTOP-AJM9AQ8\SQLEXPRESS;Initial Catalog=Bankamatik;Integrated Security=True");

        void bakiyee()
        {
            baglantı.Open();
            SqlCommand komut3 = new SqlCommand("select * from TBLHESAP where hesapno =" + hesap, baglantı);
            SqlDataReader drr = komut3.ExecuteReader();
            while (drr.Read())
            {
                lblbakiye .Text  = drr[1].ToString() + "  TL";
            }
            baglantı.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            lblhesapno .Text = hesap;
            bakiyee();

            baglantı.Open();
            SqlCommand komut = new SqlCommand("select * from tblkişiler where HESAPNO=@p1",baglantı );
            komut.Parameters.AddWithValue("@p1", hesap);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lbladsoyad .Text = dr[1] + " " + dr[2];
                lbltc .Text = dr[3].ToString();
                lbltelefon .Text = dr[4].ToString();
            }
            baglantı .Close ();
        }

        void Hareketlerpaneli()
        {
            baglantı.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO TBLHAREKET (GÖNDEREN,ALICI,TUTAR) VALUES (@P1,@P2,@P3)", baglantı);
            cmd.Parameters.AddWithValue("@P1", lblhesapno.Text);
            cmd.Parameters.AddWithValue("@P2", mskhesapno.Text);
            cmd.Parameters.AddWithValue("@P3", txttutar.Text);
            
            cmd.ExecuteNonQuery();
            baglantı.Close();
        }

        private void btngönder_Click(object sender, EventArgs e)
        {

            //gönderilen hesabın para artışı
            baglantı .Open ();
            SqlCommand komut = new SqlCommand("update tblhesap set BAKİYE = BAKİYE+@p1 where HESAPNO=@p2", baglantı);
            komut .Parameters .AddWithValue ("@p1", decimal .Parse(txttutar.Text ));
            komut.Parameters.AddWithValue("@p2", mskhesapno .Text );
            komut .ExecuteNonQuery ();
            baglantı.Close();
           

            //gönderen hesabın para azalışı
            baglantı .Open ();
            SqlCommand komut2 = new SqlCommand("update tblhesap set BAKİYE=BAKİYE-@k1 where HESAPNO=@k2", baglantı);
            komut2.Parameters .AddWithValue ("@k1",decimal .Parse (txttutar .Text  ));
            komut2 .Parameters .AddWithValue ("@k2", hesap  );
            komut2 .ExecuteNonQuery ();
            baglantı .Close ();
            bakiyee();
            MessageBox.Show("İşlem Başarıyla Gerçekleşti");
            Hareketlerpaneli();

           
        }
        
        private void button1_Click(object sender, EventArgs e)
        {

            hareket hr = new hareket();
            hr.HESAPNOO  = lblhesapno .Text;
            hr.Show();
           
        }
    }
}
