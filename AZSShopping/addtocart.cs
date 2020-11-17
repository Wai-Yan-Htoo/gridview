using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace AZSShopping
{
    public partial class addtocart : Form
    {
        public addtocart()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.Hide();
            f1.Show();
        }

        private void btn_order_Click(object sender, EventArgs e)
        {
            //db
            string connectionstring = string.Format("server=localhost;uid=root;pwd=;database=office");
            MySqlConnection conn = new MySqlConnection(connectionstring);
            conn.Open();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            adapter.SelectCommand = new MySqlCommand("select * from tbl_item", conn);
            DataTable dt;
            DataSet ds=new DataSet();
            DataRow dr;

            adapter.Fill(ds, "0"); // function(Fill( dataset , string ))
            dt = ds.Tables["0"];  // dataset call to datatable [ string  ]
            dr = dt.Rows[0];    //row start index 0
            dg.DataSource = ds.Tables["0"];  //datasource get from ds to table



            /*Form1 f1 = new Form1();
            this.Hide();
            f1.Show();*/
        }
    }
}
