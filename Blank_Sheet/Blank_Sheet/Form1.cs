using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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

        private void btnopenyourdesktop_Click(object sender, EventArgs e)
        {
            // Get the path for the Desktop folder
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            // Open the folder in File Explorer
            System.Diagnostics.Process.Start("explorer.exe", desktopPath);
        }

        private void btnuploadimagedata_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "CSV Files|*.csv";
            openFileDialog.Title = "Select a CSV File";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                var csvData = File.ReadAllLines(openFileDialog.FileName);

                // Convert the CSV data to a list of integers
                List<int[]> integerList = new List<int[]>();

                Dict.Clear();

                foreach (var row in csvData)
                {
                    // Split the row into individual values
                    var values = row.Split(',');

                    // Convert each value to an integer, or use 0 if the value is empty
                    var integers = values.Select(v => string.IsNullOrEmpty(v) ? -1 : int.Parse(v)).ToArray();

                    // Add the array of integers to the list
                    integerList.Add(integers);
                }

                List<int> AllData = integerList.SelectMany(arr => arr).Where(num => num != -1).ToList();

                // Display the list of integers in a message box
                var message = "";
                for (int i = 0; i < AllData.Count() - 3; i++)
                {
                    var x = AllData[i + 1] + pipe + AllData[i + 2] + pipe + AllData[i + 3];
                    if (Dict.ContainsKey(x))
                    {
                        Dict[x] += "| " + AllData[i];
                    }
                    else
                    {
                        Dict.Add(x, AllData[i].ToString());
                    }
                }

                MessageBox.Show("CSV File Uploaded successfully.");
                // Set the label text to the path of the CSV file
                lbluploadimagedatapath.Text = openFileDialog.FileName;

            }
        }
        private string SelectedCSVFilePath;
        private void btnuploaddatacsvfile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "CSV Files|*.csv";
            openFileDialog.Title = "Select a CSV File";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                SelectedCSVFilePath = openFileDialog.FileName; // Store the selected file path in the class-level variable
                var csvData = File.ReadAllLines(SelectedCSVFilePath);
            }
            MessageBox.Show("CSV File Uploaded successfully.");
            // Set the label text to the path of the CSV file
            lbluploaddatacsvfilepath.Text = openFileDialog.FileName;
        }

        private void btnprocess_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(SelectedCSVFilePath))
            {
                MessageBox.Show("Please select a CSV file first.");
                return;
            }

            // Show the progress bar
            progressBar1.Visible = true;

            // Create a BackgroundWorker instance
            BackgroundWorker worker = new BackgroundWorker();

            // Worker method to perform the processing
            worker.DoWork += (senderObj, eventArgs) =>
            {
                // Get the first worksheet in the CSV file
                var message = "";
                var TargetcsvData = File.ReadAllLines(SelectedCSVFilePath);

                foreach (var row in TargetcsvData)
                {
                    var values = row.Split(',').FirstOrDefault();
                    bool IsCommanPresent = row.Contains(',');
                    message += values;
                    if (Dict.ContainsKey(values))
                    {
                        if (IsCommanPresent)
                        {
                            message += "," + row.Split(',')[1] + " / " + Dict[values];
                        }
                        else
                        {
                            message += "," + Dict[values];
                        }
                    }
                    message += "\n";
                }

                File.WriteAllText(SelectedCSVFilePath, message);

                // Return the result if needed
                eventArgs.Result = message;
            };

            // Worker completed event to handle completion
            worker.RunWorkerCompleted += (senderObj, eventArgs) =>
            {
                // Hide the progress bar
                progressBar1.Visible = false;

                // Show completion message
                MessageBox.Show("Excel file updated successfully.");
                MessageBox.Show(eventArgs.Result.ToString());

                // Open the processed file
                Process.Start(SelectedCSVFilePath);
            };

            // Start the background worker
            worker.RunWorkerAsync();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Display the message when the icon is clicked
            MessageBox.Show("This file must be a which you have created in step-1");
        }
    }
}


