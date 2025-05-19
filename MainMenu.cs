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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void btnview_Click(object sender, EventArgs e)
        {
            ViewStudentFormcs viewRecord = new ViewStudentFormcs();
            viewRecord.Show();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddStudentForm add = new AddStudentForm();
            add.ShowDialog();
        }


        private void btnLogout_Click_1(object sender, EventArgs e)
        {
            LoginInterface form = new LoginInterface();
            this.Close();
            form.ShowDialog();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
            
        }
    }
}
