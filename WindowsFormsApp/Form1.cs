using Services;
using System;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class EmployeesForm : Form
    {
        public EmployeesForm()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = openFileDialog.FileName;

                Data data = new Data(fileName);

                string result = data.ToString();
                StringReader stringReader = new StringReader(result);

                string line;
                
                while ((line = stringReader.ReadLine()) != null)
                {
                    string[] rowData = line.Split(", ");
                    dataGridView.Rows.Add(rowData);
                    
                }
            }
        }
    }
}
