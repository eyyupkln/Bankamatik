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

namespace Bankamatik
{
    public partial class hareket : Form
    {
        public hareket()
        {
            InitializeComponent();
        }
        public string HESAPNOO;
        SqlConnection baglantı = new SqlConnection(@"Data Source=DESKTOP-AJM9AQ8\SQLEXPRESS;Initial Catalog=Bankamatik;Integrated Security=True");
        private void hareket_Load(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("Select TBL1.AD+' '+TBL1.SOYAD as 'GONDEREN',TBL2.AD+' '+TBL2.SOYAD as 'ALICI' , TUTAR From TBLHAREKET\r\n\r\ninner join tblkişiler as TBL1 on TBLHAREKET.GÖNDEREN= TBL1.HESAPNO\r\n\r\ninner join tblkişiler  as TBL2 on TBLHAREKET.ALICI= TBL2.HESAPNO where GÖNDEREN =" + HESAPNOO, baglantı);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1 .DataSource = dt;
            SqlDataAdapter da1 = new SqlDataAdapter("Select TBL1.AD+' '+TBL1.SOYAD as 'GONDEREN',TBL2.AD+' '+TBL2.SOYAD as 'ALICI' , TUTAR From TBLHAREKET\r\n\r\ninner join tblkişiler as TBL1 on TBLHAREKET.GÖNDEREN= TBL1.HESAPNO\r\n\r\ninner join tblkişiler  as TBL2 on TBLHAREKET.ALICI= TBL2.HESAPNO where ALICI=" + HESAPNOO, baglantı);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            dataGridView2 .DataSource = dt1;

        }
    }
}
