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

namespace Blank_Sheet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        const string pipe = "|"; // Define a constant for the dash character
        private void btnBlankSheet_Click_1(object sender, EventArgs e)
        {
            //New Code
            // Create a message to store the CSV content
            var message = "";

            // Loop through the specified range of values
            for (int i = 0; i <= 36; i++)
            {
                for (int j = 0; j <= 36; j++)
                {
                    for (int k = 0; k <= 36; k++)
                    {
                        // Concatenate the values with pipes
                        message += i.ToString() + pipe + j.ToString() + pipe + k.ToString() + Environment.NewLine;
                    }
                }
            }

            // Generate file name with current date and time
            string currentDateTime = DateTime.Now.ToString("ddMMyyyyHHmmss");
            string fileName = $"Output_{currentDateTime}.csv";

            // Get the path for the Desktop folder
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            // Combine the desktop path with the file name
            string filePath = Path.Combine(desktopPath, fileName);

            // Write the message to the file
            File.WriteAllText(filePath, message);

            MessageBox.Show("CSV file generated successfully.");
        }
    }
}

