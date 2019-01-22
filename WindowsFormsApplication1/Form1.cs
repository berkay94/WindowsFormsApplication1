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
namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Odev;Integrated Security=True");
            SqlDataAdapter adap = new SqlDataAdapter("Select isim from Kisiler",con);
            DataTable dt = new DataTable();
            adap.Fill(dt);
            
            string[] array = dt.Rows.OfType<DataRow>().Select(k => k[0].ToString()).ToArray();
            List<string> list = new List<string>(array);

            Random r = new Random();


            for (int i = 0; i < 4; i++)
            {

                int sayi = r.Next(0, 17);

                listBox1.Items.Add(array[sayi].ToString());

            }

            for (int i = 0; i < 4; i++)
            {
                int sayi2 = r.Next(0, 17);

                listBox2.Items.Add(array[sayi2].ToString());
             

            }

            

            //for (int i = 0; i < 4; i++)
            //{

            //    int sayi2 = r.Next(0,17);
            //    listBox2.Items.Add(array[sayi2].ToString());

            //}


            //for (int i = 0; i < 4; i++)
            //{

            //    int sayi3 = r.Next(0, 17);
            //    listBox3.Items.Add(array[sayi3].ToString());

            //}

            //for (int i = 0; i < 4; i++)
            //{

            //    int sayi4 = r.Next(0, 17);
            //    listBox4.Items.Add(array[sayi4].ToString());

            //}


        }









    }
    }

