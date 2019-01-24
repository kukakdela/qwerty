using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form2 : Form
    {

        string connectionString =
            "Data Source = WINDOWS-SERVER-;" +
            "Initial Catalog = MU;" +
            "User id = sa;" +
            "Password = tesT900;";
        private object formPasswordHash = null;

        Form4 Menu = new Form4();
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            SqlConnection myConnection = new SqlConnection(connectionString);
            myConnection.Open();
            string query = "SELECT TOP 1 password FROM users WHERE login = 'ivan'";
            SqlCommand command = new SqlCommand(query, myConnection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string dbPasswordHash = reader[0].ToString();
            }
           
          
            reader.Close();
            myConnection.Close();
            string formPassword = textBox2.ToString();
            string formPasswordHash = MD5Hash(formPassword);
            

            
        }

        public static string MD5Hash(string text)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            //compute hash from the bytes of text
            md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(text));

            //get hash result after compute it
            byte[] result = md5.Hash;

            StringBuilder strBuilder = new StringBuilder();
            for (int i = 0; i < result.Length; i++)
            {
                //change it into 2 hexadecimal digits
                //for each byte
                strBuilder.Append(result[i].ToString("x2"));
            }

            return strBuilder.ToString();
        }
    

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string dbPasswordHash = "";
            SqlConnection myConnection = new SqlConnection(connectionString);
            myConnection.Open();
            string query = "SELECT TOP 1 password FROM users WHERE login = 'ivan'";
            SqlCommand command = new SqlCommand(query, myConnection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                dbPasswordHash = reader[0].ToString();
            }


            reader.Close();
            myConnection.Close();
            string formPassword = textBox2.Text.ToString();
            string formPasswordHash = MD5Hash(formPassword);
            if(formPasswordHash.Equals(dbPasswordHash))
            {
                Menu.Show();
            } else 
            {
                MessageBox.Show("NE URA??");
            }
        }

            
       
        }

     
    }

