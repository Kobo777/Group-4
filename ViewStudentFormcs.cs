using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;


namespace Student_Record_System
{
    public partial class ViewStudentFormcs : Form
    {
        public ViewStudentFormcs()
        {
            InitializeComponent();
        }


        private void Viewbtn_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Integrated Security=True";
            DatabaseHelper db = new DatabaseHelper(connectionString);

            // Fetch all student data
            DataTable studentsTable = db.GetAllStudents();

            if (studentsTable != null && studentsTable.Rows.Count > 0)
            {
                // Bind the DataTable to the DataGridView
                StudentGridView.DataSource = studentsTable;

                // Ensure the 'Id' column is visible in the DataGridView
                StudentGridView.Columns["Id"].Visible = true;  // Make sure 'Id' column is visible
                StudentGridView.Columns["Id"].HeaderText = "Student ID";  // Optional: Rename the 'Id' column header

                // Optionally, you can set other properties like column width
                StudentGridView.Columns["Id"].Width = 80;  // Set width of the 'Id' column

                // Adjust other columns if needed, for example:
                StudentGridView.Columns["Name"].HeaderText = "Student Name"; // Rename 'Name' column header
                StudentGridView.Columns["Grade"].HeaderText = "Grade";  // Rename 'Grade' column header
                StudentGridView.Columns["Subject"].HeaderText = "Subject";  // Rename 'Subject' column header
                StudentGridView.Columns["Marks"].HeaderText = "Marks";  // Rename 'Marks' column header

                // Optional: Hide columns that are not needed (if any)
                // For example, if you want to hide a column:
                // studentGridView.Columns["SomeOtherColumn"].Visible = false;
            }
            else
            {
                MessageBox.Show("Failed to load student data.");

            }
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (btnUpdate.Tag == null)
            {
                MessageBox.Show("Please select a record to update.");
                return;
            }

            int studentId = Convert.ToInt32(btnUpdate.Tag);
            string name = NameTB.Text.Trim();
            string subject = SubjectTB.Text.Trim();
            string marks = MarksTB.Text.Trim();

            // Declare grade outside the if statement
            int grade;
            // Convert grade to int safely
            if (!int.TryParse(GradeTB.Text, out grade))
            {
                MessageBox.Show("Please enter a valid grade number.");
                return;
            }

            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Integrated Security=True";
            DatabaseHelper db = new DatabaseHelper(connectionString);

            bool success = db.UpdateStudent(studentId, name, grade, subject, marks);

            if (success)
            {
                MessageBox.Show("Student record updated successfully.");
                Viewbtn.PerformClick(); // Refresh the grid view
            }
            else
            {
                MessageBox.Show("Failed to update student record.");
            }
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Check if any row is selected in the DataGridView
            if (StudentGridView.SelectedRows.Count > 0)
            {
                // Get the student ID and name from the selected row
                int selectedId = Convert.ToInt32(StudentGridView.SelectedRows[0].Cells["Id"].Value);
                string selectedName = StudentGridView.SelectedRows[0].Cells["Name"].Value.ToString();

                // Ask for confirmation before deleting the student
                DialogResult result = MessageBox.Show($"Are you sure you want to delete the student {selectedName}?", "Delete Confirmation", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Integrated Security=True";
                    DatabaseHelper db = new DatabaseHelper(connectionString);

                    try
                    {
                        // Call the method to delete the student by ID
                        bool success = db.DeleteStudentById(selectedId); // Make sure this method exists in DatabaseHelper

                        if (success)
                        {
                            // Remove the selected row from the DataGridView
                            StudentGridView.Rows.RemoveAt(StudentGridView.SelectedRows[0].Index);
                            MessageBox.Show("Student deleted successfully.");
                        }
                        else
                        {
                            MessageBox.Show("Failed to delete the student.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error deleting student: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a student to delete.");
            }
        }

        private void Addbtn_Click_1(object sender, EventArgs e)
        {
            AddStudentForm add = new AddStudentForm();
            add.ShowDialog();
        }

        private void studentGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Make sure it's not the header row
            {
                DataGridViewRow row = StudentGridView.Rows[e.RowIndex];

                // Set the values to the corresponding TextBoxes
                NameTB.Text = row.Cells["Name"].Value.ToString();
                GradeTB.Text = row.Cells["Grade"].Value.ToString();
                SubjectTB.Text = row.Cells["Subject"].Value.ToString();
                MarksTB.Text = row.Cells["Marks"].Value.ToString();

                // Store the ID in a hidden field or Tag property for later update
                btnUpdate.Tag = row.Cells["Id"].Value;
            }
        }

        private void Pdfbutton_Click(object sender, EventArgs e)
        {
            // Create the FolderBrowserDialog to prompt user for folder selection
            using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
            {
                folderDialog.Description = "Select the folder to save the PDF file";
                folderDialog.RootFolder = Environment.SpecialFolder.MyComputer;

                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedFolderPath = folderDialog.SelectedPath;

                    if (!string.IsNullOrEmpty(selectedFolderPath))
                    {
                        string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Integrated Security=True;";
                        DatabaseHelper db = new DatabaseHelper(connectionString);
                        DataTable studentsTable = db.GetAllStudents();

                        if (studentsTable != null && studentsTable.Rows.Count > 0)
                        {
                            // Initialize the PDF document
                            Document document = new Document(PageSize.A4);
                            string filePath = System.IO.Path.Combine(selectedFolderPath, "StudentRecords.pdf");

                            try
                            {
                                // Create the PDF writer
                                PdfWriter.GetInstance(document, new System.IO.FileStream(filePath, System.IO.FileMode.Create));
                                // Open the document for writing
                                document.Open();

                                // Add a title
                                iTextSharp.text.Font titleFont = FontFactory.GetFont("Arial", 18, iTextSharp.text.Font.NORMAL);
                                Paragraph title = new Paragraph("Student Records", titleFont)
                                {
                                    Alignment = Element.ALIGN_CENTER
                                };
                                document.Add(title);
                                document.Add(new Paragraph("\n")); // Add some spacing

                                // Create a table with 5 columns
                                PdfPTable table = new PdfPTable(5);
                                table.WidthPercentage = 100; // Optional: make it span full width
                                table.SetWidths(new float[] { 1f, 3f, 1f, 2f, 2f }); // Column widths

                                // Add headers
                                table.AddCell("ID");
                                table.AddCell("Name");
                                table.AddCell("Grade");
                                table.AddCell("Subject");
                                table.AddCell("Marks");

                                // Loop through data and add rows
                                foreach (DataRow row in studentsTable.Rows)
                                {
                                    table.AddCell(row["Id"].ToString());
                                    table.AddCell(row["Name"].ToString());
                                    table.AddCell(row["Grade"].ToString());
                                    table.AddCell(row["Subject"].ToString());
                                    table.AddCell(row["Marks"].ToString());
                                }

                                // Add table to document
                                document.Add(table);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Error generating PDF: " + ex.Message);
                            }
                            finally
                            {
                                // Close the document
                                if (document.IsOpen())
                                    document.Close();
                                MessageBox.Show("PDF generated successfully at:\n" + filePath);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Failed to load student data.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("No folder selected. PDF generation canceled.");
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
