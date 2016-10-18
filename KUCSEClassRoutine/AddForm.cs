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

namespace KUCSEClassRoutine
{
    public partial class AddCourse : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Palash\Desktop\KUCSEClassRoutine\KUCSEClassRoutine\KUCSEClassRoutine.mdf;Integrated Security=True");
   
        public AddCourse()
        {
            InitializeComponent();
        }
        
        private void label2_Click(object sender, EventArgs e)
        {

        }



        private void CourseName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CourseNumber_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Credit_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TeacherName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Lab_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void Submit_Click(object sender, EventArgs e)
        {
            try
            {
                if(CourseNumber.Text =="" || CourseName.Text =="" || TeacherName.Text =="" || Credit.Text =="" || Lab.Text =="")
                    MessageBox.Show("Please Fill Up All The Fields ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else if(Lab.Text == "Theory" && (Credit.Text == "0.75" || Credit.Text == "1.5"))
                    MessageBox.Show("Credit of Theory Course Should be Integer", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else{
                    string query = "INSERT INTO RoutineInfo(CourseNumber,CourseName,TeacherName,Credit,Lab) values( '" + CourseNumber.Text + "','" + CourseName.Text + "','" + TeacherName.Text + "','" + Credit.Text + "','" + Lab.Text + "')";
                    SqlCommand Sqlcmd = new SqlCommand(query, conn);
                    conn.Open();
                    Sqlcmd.ExecuteNonQuery();
                    MessageBox.Show("Added", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CourseNumber.Text = ""; CourseName.Text = ""; TeacherName.Text = ""; Credit.Text = ""; Lab.Text = "";
                    }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
 
        }

        private void AddForm_Load(object sender, EventArgs e)
        {
          
        }

    }
}
