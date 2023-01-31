using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymManagmentSystem_Project_1
{
    public partial class NewStaff : Form
    {
        public NewStaff()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
          
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            txtPhone.Clear();
            txtEmail.Clear();
            txtCity.Clear();
            dateTimePickerDOB.Value = DateTime.Now;
            dateTimePickerJoinDate.Value = DateTime.Now;
        }

        private void NewStaff_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            String name = txtName.Text;

            String gender = "";
            bool isChacked = radioButton1.Checked;
            if (isChacked)
                gender = radioButton1.Text;
            else
                gender = radioButton2.Text;
            String dob = dateTimePickerDOB.Text;
            Int64 mobile = Int64.Parse(txtPhone.Text);
            String email = txtEmail.Text;
            String joindate = dateTimePickerJoinDate.Text;
            String city = txtCity.Text;


            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = DESKTOP-OTSNRSN; database = Gym; integrated security = true";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "insert into NewStaff (Name, Gender, Dob, Mobile, Email, JoinDate,city) values ('" + name + "', '" + gender + "','" + dob + "'," + mobile + ", '" + email + "', '" + joindate + "', '" + city + "')";

            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            MessageBox.Show("Data Saved");


        }
    }
}
