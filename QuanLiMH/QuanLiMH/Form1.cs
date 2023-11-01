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

namespace QuanLiMH
{
    public partial class Form1 : Form
    {
        public class KetNoi
        {
            public SqlConnection connect;
            public KetNoi()
            {
                connect = new SqlConnection("Data Source = <A209PC33>; Initial Catalog = <Phong>; Integrated Security = True");
            }
            public KetNoi(string strcn)
            {
                connect = new SqlConnection(strcn);
            }
        }
        KetNoi kn = new KetNoi();
        SqlConnection connsql;
        public Form1()
        {
            InitializeComponent();
            connsql = kn.connect;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Them_Click(object sender, EventArgs e)
        {
            try
            {
                if (connsql.State == ConnectionState.Closed)
                {
                    connsql.Open();
                }
                string insertString;
                insertString = "Inser into Table_1 values(' " + textBox1.Text + " ', N'" + textBox2.Text + "')";
                SqlCommand cmd = new SqlCommand(insertString, connsql);
                cmd.ExecuteNonQuery();
                if (connsql.State == ConnectionState.Open)
                {
                    connsql.Close();
                }
                MessageBox.Show("Thanh Cong");
            }
            catch(Exception)
            {
                MessageBox.Show("That Bai");
            }
        }

        private void Sua_Click(object sender, EventArgs e)
        {
            try
            {
                if (connsql.State == ConnectionState.Closed)
                {
                    connsql.Open();
                }
                string insertString;
                string updateString = "update MaMH set TenMH= ' " + textBox1.Text + "where MaMH'" + textBox2.Text + "'";
                SqlCommand cmd = new SqlCommand(insertString, connsql);
                cmd.ExecuteNonQuery();
                if (connsql.State == ConnectionState.Open)
                {
                    connsql.Close();
                }
                MessageBox.Show("Thanh Cong");
            }
            catch (Exception)
            {
                MessageBox.Show("That Bai");
            }
            
        }

        private void Xoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (connsql.State == ConnectionState.Closed)
                {
                    connsql.Open();
                }
                string insertString;
                string deleteString = "delete TenMH where MaMH='" + textBox1.Text + "'";
                SqlCommand cmd = new SqlCommand(insertString, connsql);
                cmd.ExecuteNonQuery();
                if (connsql.State == ConnectionState.Open)
                {
                    connsql.Close();
                }
                MessageBox.Show("Thanh Cong");
            }
            catch (Exception)
            {
                MessageBox.Show("That Bai");
            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Control ctr=(Control)sender;
            if (ctr.Text.Trim().Length == 0)
                this.errorProvider1.SetError(ctr, "Khong duoc de trong");
            else
                this.errorProvider1.Clear();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Control ctr=(Control)sender;
            if (ctr.Text.Trim().Length == 0)
                this.errorProvider1.SetError(ctr, "Khong duoc de trong");
            else
                this.errorProvider1.Clear();
        }
    }
}
