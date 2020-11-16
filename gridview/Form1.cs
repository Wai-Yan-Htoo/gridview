using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace gridviewtest
{
    public partial class Form1 : Form
    {
      
        public Form1()
        {
            InitializeComponent();
        }
        public System.Collections.Generic.List<Person> People { get; set; }

        private void btn_show_Click(object sender, EventArgs e)
        {
            DataSet ds=new DataSet();
            DataTable dt;
            DataRow dr;

            string connectionstring = string.Format("server=localhost;uid=root;pwd=;database=office");
            MySqlConnection conn = new MySqlConnection(connectionstring);
            conn.Open();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            adapter.SelectCommand=new MySqlCommand("select * from tbl_stuff_info",conn);
            adapter.Fill(ds,"mydata");
            dt = ds.Tables["mydata"];
            dr = dt.Rows[0];
            dg.DataSource = ds.Tables["mydata"];

        }
    }
}
