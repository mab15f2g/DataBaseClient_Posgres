using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Configuration;
using Npgsql;

namespace DBClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        public NpgsqlConnection conn;
        public int rows_exists;





        private void button1_Click(object sender, EventArgs e)
        {
            loadgrid();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void username_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void loadgrid()
        {
            NpgsqlConnection conn = new NpgsqlConnection();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["Connection"].ToString();
            conn.Open();
            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.CommandText = "Select * from test";
            cmd.Connection = conn;
            NpgsqlDataAdapter da = new NpgsqlDataAdapter();
            da.SelectCommand = cmd;
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            rows_exists = dataGridView1.Rows.Count - 1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void updateDataButton(object sender, EventArgs e)
        {
                    }

        private void button2_Click(object sender, EventArgs e)
        {
            string StrQuery;
            NpgsqlConnection conn = new NpgsqlConnection();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["Connection"].ToString();
            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.Connection = conn;
            conn.Open();   
            
            
            for (int i= rows_exists; i < dataGridView1.Rows.Count-1; i++)
            {
                
                    StrQuery =
                       cmd.CommandText = @"INSERT INTO test VALUES ("
                       + dataGridView1.Rows[i].Cells["id"].Value + ", "
                       + "'" + dataGridView1.Rows[i].Cells["name"].Value + "'" + ");";
                    cmd.CommandText = StrQuery;
                    cmd.ExecuteNonQuery();
                
               
            }
            
    }
    }
}
