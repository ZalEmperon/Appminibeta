using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //membuat koneksi dengan database
            OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\S A K O L A H\database\DatabaseC#.accdb");
            //membuat adapter data
            OleDbDataAdapter da = new OleDbDataAdapter("select count(*) from login where username ='"+txtusername.Text+"' and password ='"+txtpassword.Text +"' ", con);
            // membuat datatable
            DataTable dt = new DataTable();
            //mengisi datatable
            da.Fill(dt);
            if(dt.Rows[0][0].ToString() == "1")
            {
                //terjadi jika username dan password benar
                Form2 f2 = new Form2();
                f2.Show();
                Form3 f3 = new Form3();
                f3.Show();
            }
            else
            {
                //terjadi jika username dan password salah
                MessageBox.Show("Invalid Username or Password");
            }
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
