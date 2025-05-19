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
    public partial class AddStudent : Form
    {
        public AddStudent()
        {
            InitializeComponent();
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // 1️⃣ Connection string goes here:
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Integrated Security=True";

            // 2️⃣ Create an instance of your helper
            DatabaseHelper db = new DatabaseHelper(connectionString);

            // 3️⃣ Get data from your form (these should be your TextBox names)
            string name = txtName.Text;
            string subject = txtSubject.Text;
            txtGrade.Items.AddRange(new object[] { "9", "10", "11", "12" });
            txtMarks.Items.AddRange(new object[] { "A", "B", "C", "D", "F" });

            // 4️⃣ Call insert
            bool result = db.InsertStudent(name, grade, subject, marks);

            // 5️⃣ Feedback
            if (result)
            {
                MessageBox.Show("Student inserted successfully!");
                //  Clear the textboxes
                txtName.Clear();
                txtGrade.Clear();
                txtSubject.Clear();
                txtMarks.Clear();

                // Optional: Set focus back to the first textbox
                txtName.Focus();
            }
            else
            {
                MessageBox.Show("Something went wrong.");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            int grade = int.Parse(txtGrade.Text);
            string subject = txtSubject.Text;
            string marks = txtMarks.Text;

            MessageBox.Show($"Saved: {name}, {grade}, {subject}, {marks}");
        }

       
    }
}
