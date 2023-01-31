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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace GymManagmentSystem_Project_1
{
    public partial class NewMember : Form
    {
        public NewMember()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            String name= txtName.Text;
            
            String gender = "";
            bool isChacked= radioButton1.Checked;
            if (isChacked)
                gender= radioButton1. Text;
            else
                gender= radioButton2. Text;
            String dob= dateTimePickerDOB.Text;
            Int64 mobile = Int64.Parse(txtPhone.Text);
            String email = txtEmail.Text;
            String joindate = dateTimePickerJoinDate.Text;
            String gymTime = comboBoxGymTime.Text;
            String address= txtAddress.Text;
            String membership = comboBoxMembership.Text;


            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = DESKTOP-OTSNRSN; database = Gym; integrated security = true";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "insert into NewMember (Name, Gender, Dob, PMobile, Email, JoinDate,GymTime, Maddress, MembershipTime) values ('" +name+ "', '" +gender+ "','" +dob + "'," +mobile+ ", '"+email+ "', '"+joindate +"', '"+gymTime+"', '"+address+"', '"+membership+"')";

            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            MessageBox.Show("Data Saved");

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            radioButton1. Checked = false;
            radioButton2. Checked = false;
            txtPhone.Clear();
            txtEmail.Clear();
            txtAddress.Clear();
            comboBoxGymTime. ResetText();
            comboBoxMembership.ResetText();
            dateTimePickerDOB.Value = DateTime.Now;
            dateTimePickerJoinDate.Value= DateTime.Now;

        }

        private void NewMember_Load(object sender, EventArgs e)
        {

        }
    }
}
