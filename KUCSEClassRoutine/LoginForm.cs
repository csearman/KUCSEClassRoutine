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
    public partial class LoginForm : Form
    {

        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Palash\Desktop\KUCSEClassRoutine\KUCSEClassRoutine\KUCSEClassRoutine.mdf;Integrated Security=True");
        string temp, temp1;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void UserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void Password_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_Click(object sender, EventArgs e)
        {
            try
            {
                temp = UserName.Text.ToString();
                temp1 = Password.Text.ToString();
                string query = "SELECT * FROM Login WHERE Username = @Username AND Password = @Password";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Username", temp);
                cmd.Parameters.AddWithValue("@Password", temp1);

                conn.Open();
                SqlDataAdapter ad = new SqlDataAdapter(cmd);
                DataSet dt = new DataSet();
                ad.Fill(dt);
                if (dt.Tables[0].Rows.Count > 0)
                {
                    MessageBox.Show("Login Sucessfull.Click OK to continue", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AdminForm admin = new AdminForm();
                    admin.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Wrong Username/Password! \n Please try again!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    UserName.Text = "";
                    Password.Text = "";
                    //passWord.BackColor = Color.Pink;
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

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (e.CloseReason == CloseReason.ApplicationExitCall) return;

            switch (MessageBox.Show(this, "Exit Routine?", "KUCSE Routine", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation))
            {
                case DialogResult.No:
                    e.Cancel = true;
                    break;
                default:
                    Application.ExitThread();
                    break;
            }
        }
    }
}
