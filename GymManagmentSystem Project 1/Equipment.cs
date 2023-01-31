using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace GymManagmentSystem_Project_1
{
    public partial class Equipment : Form
    {
        public Equipment()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            String EquipName = txtEname.Text;
            String Description = txtDisc.Text;
            String MUsed= txtMused.Text;
            String DDate = dateTimePickerDD.Text;
            Int64 cost= Int64.Parse(txtCost.Text);

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = DESKTOP-OTSNRSN; database = Gym; integrated security = true";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "insert into Equipments (EquipName, EDescription, MUsed, DDate, Cost) values ('" + EquipName + "', '" + Description + "','" + MUsed + "','" + DDate + "', " + cost + ")";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            MessageBox.Show("Data Saved");

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtEname.Clear();
            txtDisc.Clear();
            txtMused.Clear();
            txtCost.Clear();
            dateTimePickerDD.Value = DateTime.Now;
            
        }

        private void btnViewEquipment_Click(object sender, EventArgs e)
        {
            ViewEquipment ve = new ViewEquipment();
            ve.Show();
        }
    }
}
