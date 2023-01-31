using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymManagmentSystem_Project_1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void txtLogin_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text == "ibrahim" && txtPassword.Text== "ibrahim")
            {
                Form1 f1 = new Form1();
                f1.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect User name or password." , "error",MessageBoxButtons.OK, MessageBoxIcon.Error ); 
                txtUserName.Clear();
                txtPassword.Clear();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
