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

namespace hospital_management
{
    public partial class Doctor : Form
    {
        public Doctor()
        {
            InitializeComponent();
            DisplayDoc();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-RTCSEDA;Initial Catalog=Hospitalsql;Integrated Security=True");


        private void Doctors_Load(object sender, EventArgs e)
        {

        }
        private void DisplayDoc()
        {
            Con.Open();
            String Query = "Select *  from DoctorTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder();
            var ds = new DataSet();
            sda.Fill(ds);
            DoctorDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void Clear()
        {
            DName.Text = "";
            DPhone.Text = "";
            DAddress.Text = "";
            DPassword.Text = "";
            DExperience.Text = "";
            comboBoxgender.SelectedIndex = 0;
            comboBoxspecialisation.SelectedIndex = 0;
            Key = 0;
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            if (DName.Text == "" || DPassword.Text == "" || DPhone.Text == "" || DAddress.Text == "" || DExperience.Text == "" || comboBoxspecialisation.SelectedIndex == -1 || comboBoxgender.SelectedIndex == -1 || dateTimePicker1.Value == DateTime.MinValue) 
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into DoctorTbl(DocName,DocPhone,DocAdd,DocPass,DocDOB,DocGen,DocSpec,DocExp)values(@DN,@DD,@DG,@DS,@DE,@DP,@DPA)", Con);
                    cmd.Parameters.AddWithValue("@DN", DName.Text);
                    cmd.Parameters.AddWithValue("@DP", DPhone.Text);
                    cmd.Parameters.AddWithValue("@DA", DAddress.Text);
                    cmd.Parameters.AddWithValue("@DPA", DPassword.Text);
                    cmd.Parameters.AddWithValue("@DE", DExperience.Text);
                    cmd.Parameters.AddWithValue("@DD", dateTimePicker1.Value);
                    cmd.Parameters.AddWithValue("@DS", comboBoxspecialisation.SelectedIndex);
                    cmd.Parameters.AddWithValue("@DG", comboBoxgender.SelectedIndex);


                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Doctor Added");
                    Con.Close();
                    DisplayDoc();
                    Clear();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }

            }
        }
        int Key = 0;

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void DoctorDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DName.Text = DoctorDGV.SelectedRows[0].Cells[1].Value.ToString();
            comboBoxgender.SelectedItem = DoctorDGV.SelectedRows[0].Cells[2].Value.ToString();
            comboBoxspecialisation.SelectedItem = DoctorDGV.SelectedRows[0].Cells[3].Value.ToString();
            DExperience.Text = DoctorDGV.SelectedRows[0].Cells[4].Value.ToString();
            dateTimePicker1.Text = DoctorDGV.SelectedRows[0].Cells[5].Value.ToString();
            DPhone.Text = DoctorDGV.SelectedRows[0].Cells[6].Value.ToString();
            DAddress.Text = DoctorDGV.SelectedRows[0].Cells[7].Value.ToString();
            DPassword.Text = DoctorDGV.SelectedRows[0].Cells[8].Value.ToString();

            if (DName.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(DoctorDGV.SelectedRows[0].Cells[0].Value.ToString());
            }

        }

        private void btnedit_Click(object sender, EventArgs e)
        {

            if (DName.Text == "" || DPassword.Text == "" || DPhone.Text == "" || DAddress.Text == "" || DExperience.Text == "" || comboBoxspecialisation.SelectedIndex == -1 || comboBoxgender.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Update DoctorTbl set DocName=@DN,DocPhone=@DP,DocAdd=@DA,DocPass=@DPA,DocDOB=@DD,DocGen=@DG,DocSpec=@DS,DocExp=@DE where Docid=@DKey ", Con);
                    cmd.Parameters.AddWithValue("@DN", DName.Text);
                    cmd.Parameters.AddWithValue("@DP", DPhone.Text);
                    cmd.Parameters.AddWithValue("@DA", DAddress.Text);
                    cmd.Parameters.AddWithValue("@DPA", DPassword.Text);
                    cmd.Parameters.AddWithValue("@DE", DExperience.Text);
                    cmd.Parameters.AddWithValue("@DD", dateTimePicker1.ShowCheckBox);
                    cmd.Parameters.AddWithValue("@DS", comboBoxspecialisation.SelectedIndex);
                    cmd.Parameters.AddWithValue("@DG", comboBoxgender.SelectedIndex);
                    cmd.Parameters.AddWithValue("@DKey", Key);
                    if (Con.State == ConnectionState.Closed)
                    {
                        Con.Open();
                    }

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Doctor Edited");
                    Con.Close();
                    DisplayDoc();
                    Clear();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (Key == 0)
            {
                MessageBox.Show("Select The Doctor");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Delete from DoctorTbl where Docid=@DKey", Con);

                    cmd.Parameters.AddWithValue("@DKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Doctor Deleted");
                    Con.Close();
                    DisplayDoc();
                    Clear();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
    }
}
