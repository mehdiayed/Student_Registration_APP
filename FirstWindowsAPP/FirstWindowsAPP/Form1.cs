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
using System.Xml.Linq;

namespace FirstWindowsAPP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Load_Methode();
        }

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-O2GVR5N; Initial Catalog=firstDatabase; Integrated Security=true");
        SqlCommand cmd;
        SqlDataReader read;
        SqlDataAdapter drr;
        string id;
        bool Mode = true; // if the mode is true , that means add records , otherwise update the record 
        string sql;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        public void Load_Methode()
        {
            try
            {
                sql = "select * from student";

                con.Open();

                cmd = new SqlCommand(sql, con);

                read = cmd.ExecuteReader();

                drr = new SqlDataAdapter(sql, con);

                dataGridView1.Rows.Clear();

                while (read.Read())
                {
                    dataGridView1.Rows.Add(read[0], read[1], read[2], read[3]);
                }
                con.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        public void GetID(string id)
        {
            sql = "select * from student where id = '" + id + "'  ";
            cmd = new SqlCommand(sql, con);
            con.Open();
            read = cmd.ExecuteReader();

            while (read.Read())
            {
                textBoxName.Text = read[1].ToString();
                textBoxCours.Text = read[2].ToString();
                textBoxFee.Text = read[3].ToString();
            }
            con.Close();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            string cours = textBoxCours.Text;
            string fee = textBoxFee.Text;

            if (Mode == true)
            {
                sql = "insert into student(stname,cours,fee) values(@stname,@cours,@fee)";
                con.Open();
                cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@stname", name);
                cmd.Parameters.AddWithValue("@cours", cours);
                cmd.Parameters.AddWithValue("@fee", fee);
                MessageBox.Show("redcord aded seccessfully 💚 ");
                cmd.ExecuteNonQuery();

                textBoxName.Clear();
                textBoxCours.Clear();
                textBoxFee.Clear();

                textBoxName.Focus();

            }
            else
            {
                id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                sql = "update student set stname =@stname,cours= @cours,fee=@fee where id = @id ";
                con.Open();
                cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@stname", name);
                cmd.Parameters.AddWithValue("@cours", cours);
                cmd.Parameters.AddWithValue("@fee", fee);
                cmd.Parameters.AddWithValue("@id", id);
                MessageBox.Show("redcord updated seccessfully 🦾 ");
                cmd.ExecuteNonQuery();

                textBoxName.Clear();
                textBoxCours.Clear();
                textBoxFee.Clear();

                textBoxName.Focus();
                button1.Text = "Save";
                Mode = true;

            }
            con.Close();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBoxName.Clear();
            textBoxCours.Clear();
            textBoxFee.Clear();

            textBoxName.Focus();
            button1.Text = "Save";
            Mode = true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["Editbutton"].Index && e.RowIndex >= 0)
            {
                Mode = false;
                id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                GetID(id);
                button1.Text = "Edit";
            }

            if (e.ColumnIndex == dataGridView1.Columns["Deletebutton"].Index && e.RowIndex >= 0)
            {
                Mode = false;
                id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                sql = "delete from student where id = @id";
                con.Open();
                cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@id", id);
                MessageBox.Show("redcord Deleted seccessfully 🕊 ");
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Load_Methode();
        }
    }
}