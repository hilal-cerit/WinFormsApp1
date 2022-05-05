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

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=LoginRegistrationInMVC;Integrated Security=True;");


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void getAllDataButton_Click(object sender, EventArgs e)
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Select * from Products", connection);
            DataSet ds = new DataSet();
            sqlDataAdapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];



        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand saveData = new SqlCommand("insert into Products (Id,ProductName,Price,Url,Description) values (@p1,@p2,@p3,@p4,@p5)",connection);
            saveData.Parameters.AddWithValue("@p1", textBox1.Text);
            saveData.Parameters.AddWithValue("@p2", textBox2.Text);
            saveData.Parameters.AddWithValue("@p3", textBox3.Text);
            saveData.Parameters.AddWithValue("@p4", textBox4.Text);
            saveData.Parameters.AddWithValue("@p5", textBox5.Text);

            saveData.ExecuteNonQuery();
            connection.Close();



        }

        private void deleteDataButton_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand deleteData = new SqlCommand("delete from Products where Id= @p1", connection);
            deleteData.Parameters.AddWithValue("@p1", textBox1.Text);
            deleteData.Parameters.AddWithValue("@p2", textBox2.Text);
            deleteData.Parameters.AddWithValue("@p3", textBox3.Text);
            deleteData.Parameters.AddWithValue("@p4", textBox4.Text);
            deleteData.Parameters.AddWithValue("@p5", textBox5.Text);

            deleteData.ExecuteNonQuery();
            connection.Close();
        }

   
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int choosen = dataGridView1.SelectedCells[0].RowIndex;

            string ıd = dataGridView1.Rows[choosen].Cells[0].Value.ToString();
            string productName = dataGridView1.Rows[choosen].Cells[1].Value.ToString();
            string price = dataGridView1.Rows[choosen].Cells[2].Value.ToString();
            string url = dataGridView1.Rows[choosen].Cells[3].Value.ToString();
            string description = dataGridView1.Rows[choosen].Cells[4].Value.ToString();

            textBox1.Text = ıd;
            textBox2.Text = productName;
            textBox3.Text = price;
            textBox4.Text = url;
            textBox5.Text = description;
      
        }

        private void updateDataButton_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand updateData = new SqlCommand("update Products set Id=@p1,ProductName=@p2,Price=@p3,Url=@p4,Description=@p5 where Id=@p1 ",connection);
            updateData.Parameters.AddWithValue("@p1", textBox1.Text);
            updateData.Parameters.AddWithValue("@p2", textBox2.Text);
            updateData.Parameters.AddWithValue("@p3", textBox3.Text);
            updateData.Parameters.AddWithValue("@p4", textBox4.Text);
            updateData.Parameters.AddWithValue("@p5", textBox5.Text);

            updateData.ExecuteNonQuery();
            connection.Close();




        }

        private void searchDataButton_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlDataAdapter searchData = new SqlDataAdapter("select * from Products  where Id='"+textBox1.Text +"'", connection);
            DataSet dataSet = new DataSet();
            searchData.Fill(dataSet);
            dataGridView1.DataSource = dataSet.Tables[0];

        
            connection.Close();

        }

        private void showQuantityofProductsButton_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("Select count(ProductName) from Products", connection);
            SqlDataReader read = command.ExecuteReader();
            while(read.Read())
            {
                label7.Text = read[0].ToString();

            }
            connection.Close();
        }
    }
}
