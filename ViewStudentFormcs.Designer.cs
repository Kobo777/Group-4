namespace Student_Record_System
{
    partial class ViewStudentFormcs
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewStudentFormcs));
            this.StudentGridView = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.GradeTB = new System.Windows.Forms.TextBox();
            this.SubjectTB = new System.Windows.Forms.TextBox();
            this.MarksTB = new System.Windows.Forms.TextBox();
            this.NameTB = new System.Windows.Forms.TextBox();
            this.dataSet = new Student_Record_System.DataSet();
            this.studentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentsTableAdapter = new Student_Record_System.DataSetTableAdapters.StudentsTableAdapter();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Pdfbutton = new System.Windows.Forms.Button();
            this.Viewbtn = new System.Windows.Forms.Button();
            this.Addbtn = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.StudentGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // StudentGridView
            // 
            this.StudentGridView.BackgroundColor = System.Drawing.Color.White;
            this.StudentGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.StudentGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentGridView.Location = new System.Drawing.Point(97, 174);
            this.StudentGridView.Name = "StudentGridView";
            this.StudentGridView.Size = new System.Drawing.Size(501, 178);
            this.StudentGridView.TabIndex = 21;
            this.StudentGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.studentGridView_CellContentClick_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("MS Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(376, 454);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 29;
            this.label4.Text = "Marks";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("MS Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(359, 392);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 15);
            this.label3.TabIndex = 28;
            this.label3.Text = "Subject";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("MS Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(61, 454);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 27;
            this.label2.Text = "Grade";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("MS Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(73, 390);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 15);
            this.label1.TabIndex = 26;
            this.label1.Text = "Name";
            // 
            // GradeTB
            // 
            this.GradeTB.BackColor = System.Drawing.Color.Aqua;
            this.GradeTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.GradeTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GradeTB.Location = new System.Drawing.Point(111, 448);
            this.GradeTB.Name = "GradeTB";
            this.GradeTB.Size = new System.Drawing.Size(210, 26);
            this.GradeTB.TabIndex = 25;
            // 
            // SubjectTB
            // 
            this.SubjectTB.BackColor = System.Drawing.Color.Aqua;
            this.SubjectTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubjectTB.Location = new System.Drawing.Point(428, 386);
            this.SubjectTB.Name = "SubjectTB";
            this.SubjectTB.Size = new System.Drawing.Size(210, 26);
            this.SubjectTB.TabIndex = 24;
            // 
            // MarksTB
            // 
            this.MarksTB.BackColor = System.Drawing.Color.Aqua;
            this.MarksTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MarksTB.Location = new System.Drawing.Point(428, 448);
            this.MarksTB.Name = "MarksTB";
            this.MarksTB.Size = new System.Drawing.Size(210, 26);
            this.MarksTB.TabIndex = 23;
            // 
            // NameTB
            // 
            this.NameTB.BackColor = System.Drawing.Color.Aqua;
            this.NameTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NameTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameTB.Location = new System.Drawing.Point(114, 385);
            this.NameTB.Name = "NameTB";
            this.NameTB.Size = new System.Drawing.Size(210, 26);
            this.NameTB.TabIndex = 22;
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "DataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentsBindingSource
            // 
            this.studentsBindingSource.DataMember = "Students";
            this.studentsBindingSource.DataSource = this.dataSet;
            // 
            // studentsTableAdapter
            // 
            this.studentsTableAdapter.ClearBeforeFill = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Blue;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.pictureBox5);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(-2, -2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(697, 35);
            this.panel2.TabIndex = 41;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.BackgroundImage = global::Student_Record_System.Properties.Resources.off2;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(662, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(26, 23);
            this.button1.TabIndex = 11;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::Student_Record_System.Properties.Resources.Ialibu_Secondary_bgr;
            this.pictureBox5.Location = new System.Drawing.Point(9, 5);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(33, 28);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 10;
            this.pictureBox5.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(47, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 21);
            this.label5.TabIndex = 10;
            this.label5.Text = "View Students";
            // 
            // Pdfbutton
            // 
            this.Pdfbutton.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.Pdfbutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Pdfbutton.BackgroundImage")));
            this.Pdfbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Pdfbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Pdfbutton.Font = new System.Drawing.Font("MS Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pdfbutton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Pdfbutton.Location = new System.Drawing.Point(494, 109);
            this.Pdfbutton.Name = "Pdfbutton";
            this.Pdfbutton.Size = new System.Drawing.Size(104, 34);
            this.Pdfbutton.TabIndex = 34;
            this.Pdfbutton.Text = "PDF Download";
            this.Pdfbutton.UseVisualStyleBackColor = true;
            this.Pdfbutton.Click += new System.EventHandler(this.Pdfbutton_Click);
            // 
            // Viewbtn
            // 
            this.Viewbtn.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.Viewbtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Viewbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Viewbtn.BackgroundImage")));
            this.Viewbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Viewbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Viewbtn.Font = new System.Drawing.Font("MS Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Viewbtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Viewbtn.Location = new System.Drawing.Point(81, 105);
            this.Viewbtn.Name = "Viewbtn";
            this.Viewbtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Viewbtn.Size = new System.Drawing.Size(105, 38);
            this.Viewbtn.TabIndex = 33;
            this.Viewbtn.Text = "VIEW";
            this.Viewbtn.UseVisualStyleBackColor = false;
            this.Viewbtn.Click += new System.EventHandler(this.Viewbtn_Click);
            // 
            // Addbtn
            // 
            this.Addbtn.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.Addbtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Addbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Addbtn.BackgroundImage")));
            this.Addbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Addbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Addbtn.Font = new System.Drawing.Font("MS Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Addbtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Addbtn.Location = new System.Drawing.Point(337, 109);
            this.Addbtn.Name = "Addbtn";
            this.Addbtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Addbtn.Size = new System.Drawing.Size(105, 38);
            this.Addbtn.TabIndex = 32;
            this.Addbtn.Text = "ADD";
            this.Addbtn.UseVisualStyleBackColor = false;
            this.Addbtn.Click += new System.EventHandler(this.Addbtn_Click_1);
            // 
            // btnDelete
            // 
            this.btnDelete.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnDelete.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDelete.BackgroundImage")));
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Font = new System.Drawing.Font("MS Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnDelete.Location = new System.Drawing.Point(205, 105);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnDelete.Size = new System.Drawing.Size(105, 38);
            this.btnDelete.TabIndex = 31;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnUpdate.BackgroundImage = global::Student_Record_System.Properties.Resources.Tech_buttons_collection;
            this.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnUpdate.Location = new System.Drawing.Point(539, 491);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnUpdate.Size = new System.Drawing.Size(99, 45);
            this.btnUpdate.TabIndex = 30;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Student_Record_System.Properties.Resources._360_F_372247876_QXHo9HtYOZUHUKAVHbWDXP4lte5eZQmp___Copy;
            this.pictureBox1.Location = new System.Drawing.Point(76, 153);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(548, 217);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::Student_Record_System.Properties.Resources.database_table_bgr1;
            this.pictureBox2.Location = new System.Drawing.Point(7, 39);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(78, 61);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("MS Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label6.Location = new System.Drawing.Point(94, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(476, 13);
            this.label6.TabIndex = 42;
            this.label6.Text = "Here you can add, view, or delete a student\'s from the database. To";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("MS Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label7.Location = new System.Drawing.Point(94, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(336, 13);
            this.label7.TabIndex = 43;
            this.label7.Text = "download a PDF press the \'PDF Download\' button.";
            // 
            // ViewStudentFormcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Student_Record_System.Properties.Resources.something;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(690, 607);
            this.ControlBox = false;
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.NameTB);
            this.Controls.Add(this.MarksTB);
            this.Controls.Add(this.SubjectTB);
            this.Controls.Add(this.GradeTB);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Pdfbutton);
            this.Controls.Add(this.Viewbtn);
            this.Controls.Add(this.Addbtn);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StudentGridView);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ViewStudentFormcs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewStudentFormcs";
            ((System.ComponentModel.ISupportInitialize)(this.StudentGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView StudentGridView;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox GradeTB;
        private System.Windows.Forms.TextBox SubjectTB;
        private System.Windows.Forms.TextBox MarksTB;
        private System.Windows.Forms.TextBox NameTB;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button Addbtn;
        private System.Windows.Forms.Button Viewbtn;
        private DataSet dataSet;
        private System.Windows.Forms.BindingSource studentsBindingSource;
        private DataSetTableAdapters.StudentsTableAdapter studentsTableAdapter;
        private System.Windows.Forms.Button Pdfbutton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}