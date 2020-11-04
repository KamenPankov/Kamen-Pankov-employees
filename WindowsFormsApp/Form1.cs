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
                int row = 0;
                while ((line = stringReader.ReadLine()) != null)
                {
                    string[] rowData = line.Split(", ");
                    for (int i = 0; i < rowData.Length; i++)
                    {

                        dataGridView.Rows[row].Cells[i].Value = rowData[i];
                    }

                    row++;
                }
            }
        }
    }
}
