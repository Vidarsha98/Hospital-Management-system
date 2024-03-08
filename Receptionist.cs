using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace hospital_management
{
    public partial class Receptionist : Form
    {

        //Add the DataGridView decalaration here
        private DataGridView receptionistDGV = new DataGridView();
        public Receptionist()
        {
            InitializeComponent();
            DisplayRec();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-RTCSEDA;Initial Catalog=Hospitalsql;Integrated Security=True");


        private void receptionists_Load(object sender, EventArgs e)
        {

        }
        private void DisplayRec()
        {
            Con.Open();
            String Query = "Select *  from ReceptionistTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder();
            var ds = new DataSet();
            sda.Fill(ds);
            receptionistDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void btnadd_Click(object sender, EventArgs e)
        {
            if (RNameTb.Text == "" || txtpassword.Text == "" || RPhoneTb.Text == "" || RAddressTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into ReceptionistTbl(RecepName,RecepPhone,RecepAdd,RecepPass)values(@RN,@RP,@RA,@RPA)", Con);
                    cmd.Parameters.AddWithValue("@RN", RNameTb.Text);
                    cmd.Parameters.AddWithValue("@RP", RPhoneTb.Text);
                    cmd.Parameters.AddWithValue("@RA", RAddressTb.Text);
                    cmd.Parameters.AddWithValue("@RPA", txtpassword.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Receptionist Added");
                    Con.Close();
                    DisplayRec();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
    }
}
