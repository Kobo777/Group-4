using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Record_System
{
    public partial class AddStudentForm : Form
    {
        public AddStudentForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 1️⃣ Connection string goes here:
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Integrated Security=True";

            // 2️⃣ Create an instance of your helper
            DatabaseHelper db = new DatabaseHelper(connectionString);

            // Get data from your form (these should be your TextBox names)
            string name = txtName.Text;
            string subject = txtSubject.Text;
            string marks = txtMarks.Text;
            int grade;
            try
            {
                // Attempt to parse the grade from the text box
                grade = int.Parse(txtGrade.Text);
            }
            catch (FormatException)
            {
                // Handle the case where the input is not a valid integer
                MessageBox.Show("Please enter a valid Grade");
                txtGrade.Clear(); // Optionally clear the grade textbox
                txtGrade.Focus(); // Optionally set focus back to the grade textbox
                return; // Exit the method or any further actions
            }
            // Call to insert method
            bool result = db.InsertStudent(name, grade, subject, marks);
            // Feedback
            if (result)
            {
                MessageBox.Show("Student inserted successfully.");
                // Clear the textboxes
                txtName.Clear();
                txtGrade.Clear();
                txtSubject.Clear();
                txtMarks.Clear();
                // Optional: Set focus back to the name textbox
                txtName.Focus();
            }
            else
            {
                MessageBox.Show("Error inserting student.");
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddStudentForm_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
