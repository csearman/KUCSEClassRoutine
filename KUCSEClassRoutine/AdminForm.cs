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
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace KUCSEClassRoutine
{
    public partial class AdminForm : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Palash\Desktop\KUCSEClassRoutine\KUCSEClassRoutine\KUCSEClassRoutine.mdf;Integrated Security=True");
        string[,] RoutineArray = new string[21, 11];
        int []Lab = new int[3]{0,4,7};
        string query;
        SqlCommand Sqlcmd;
        SqlDataReader reader;
        public AdminForm()
        {
            InitializeComponent();
            dataGridView1.ColumnHeadersVisible = false;
            dataGridView1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }
        DataTable dbdataset;

        private void Add_Click(object sender, EventArgs e)
        {
            AddCourse add = new AddCourse();
            add.ShowDialog();
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
 
        private void Update_Click(object sender, EventArgs e)
        {
           
        }

        public void update()
        {
            query = "DELETE Routine where Term != ' year'";
            Sqlcmd = new SqlCommand(query, conn);
            conn.Open();
            Sqlcmd.ExecuteNonQuery();
            conn.Close();
            for (int i = 1; i < 21; i++)
            {
                query = "INSERT INTO Routine(Term,time1,time2,time3,time4,time5,time6,time7,time8,time9,rownum) values( '" + year(i) + "','" + RoutineArray[i, 1] + "','" + RoutineArray[i, 2] + "','" + RoutineArray[i, 3] + "','" + RoutineArray[i, 4] + "','" + RoutineArray[i, 5] + "','" + RoutineArray[i, 6] + "','" + RoutineArray[i, 7] + "','" + RoutineArray[i, 8] + "','" + RoutineArray[i, 9] + "','" + i + "')";
                Sqlcmd = new SqlCommand(query, conn);
                conn.Open();
                Sqlcmd.ExecuteNonQuery();
                conn.Close();
            }
            //MessageBox.Show("Updated Successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ViewRoutine_Click(object sender, EventArgs e)
        {
            viewRoutine();
        }

        public void viewRoutine()
        {
            try
            {
                query = "SELECT* from Routine";
                Sqlcmd = new SqlCommand(query, conn);
                conn.Open();
                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = Sqlcmd;
                dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bSource = new BindingSource();
                bSource.DataSource = dbdataset;
                dataGridView1.DataSource = bSource;
                sda.Update(dbdataset);
                dataGridView1.Columns.Remove("rownum");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
     
        private void PrintRoutine_Click(object sender, EventArgs e)
        {
            Document document = new Document(iTextSharp.text.PageSize.A4, 10, 10, 42, 35);
            PdfWriter wri = PdfWriter.GetInstance(document, new FileStream("Table.pdf", FileMode.Create));
            document.Open();

            PdfPTable pdfTable = new PdfPTable(dataGridView1.Columns.Count);

            pdfTable.HeaderRows = 1;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for (int k = 0; k < dataGridView1.Columns.Count; k++)
                {
                    if (dataGridView1[k, i].Value != null)
                        pdfTable.AddCell(new Phrase(dataGridView1[k, i].Value.ToString()));
                }
            }
            document.Add(pdfTable);
            document.Close();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {

        }


        private void Generate_Click(object sender, EventArgs e)
        {
            generate();
        }

        public void generate()
        {
            fillTableWithNoSubject();
            try
            {
                query = "SELECT CourseNumber FROM RoutineInfo WHERE Lab = 'Lab'";
                Sqlcmd = new SqlCommand(query, conn);
                conn.Open();
                reader = Sqlcmd.ExecuteReader();
                List<string> lab = new List<string>();
                while (reader.Read())
                    lab.Add(reader["CourseNumber"].ToString());
                conn.Close();
                while (lab.Count > 0)
                {
                    string courseNumber = lab[0];
                    int year = Int32.Parse(courseNumber.Substring(4, 1));
                    while (true)
                    {
                        int position = random("Lab");
                        int day = random("Day");
                        int row = (4 * day) + year - 4;
                        int column = Lab[position];
                        if (RoutineArray[row, column] == "-")
                        {
                            RoutineArray[row, column] = courseNumber;
                            RoutineArray[row, column + 1] = courseNumber;
                            RoutineArray[row, column + 2] = courseNumber;
                            lab.RemoveAt(0);
                            break;
                        }
                    }
                }
                query = "SELECT CourseNumber FROM RoutineInfo WHERE Lab = 'Theory'";
                Sqlcmd = new SqlCommand(query, conn);
                conn.Open();
                reader = Sqlcmd.ExecuteReader();
                List<string> theory = new List<string>();
                while (reader.Read())
                    theory.Add(reader["CourseNumber"].ToString());
                conn.Close();
                while (theory.Count > 0)
                {
                    string courseNumber = theory[0];
                    int year = Int32.Parse(courseNumber.Substring(4, 1));

                    query = "SELECT Credit FROM RoutineInfo WHERE CourseNumber = '" + courseNumber + "'";
                    Sqlcmd = new SqlCommand(query, conn);
                    conn.Open();
                    reader = Sqlcmd.ExecuteReader();
                    int loop = 0;
                    while (reader.Read())
                        loop = int.Parse(reader["Credit"].ToString());
                    conn.Close();
                    
                    for (int i = 0; i < loop; i++)
                    {
                        while (true)
                        {
                            int column = random("Theory");
                            int day = random("Day");
                            int row = (4 * day) + year - 4;
                            if (RoutineArray[row, column] == "-" && !doubleClassPerDayInaRow(row, column, courseNumber) && !tripleClassPerWeekInaRow(row, courseNumber) && !doubleClassInSameTime(row, column, courseNumber))
                            {
                                RoutineArray[row, column] = courseNumber;
                                break;
                            }
                        }
                    }
                    theory.RemoveAt(0);
                }
                //dataPrint(RoutineArray);
                update();
                viewRoutine();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
            MessageBox.Show("Successfully Done", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);           
        }

        public bool doubleClassInSameTime(int row, int column, string course)
        {
            string teacher = teacherName(course);
            query = "SELECT CourseNumber FROM RoutineInfo WHERE TeacherName = '" + teacher + "'";
            Sqlcmd = new SqlCommand(query, conn);
            conn.Open();
            reader = Sqlcmd.ExecuteReader();
            List<string> courseList = new List<string>();
            while (reader.Read())
                courseList.Add(reader["CourseNumber"].ToString());
            conn.Close();
            for (int i = 0; i < courseList.Count; i++)
            {
                if (row % 4 == 1)
                {
                    if (RoutineArray[row + 1, column] == courseList[i] || RoutineArray[row + 2, column] == courseList[i] || RoutineArray[row + 3, column] == courseList[i])
                        return true;
                }
                else if (row % 4 == 2)
                {
                    if (RoutineArray[row - 1, column] == courseList[i] || RoutineArray[row + 1, column] == courseList[i] || RoutineArray[row + 2, column] == courseList[i])
                        return true;
                }
                else if (row % 4 == 3)
                {
                    if (RoutineArray[row - 1, column] == courseList[i] || RoutineArray[row - 2, column] == courseList[i] || RoutineArray[row + 1, column] == courseList[i])
                        return true;
                }
                else if (row % 4 == 0)
                {
                    if (RoutineArray[row - 1, column] == courseList[i] || RoutineArray[row - 2, column] == courseList[i] || RoutineArray[row - 3, column] == courseList[i])
                        return true;
                }
            }
            return false;
        }


        public string teacherName(string course)
        {
            query = "SELECT TeacherName FROM RoutineInfo WHERE CourseNumber = '" + course + "'";
            Sqlcmd = new SqlCommand(query, conn);
            conn.Open();
            reader = Sqlcmd.ExecuteReader();
            string teacher = "";
            while (reader.Read())
                teacher = reader["TeacherName"].ToString();
            conn.Close();
            return teacher;
        }

        public bool doubleClassPerDayInaRow(int row, int column, string course)
        {
            if (RoutineArray[row, column - 1] == course || RoutineArray[row, column + 1] == course)
                return true;
            else
                return false;
        }

        public bool tripleClassPerWeekInaRow(int row, string course)
        {
            if (row < 5)
            {
                if (checkFullDayTime(row + 4, course) || checkFullDayTime(row + 8, course))
                    return true;
                else
                    return false;
            }
            else if (row > 4 && row < 9)
            {
                if ((checkFullDayTime(row - 4, course) || checkFullDayTime(row + 4, course)) && (checkFullDayTime(row + 4, course) || checkFullDayTime(row + 8, course)))
                    return true;
                else
                    return false;
            }
            else if (row > 8 && row < 13)
            {
                if ((checkFullDayTime(row - 4, course) || checkFullDayTime(row - 8, course)) && (checkFullDayTime(row + 4, course) || checkFullDayTime(row + 8, course)) && (checkFullDayTime(row - 4, course) || checkFullDayTime(row + 4, course)))
                    return true;
                else
                    return false;
            }
            else if (row > 12 && row < 17)
            {
                if ((checkFullDayTime(row - 4, course) || checkFullDayTime(row - 8, course)) && (checkFullDayTime(row - 4, course) || checkFullDayTime(row + 4, course)))
                    return true;
                else
                    return false;
            }
            else if (row > 16)
            {
                if (checkFullDayTime(row - 4, course) || checkFullDayTime(row - 8, course))
                    return true;
                else
                    return false;
            }
            else
                return false;

        }

        public bool checkFullDayTime(int row, string course)
        {
            for (int i = 1; i < 10; i++)
                if(RoutineArray[row, i] == course)
                    return true;
            return false;
        }

        public int random(string lab)
        {
            Random rnd = new Random();
            int rndNumber;
            if (lab == "Lab")
                rndNumber = rnd.Next(1, 3);
            else if(lab == "Theory")
                rndNumber = rnd.Next(1, 10);
            else
                rndNumber = rnd.Next(1, 6);
            return rndNumber;
        }

        public void fillTableWithNoSubject()
        {
            for(int i = 0;i<21;i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    RoutineArray[i, j] = "-";
                }
            }
            //dataPrint();
        }
        public void dataPrint(string [,]array)
        {
            int height = array.GetLength(0);
            int width = array.GetLength(1);

            this.dataGridView1.ColumnCount = width;

            for (int r = 0; r < height; r++)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(this.dataGridView1);

                for (int c = 0; c < width; c++)
                {
                    row.Cells[c].Value = array[r, c];
                }

                this.dataGridView1.Rows.Add(row);
            }
        }
        public string year(int row)
        {
            string year;
            year = "";
            if (row % 4 == 1)
                year = "Test Year";
            else if (row % 4 == 2)
                year = "2nd Year";
            else if (row % 4 == 3)
                year = "3rd Year";
            else if (row % 4 == 0)
                year = "4th Year";
            else
                year = " ";
            return year;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
