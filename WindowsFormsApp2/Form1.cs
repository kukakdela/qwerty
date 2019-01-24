using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        Form2 Enter = new Form2();
        public Form1()

        {
            InitializeComponent();
            ToolStripMenuItem fileItem = new ToolStripMenuItem("Autorization");

            fileItem.DropDownItems.Add("Change password");
            fileItem.DropDownItems.Add("New user");
            fileItem.DropDownItems.Add("All user");
            fileItem.DropDownItems.Add("Exit");
            menuStrip1.Items.Add(fileItem);

            ToolStripMenuItem aboutItem = new ToolStripMenuItem("About the program");
            aboutItem.Click += aboutItem_Click;
            menuStrip1.Items.Add(aboutItem);
        }

        private void aboutItem_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Enter.Show();    
        }
    }
}
