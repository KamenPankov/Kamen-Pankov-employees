namespace WindowsFormsApp
{
    partial class EmployeesForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnStart = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.EmployeeID_1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeID_2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProjectID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DaysWorked = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(702, 553);
            this.btnStart.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(86, 31);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            this.openFileDialog.Filter = "\"txt files (*.txt)|*.txt|All files (*.*)|*.*\"";
            this.openFileDialog.InitialDirectory = "C:\\";
            // 
            // EmployeeID_1
            // 
            this.EmployeeID_1.HeaderText = "Employee ID #1";
            this.EmployeeID_1.MinimumWidth = 6;
            this.EmployeeID_1.Name = "EmployeeID_1";
            this.EmployeeID_1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.EmployeeID_1.Width = 150;
            // 
            // EmployeeID_2
            // 
            this.EmployeeID_2.HeaderText = "Employee ID #2";
            this.EmployeeID_2.MinimumWidth = 6;
            this.EmployeeID_2.Name = "EmployeeID_2";
            this.EmployeeID_2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.EmployeeID_2.Width = 150;
            // 
            // ProjectID
            // 
            this.ProjectID.HeaderText = "Project ID";
            this.ProjectID.MinimumWidth = 6;
            this.ProjectID.Name = "ProjectID";
            this.ProjectID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ProjectID.Width = 150;
            // 
            // DaysWorked
            // 
            this.DaysWorked.HeaderText = "DaysWorked";
            this.DaysWorked.MinimumWidth = 6;
            this.DaysWorked.Name = "DaysWorked";
            this.DaysWorked.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DaysWorked.Width = 150;
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EmployeeID_1,
            this.EmployeeID_2,
            this.ProjectID,
            this.DaysWorked});
            this.dataGridView.Location = new System.Drawing.Point(0, 0);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.Size = new System.Drawing.Size(693, 515);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.Text = "dataGridView1";
            // 
            // EmployeesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 600);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.dataGridView);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "EmployeesForm";
            this.Text = "Employees";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeID_1;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeID_2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProjectID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DaysWorked;
    }
}

