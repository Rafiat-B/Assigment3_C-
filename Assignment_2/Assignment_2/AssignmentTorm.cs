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
    public partial class AssignmentForm : Form
    {
        //Creating a reference to original form so we go back to initial form opend
        private Student student;
        StudentAssignForm studentAssignForm;
        AssignmentDB assignmentDB = new AssignmentDB();
        public AssignmentForm(Student student)
        {
            InitializeComponent();
            studentAssignForm = new StudentAssignForm();
            this.student = student;
            label1.Text = "Assignment for:" + student.FirstName + " " +student.LastName;
        }

        //public AssignmentForm()
        //{
        //}
        private void LoadDataGridView()
        {
            dataGridView_A.Rows.Clear();
            foreach (Assignments a in AssignmentDB.GetAll())
            {
                dataGridView_A.Rows.Add(a.AssignmentId, a.ScoreObtained, a.MaxScore);
            }
        }
        private void btn_Add_Click(object sender, EventArgs e)
        {
            string assignmentid = txtAssId.Text;
            double scoreObtained; double.TryParse(txtScore.Text, out scoreObtained);
            double maxScore; double.TryParse(txtMax.Text, out maxScore);

            if(!string.IsNullOrEmpty(assignmentid) && (scoreObtained > -1 && scoreObtained < maxScore) && (maxScore <= 100))
            {
                Assignments assign = new Assignments(assignmentid,scoreObtained, maxScore);
                AssignmentDB.AddScore(assign);
                LoadDataGridView();
            }
            else
            {
                MessageBox.Show("Please enter a valid assignment ID and maximum score.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //MessageBox.Show("OOPS! Sorry, still getting modified. Check back soon","Information",MessageBoxButtons.OK,MessageBoxIcon.Hand);
        }

        private void btn_Del_Click(object sender, EventArgs e)
        {
            MessageBox.Show("OOPS! Sorry, still getting modified. Check back soon", "Information", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
            studentAssignForm.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AssignmentForm_Load(object sender, EventArgs e)
        {
            LoadDataGridView();
        }
    }
}
