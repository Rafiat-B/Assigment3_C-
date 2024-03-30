using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_2
{
    public partial class StudentAssignForm : Form
    {
        //private AssignmentForm assignmentForm;
        private StudentDB studentDB = new StudentDB();
        public StudentAssignForm()
        {
            InitializeComponent();

            dataGridView_S.CellDoubleClick += dataGridView_S_CellDoubleClick;

            LoadStudentDataGridView();
        }

        private void StudentAssignForm_Load(object sender, EventArgs e)
        {
            StudentDB.GetStudents();
            LoadStudentDataGridView();
        }

        private void LoadStudentDataGridView()
        {
            dataGridView_S.Rows.Clear();

            var students = StudentDB.GetStudents().OrderBy(x=>x.FirstName);
            foreach (var student in students)
            {
                dataGridView_S.Rows.Add(student.Id, student.FirstName, student.LastName, student.Age, student.Gender, student.ClassName, student.Grade);
            }

        }

        private void ClearData()
        {
            txtId.Text = " ";
            txtFirstName.Text = " ";
            txtLastName.Text = " ";
            txtAge.Text = " ";
            txtGen.Text = " ";
            txtClassName.Text = " ";
            txtGrade.Text = " ";
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            string searchItem = txtSearch.Text;

            if (!string.IsNullOrEmpty(searchItem))
            {
                List<Student> students = StudentDB.GetStudents();
                
                    var searchResults = (from student in students
                                         where student.FirstName == searchItem || student.Id == searchItem || student.LastName == searchItem
                                         select student).ToList();
                    if(searchResults.Any())
                    {
                        dataGridView_S.Rows.Clear();
                        foreach (var student in searchResults)
                        {
                            dataGridView_S.Rows.Add(student.Id, student.FirstName,
                                                    student.LastName, student.Age,
                                                    student.Gender, student.ClassName, student.Grade);
                        }
                        txtSearch.Text = " ";
                    }
                    else { MessageBox.Show("No result found"); LoadStudentDataGridView(); }
                
                
            }
            else
            {
                MessageBox.Show("Input the correct search function. E.g Id or Names,");
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            string id = txtId.Text;
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            int age; int.TryParse(txtAge.Text, out age);
            string gender = txtGen.Text;
            string className = txtClassName.Text;
            char grade; char.TryParse(txtGrade.Text, out grade);

            List<Student> existingStudents = StudentDB.GetStudents();
            if (existingStudents.Any(student => student.Id == id))
            {
                MessageBox.Show("Student with the same ID already exists. Please enter a unique ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Student newStudent = new Student(id, firstName, lastName, age, gender, className, grade);
            if (newStudent != null && (age != -1 || age > 70) && (grade =='A'||grade == 'B'||grade == 'C'|| grade == 'D'||grade == 'F'))
            {
                DialogResult result = MessageBox.Show("Do you want to add assignment information?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    StudentDB.saveSingleStudent(newStudent);
                    dataGridView_S.Rows.Clear();
                    LoadStudentDataGridView();
                    OpenAssignmentForm(newStudent);
                }
                else if (result == DialogResult.No)
                {
                    StudentDB.saveSingleStudent(newStudent);
                    dataGridView_S.Rows.Clear ();
                    LoadStudentDataGridView();
                    ClearData();
                }
            }
            else
            {
                MessageBox.Show("All field is required", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }    
        }
        private void btn_Update_Click(object sender, EventArgs e)
        {
            string id = txtId.Text;
            
            if (string.IsNullOrEmpty(id))
            {
                MessageBox.Show("Please provide a student ID.");
                return;
            }
            List<Student> existingStudents = StudentDB.GetStudents();

            // Find the student with the matching ID
            var studentToUpdate = existingStudents.FirstOrDefault(x => x.Id == id);
            if (studentToUpdate != null)
            {

                // Updating the student's details
                if (!string.IsNullOrEmpty(txtFirstName.Text))
                    studentToUpdate.FirstName = txtFirstName.Text;

                if (!string.IsNullOrEmpty(txtLastName.Text))
                    studentToUpdate.LastName = txtLastName.Text;

                if (!string.IsNullOrEmpty(txtAge.Text))
                int.TryParse(txtAge.Text, out int age); // Update only if valid integer
                
                if (!string.IsNullOrEmpty(txtGen.Text))
                    studentToUpdate.Gender = txtGen.Text;

                if (!string.IsNullOrEmpty(txtClassName.Text))
                    studentToUpdate.ClassName = txtClassName.Text;

                if (!string.IsNullOrEmpty(txtGrade.Text))
                    char.TryParse(txtGrade.Text, out char grade); // Update only if valid char


                // Saving the updated student list to the file
                StudentDB.saveStudent(existingStudents);

                // Refresh the grid view to reflect the changes
                LoadStudentDataGridView();
                ClearData();

                DialogResult update = MessageBox.Show("Student details updated","Alert",MessageBoxButtons.OK);
                if(update == DialogResult.OK)
                {
                    DialogResult furtherUpdate = MessageBox.Show("Do you want to update an assignment score?", 
                                                "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if(furtherUpdate == DialogResult.Yes)
                    {
                        OpenAssignmentForm(studentToUpdate);
                    }
                    else { return; }
                }
            }
            else
            {
                MessageBox.Show("Student with ID " + id + " not found");
            }
        }
        private void OpenAssignmentForm(Student student)
        {
            // Open the assignment form and pass the student's information
            AssignmentForm assignmentForm = new AssignmentForm(student);
            this.Hide(); 
            assignmentForm.ShowDialog();
        }
        private void btn_Del_Click(object sender, EventArgs e)
        {
            if (dataGridView_S.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            List<Student> students = StudentDB.GetStudents();

            foreach (DataGridViewRow row in dataGridView_S.SelectedRows)
            {
                string id = (string)row.Cells[0].Value;
                Student studentToDelete = students.FirstOrDefault(x => x.Id == id);

                if (studentToDelete != null)
                {
                    students.Remove(studentToDelete);
                }
            }

            // Saving the updated student list to the file
            StudentDB.saveStudent(students);

            // Refresh the grid view to reflect the changes
            LoadStudentDataGridView();

            MessageBox.Show("Selected rows deleted successfully.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sorry, Use the 'Add' button below");

        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sorry, Use the 'Delete' button below");
        }
        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sorry, Use the 'Update' button below");
        }
        private void exit_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView_S_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView_S_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the double-clicked cell is in the data rows (not header or empty row)
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView_S.Rows.Count - 1)
            {
                DataGridViewRow selectedRow = dataGridView_S.Rows[e.RowIndex];

                // Check if the selected row has cells
                if (selectedRow.Cells.Count > 0)
                {
                    // Populate the text fields with the data from the selected row
                    txtId.Text = GetValueFromCell(selectedRow, "Id");
                    txtFirstName.Text = GetValueFromCell(selectedRow, "FirstName");
                    txtLastName.Text = GetValueFromCell(selectedRow, "LastName");
                    txtAge.Text = GetValueFromCell(selectedRow, "Age");
                    txtGen.Text = GetValueFromCell(selectedRow, "Gender");
                    txtClassName.Text = GetValueFromCell(selectedRow, "ClassName");
                    txtGrade.Text = GetValueFromCell(selectedRow, "Grade");
                }
            }
        }

        private string GetValueFromCell(DataGridViewRow row, string columnName)
        {
            // Check if the column exists in the DataGridView
            if (dataGridView_S.Columns.Contains(columnName))
            {
                DataGridViewCell cell = row.Cells[columnName];
                if (cell.Value != null)
                {
                    return cell.Value.ToString();
                }
            }
            return string.Empty;
        }
    }
}
