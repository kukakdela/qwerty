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
    public partial class Form4 : Form
    {
       // private object menuStrip1;
        ToolStripMenuItem fileItem;
        public Form4()
        {
            
            InitializeComponent();

        
            fileItem = new ToolStripMenuItem("Autorization",null, (s, e) => AuthClicked());

            fileItem.DropDownItems.Add("Change password", null, (s, e) => ChangePasswordClicked());
         /* 
            fileItem.DropDownItems.Add("Change password");
            fileItem.DropDownItems.Add("New user");
            fileItem.DropDownItems.Add("All user");
            fileItem.DropDownItems.Add("Exit");*/



           menuStrip1.Items.Add(fileItem);

       


            ToolStripMenuItem aboutItem = new ToolStripMenuItem("About the program");
            aboutItem.Click += aboutItem_Click;
            menuStrip1.Items.Add(aboutItem);
        }

  

        private void aboutItem_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }


        private void AuthClicked()
        {

            MessageBox.Show("123");

        }
        private void ChangePasswordClicked()
        {
          
            MessageBox.Show("456");

        }

        private void MenuItemClickHandler(object sender, EventArgs e)
        {
            ToolStripMenuItem clickedItem = (ToolStripMenuItem)sender;
            MessageBox.Show(clickedItem.Name);
            // Take some action based on the data in clickedItem
        }
    }
}
