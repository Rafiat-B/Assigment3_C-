namespace Assignment_2
{
    partial class AssignmentForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView_A = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtAssId = new System.Windows.Forms.TextBox();
            this.txtMax = new System.Windows.Forms.TextBox();
            this.txtScore = new System.Windows.Forms.TextBox();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Del = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_A)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 25);
            this.label1.TabIndex = 0;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(92, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Assignment Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(92, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Score:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(92, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Max Score:";
            // 
            // dataGridView_A
            // 
            this.dataGridView_A.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_A.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridView_A.Location = new System.Drawing.Point(35, 233);
            this.dataGridView_A.Name = "dataGridView_A";
            this.dataGridView_A.RowHeadersWidth = 62;
            this.dataGridView_A.RowTemplate.Height = 28;
            this.dataGridView_A.Size = new System.Drawing.Size(710, 182);
            this.dataGridView_A.TabIndex = 4;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Assignment";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Score Obtained";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Maximum Score";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 150;
            // 
            // txtAssId
            // 
            this.txtAssId.Location = new System.Drawing.Point(333, 41);
            this.txtAssId.Name = "txtAssId";
            this.txtAssId.Size = new System.Drawing.Size(171, 26);
            this.txtAssId.TabIndex = 5;
            // 
            // txtMax
            // 
            this.txtMax.Location = new System.Drawing.Point(333, 161);
            this.txtMax.Name = "txtMax";
            this.txtMax.Size = new System.Drawing.Size(171, 26);
            this.txtMax.TabIndex = 7;
            // 
            // txtScore
            // 
            this.txtScore.Location = new System.Drawing.Point(333, 100);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(171, 26);
            this.txtScore.TabIndex = 8;
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(401, 486);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(154, 44);
            this.btn_Add.TabIndex = 9;
            this.btn_Add.Text = "&Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Del
            // 
            this.btn_Del.Location = new System.Drawing.Point(576, 486);
            this.btn_Del.Name = "btn_Del";
            this.btn_Del.Size = new System.Drawing.Size(154, 44);
            this.btn_Del.TabIndex = 10;
            this.btn_Del.Text = "&Delete";
            this.btn_Del.UseVisualStyleBackColor = true;
            this.btn_Del.Click += new System.EventHandler(this.btn_Del_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(745, 486);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(154, 44);
            this.btn_Cancel.TabIndex = 11;
            this.btn_Cancel.Text = "&Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // AssignmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 542);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Del);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.txtMax);
            this.Controls.Add(this.txtAssId);
            this.Controls.Add(this.dataGridView_A);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AssignmentForm";
            this.Text = "AssignmentForm";
            this.Load += new System.EventHandler(this.AssignmentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_A)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView_A;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.TextBox txtAssId;
        private System.Windows.Forms.TextBox txtMax;
        private System.Windows.Forms.TextBox txtScore;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Del;
        private System.Windows.Forms.Button btn_Cancel;
    }
}