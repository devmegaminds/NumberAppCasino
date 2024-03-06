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
        Dictionary<string, string> Dict = new Dictionary<string, string>();
        public Form1()
        {
            InitializeComponent();
        }
        const string Space = " "; // Define a constant for the dash character
        private void btnBlankSheet_Click_1(object sender, EventArgs e)
        {
            //New Code
            step1progressBar.Visible = true;

            // Disable the button to prevent multiple clicks
            btnBlankSheet.Enabled = false;

            // Create a BackgroundWorker instance
            BackgroundWorker worker = new BackgroundWorker();

       

            // Worker method to perform the processing
            worker.DoWork += (senderObj, eventArgs) =>
            {
                // Create a message to store the CSV content
                var message = "";

                // Loop through the specified range of values
                for (int i = 0; i <= 36; i++)
                {
                    for (int j = 0; j <= 36; j++)
                    {
                        for (int k = 0; k <= 36; k++)
                        {
                            // Concatenate the values with Space
                            message += i.ToString() + Space + j.ToString() + Space + k.ToString() + Environment.NewLine;
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

                // Return the result if needed
                eventArgs.Result = filePath;
            };

            // Worker completed event to handle completion
            worker.RunWorkerCompleted += (senderObj, eventArgs) =>
            {
                // Hide the progress bar
                step1progressBar.Visible = false;

                // Enable the button
                btnBlankSheet.Enabled = true;

                if (eventArgs.Error != null)
                {
                    // Handle any errors
                    MessageBox.Show("Error occurred: " + eventArgs.Error.Message);
                }
                else
                {
                    // Show completion message
                    MessageBox.Show("Blank file has been generated successfully.\nFile Name : " + eventArgs.Result.ToString());
                }
            };

            // Start the background worker
            worker.RunWorkerAsync();
        }

        private void btnopenyourdesktop_Click(object sender, EventArgs e)
        {
            // Get the path for the Desktop folder
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            // Open the folder in File Explorer
            System.Diagnostics.Process.Start("explorer.exe", desktopPath);
        }
    }
}


