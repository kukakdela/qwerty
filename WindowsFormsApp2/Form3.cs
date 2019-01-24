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

namespace WindowsFormsApp2
{
    public partial class Form3 : Form
    {
        Form3 List = new Form3();
        public Form3()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        
            
        {
            string connectionString = "Data Source=WINDOWS-SERVER-;" +
                "Initial Catalog=MU;" +
                "User id=sa;" +
                "Password=tesT900;";
            {
                SqlConnection myConnection = new SqlConnection(connectionString);
                myConnection.Open();
                string query = "SELECT TOP 5 * FROM users";
                SqlCommand command = new SqlCommand(query, myConnection);
                SqlDataReader reader = command.ExecuteReader();
                List<string[]> data = new List<string[]>();
                while (reader.Read())
                {
                    data.Add(new string[7]);
                    //MessageBox.Show(reader[0].ToString());
                    data[data.Count - 1][0] = reader[0].ToString();
                    data[data.Count - 1][1] = reader[1].ToString();
                    
                    
                }
                reader.Close();
                myConnection.Close();
                DataGridViewTextBoxColumn[] column = new DataGridViewTextBoxColumn[7];
                for (int i = 0; i < 7; i++)
                {
                    column[i] = new DataGridViewTextBoxColumn();
                    column[i].HeaderText = "Column " + i;
                    column[i].Name = "Column " + i;
                    dataGridView1.Columns.Add(column[i]);

                }


                foreach (string[] s in data)
                {
                    dataGridView1.Rows.Add(s);
                }

            }
        }
    }
}
    

