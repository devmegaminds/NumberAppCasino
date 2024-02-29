using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NUmberapp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        const string pipe = "|"; // Define a constant for the dash character
        private void btnBlankSheet_Click(object sender, EventArgs e)
        {
            // Create a SaveFileDialog instance
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            // Set the default file name and extension
            saveFileDialog1.FileName = "Untitled.csv";
            saveFileDialog1.DefaultExt = ".csv";

            // Set the initial directory to the Desktop
            saveFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            // Display the SaveFileDialog and check if the user clicked the OK button
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                var message = "";

                // Loop through the specified range of values
                for (int i = 0; i <= 36; i++)
                {
                    for (int j = 0; j <= 36; j++)
                    {
                        for (int k = 0; k <= 36; k++)
                        {
                            // Concatenate the values with dashes
                            message += i.ToString() + pipe + j.ToString() + pipe + k.ToString() + "\n";

                            //message += $"{i.ToString()}-{j.ToString()}-{k.ToString()}\n";
                        }
                    }
                }

                // Get the full file path from the SaveFileDialog
                string excelFilePath = saveFileDialog1.FileName;

                // Write the message to the selected file
                File.WriteAllText(excelFilePath, message);

                MessageBox.Show("Excel sheet generated successfully.");
            }
        }
    }
}