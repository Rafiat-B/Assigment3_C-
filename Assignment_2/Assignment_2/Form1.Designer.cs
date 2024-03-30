namespace Assignment_2
{
    partial class StudentAssignForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.operationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exit_btn = new System.Windows.Forms.Button();
            this.txtGrade = new System.Windows.Forms.TextBox();
            this.txtClassName = new System.Windows.Forms.TextBox();
            this.txtGen = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView_S = new System.Windows.Forms.DataGridView();
            this.Student_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.First_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Last_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Class_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Del = new System.Windows.Forms.Button();
            this.btn_Search = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btn_Update = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_S)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.operationsToolStripMenuItem,
            this.searchToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1304, 33);
            this.menuStrip1.TabIndex = 38;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // operationsToolStripMenuItem
            // 
            this.operationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.operationsToolStripMenuItem.Name = "operationsToolStripMenuItem";
            this.operationsToolStripMenuItem.Size = new System.Drawing.Size(54, 29);
            this.operationsToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(141, 34);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.updateToolStripMenuItem});
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(108, 29);
            this.searchToolStripMenuItem.Text = "&Operation";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.addToolStripMenuItem.Text = " &Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.deleteToolStripMenuItem.Text = " &Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.updateToolStripMenuItem.Text = "&Update";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // exit_btn
            // 
            this.exit_btn.Location = new System.Drawing.Point(1130, 635);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(137, 44);
            this.exit_btn.TabIndex = 60;
            this.exit_btn.Text = "E&xit";
            this.exit_btn.UseVisualStyleBackColor = true;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // txtGrade
            // 
            this.txtGrade.Location = new System.Drawing.Point(137, 243);
            this.txtGrade.Name = "txtGrade";
            this.txtGrade.Size = new System.Drawing.Size(230, 26);
            this.txtGrade.TabIndex = 74;
            // 
            // txtClassName
            // 
            this.txtClassName.Location = new System.Drawing.Point(886, 163);
            this.txtClassName.Name = "txtClassName";
            this.txtClassName.Size = new System.Drawing.Size(230, 26);
            this.txtClassName.TabIndex = 73;
            // 
            // txtGen
            // 
            this.txtGen.Location = new System.Drawing.Point(498, 163);
            this.txtGen.Name = "txtGen";
            this.txtGen.Size = new System.Drawing.Size(230, 26);
            this.txtGen.TabIndex = 72;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(137, 163);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(230, 26);
            this.txtAge.TabIndex = 71;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(886, 88);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(230, 26);
            this.txtLastName.TabIndex = 70;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(498, 88);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(230, 26);
            this.txtFirstName.TabIndex = 69;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(137, 88);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(230, 26);
            this.txtId.TabIndex = 68;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(21, 247);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 22);
            this.label7.TabIndex = 67;
            this.label7.Text = "Grade:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(734, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 22);
            this.label6.TabIndex = 66;
            this.label6.Text = "Class Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(385, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 22);
            this.label5.TabIndex = 65;
            this.label5.Text = "Gender:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 22);
            this.label4.TabIndex = 64;
            this.label4.Text = "Age:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(734, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 22);
            this.label3.TabIndex = 63;
            this.label3.Text = "Last Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(385, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 22);
            this.label2.TabIndex = 62;
            this.label2.Text = "First Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 22);
            this.label1.TabIndex = 61;
            this.label1.Text = "Student ID:";
            // 
            // dataGridView_S
            // 
            this.dataGridView_S.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_S.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Student_ID,
            this.First_Name,
            this.Last_Name,
            this.Age,
            this.Gender,
            this.Class_Name,
            this.Grade});
            this.dataGridView_S.Location = new System.Drawing.Point(84, 287);
            this.dataGridView_S.Name = "dataGridView_S";
            this.dataGridView_S.RowHeadersWidth = 62;
            this.dataGridView_S.RowTemplate.Height = 28;
            this.dataGridView_S.Size = new System.Drawing.Size(1113, 319);
            this.dataGridView_S.TabIndex = 75;
            this.dataGridView_S.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_S_CellContentDoubleClick);
            this.dataGridView_S.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_S_CellDoubleClick);
            // 
            // Student_ID
            // 
            this.Student_ID.HeaderText = "Student ID";
            this.Student_ID.MinimumWidth = 8;
            this.Student_ID.Name = "Student_ID";
            this.Student_ID.ReadOnly = true;
            this.Student_ID.Width = 150;
            // 
            // First_Name
            // 
            this.First_Name.HeaderText = "First Name";
            this.First_Name.MinimumWidth = 8;
            this.First_Name.Name = "First_Name";
            this.First_Name.ReadOnly = true;
            this.First_Name.Width = 150;
            // 
            // Last_Name
            // 
            this.Last_Name.HeaderText = "Last Name";
            this.Last_Name.MinimumWidth = 8;
            this.Last_Name.Name = "Last_Name";
            this.Last_Name.ReadOnly = true;
            this.Last_Name.Width = 150;
            // 
            // Age
            // 
            this.Age.HeaderText = "Age";
            this.Age.MinimumWidth = 8;
            this.Age.Name = "Age";
            this.Age.ReadOnly = true;
            this.Age.Width = 150;
            // 
            // Gender
            // 
            this.Gender.HeaderText = "Gender";
            this.Gender.MinimumWidth = 8;
            this.Gender.Name = "Gender";
            this.Gender.ReadOnly = true;
            this.Gender.Width = 150;
            // 
            // Class_Name
            // 
            this.Class_Name.HeaderText = "Class Name";
            this.Class_Name.MinimumWidth = 8;
            this.Class_Name.Name = "Class_Name";
            this.Class_Name.ReadOnly = true;
            this.Class_Name.Width = 150;
            // 
            // Grade
            // 
            this.Grade.HeaderText = "Grade";
            this.Grade.MinimumWidth = 8;
            this.Grade.Name = "Grade";
            this.Grade.ReadOnly = true;
            this.Grade.Width = 150;
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(600, 635);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(148, 45);
            this.btn_Add.TabIndex = 76;
            this.btn_Add.Text = "&Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Del
            // 
            this.btn_Del.Location = new System.Drawing.Point(931, 634);
            this.btn_Del.Name = "btn_Del";
            this.btn_Del.Size = new System.Drawing.Size(148, 45);
            this.btn_Del.TabIndex = 77;
            this.btn_Del.Text = "&Delete";
            this.btn_Del.UseVisualStyleBackColor = true;
            this.btn_Del.Click += new System.EventHandler(this.btn_Del_Click);
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(1144, 45);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(148, 31);
            this.btn_Search.TabIndex = 78;
            this.btn_Search.Text = "&Search";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.Location = new System.Drawing.Point(665, 47);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(451, 19);
            this.txtSearch.TabIndex = 79;
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(766, 635);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(148, 45);
            this.btn_Update.TabIndex = 80;
            this.btn_Update.Text = "&Update";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // StudentAssignForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1304, 690);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.btn_Del);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.dataGridView_S);
            this.Controls.Add(this.txtGrade);
            this.Controls.Add(this.txtClassName);
            this.Controls.Add(this.txtGen);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exit_btn);
            this.Controls.Add(this.menuStrip1);
            this.Name = "StudentAssignForm";
            this.Text = "Student Assignment Form";
            this.Load += new System.EventHandler(this.StudentAssignForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_S)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem operationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.Button exit_btn;
        private System.Windows.Forms.TextBox txtGrade;
        private System.Windows.Forms.TextBox txtClassName;
        private System.Windows.Forms.TextBox txtGen;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView_S;
        private System.Windows.Forms.DataGridViewTextBoxColumn Student_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn First_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Last_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Age;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn Class_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grade;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Del;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btn_Update;
    }
}

