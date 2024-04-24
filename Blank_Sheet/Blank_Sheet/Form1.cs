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
                eventArgs.Result = fileName;
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
                    // Extract the file name from the full path
                    string fileName = Path.GetFileName(eventArgs.Result.ToString());
                    // Show completion message
                    MessageBox.Show("Blank file has been generated successfully.\nFile Name : " + fileName);
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
                    var x = AllData[i + 1] + Space + AllData[i + 2] + Space + AllData[i + 3];
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

            // Disable the button to prevent multiple clicks
            btnprocess.Enabled = false;

            // Create a BackgroundWorker instance
            BackgroundWorker worker = new BackgroundWorker();

            //worker.DoWork += (senderObj, eventArgs) =>
            //{
            //    // Get the first worksheet in the CSV file
            //    var message = new StringBuilder();
            //    var TargetcsvData = File.ReadAllLines(SelectedCSVFilePath);

            //    foreach (var row in TargetcsvData)
            //    {
            //        var values = row.Split(',');

            //        if (values.Length > 0)
            //        {

            //            // Check if the first cell is not empty
            //            if (!string.IsNullOrWhiteSpace(values[0]))
            //            {
            //                // Check if dictionary contains the value in the first cell
            //                var key = values[0].Trim();
            //                if (Dict.ContainsKey(key))
            //                {
            //                    message.Append(values[0]); // Add the value

            //                    // Check if there are additional values in the row
            //                    if (values.Length > 1)
            //                    {
            //                        // Append comma and additional data if present
            //                        message.Append("," + string.Join(",", values.Skip(1)));

            //                    }

            //                    // If there are multiple dictionary values, append them with a pipe symbol
            //                    var dictValues = Dict[key].Split(',');

            //                    if (dictValues.Count() > 0)
            //                    {
            //                        var value = Dict[key].Split('|');
            //                        if (value.Count() > 1)
            //                        {
            //                            message.Append(" | " + value.FirstOrDefault());
            //                        }
            //                        else
            //                            message.Append("," + Dict[key]);

            //                        Dict[key] += $" | {value.FirstOrDefault()}";
            //                    }
            //                }
            //                else
            //                {
            //                    // If not found in the dictionary, add the row as it is
            //                    message.Append(row);
            //                }
            //            }
            //            else
            //            {
            //                // If the first cell is empty, add the row as it is
            //                message.Append(row);
            //            }
            //        }

            //        message.AppendLine(); // Add a new line
            //    }

            //    File.WriteAllText(SelectedCSVFilePath, message.ToString());
            //};

            // Worker method to perform the processing
            worker.DoWork += (senderObj, eventArgs) =>
            {
                // Get the first worksheet in the CSV file
                var TargetcsvData = File.ReadAllLines(SelectedCSVFilePath);
                var updatedRows = new List<string>();

                foreach (var row in TargetcsvData)
                {
                    var values = row.Split(',');
                    var firstValue = values.FirstOrDefault();
                    bool isCommaPresent = row.Contains(',');

                    if (Dict.ContainsKey(firstValue))
                    {
                        if (isCommaPresent)
                        {
                            updatedRows.Add(firstValue + "," + values[1] + " | " + Dict[firstValue]);
                        }
                        else
                        {
                            updatedRows.Add(firstValue + "," + Dict[firstValue]);
                        }
                    }
                    else
                    {
                        updatedRows.Add(row); // Keep the original row if key not found in dictionary
                    }
                }

                File.WriteAllLines(SelectedCSVFilePath, updatedRows);
            };



            // Worker completed event to handle completion
            worker.RunWorkerCompleted += (senderObj, eventArgs) =>
            {
                // Hide the progress bar
                progressBar1.Visible = false;

                // Enable the button
                btnprocess.Enabled = true;

                // Show completion message
                MessageBox.Show("CSV file updated successfully.");

                // Show message indicating CSV file is being opened
                MessageBox.Show("Opening CSV file. Please wait...");

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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}


