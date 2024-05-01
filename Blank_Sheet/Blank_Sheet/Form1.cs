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
        Dictionary<string, string> dataColumn = new Dictionary<string, string>();
        private string selectedCSVFilePath;

        public Form1()
        {
            InitializeComponent();
        }
        const string Space = " "; // Define a constant for the Spach character

        #region Createblanksheet
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
                // Create a Series to store the CSV content
                var series = "";

                // Loop through the specified range of values
                for (int outerSeries = 0; outerSeries <= 36; outerSeries++)
                {
                    for (int middleSeries = 0; middleSeries <= 36; middleSeries++)
                    {
                        for (int innerSeries = 0; innerSeries <= 36; innerSeries++)
                        {
                            // Concatenate the values with Space
                            series += outerSeries.ToString() + Space + middleSeries.ToString() + Space + innerSeries.ToString() + Environment.NewLine;
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
                File.WriteAllText(filePath, series);

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
        #endregion

        #region OpenyourDesktop
        private void btnOpenyourDesktop_Click(object sender, EventArgs e)
        {
            // Get the path for the Desktop folder
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            // Open the folder in File Explorer
            System.Diagnostics.Process.Start("explorer.exe", desktopPath);
        }
        #endregion

        #region UploadImageData
        private void btnUploadImageData_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "CSV Files|*.csv";
            openFileDialog.Title = "Select a CSV File";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                var csvData = File.ReadAllLines(openFileDialog.FileName);

                // Convert the CSV data to a list of integers
                List<int[]> CSVintegerList = new List<int[]>();

                dataColumn.Clear();

                foreach (var row in csvData)
                {
                    // Split the row into individual values
                    var values = row.Split(',');

                    // Convert each value to an integer, or use 0 if the value is empty
                    var integers = values.Select(v => string.IsNullOrEmpty(v) ? -1 : int.Parse(v)).ToArray();

                    // Add the array of integers to the list
                    CSVintegerList.Add(integers);
                }

                List<int> AllData = CSVintegerList.SelectMany(arr => arr).Where(num => num != -1).ToList();

                // Display the list of integers in a message box
                //var message = "";

                for (int count = 0; count < AllData.Count() - 3; count++)
                {
                    var index = AllData[count + 1] + Space + AllData[count + 2] + Space + AllData[count + 3];
                    if (dataColumn.ContainsKey(index))
                    {
                        dataColumn[index] += "| " + AllData[count];
                    }
                    else
                    {
                        dataColumn.Add(index, AllData[count].ToString());
                    }
                }

                MessageBox.Show("CSV File Uploaded successfully.");
                // Set the label text to the path of the CSV file
                lbluploadimagedatapath.Text = openFileDialog.FileName;

            }

        }
        #endregion

        #region UploadDataCSVFile
        private void btnUploadDataCSVFile_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "CSV Files|*.csv";
            openFileDialog.Title = "Select a CSV File";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                selectedCSVFilePath = openFileDialog.FileName; // Store the selected file path in the class-level variable
                var csvData = File.ReadAllLines(selectedCSVFilePath);

                MessageBox.Show("CSV File Uploaded successfully.");

                // Set the label text to the path of the CSV file
                lbluploaddatacsvfilepath.Text = openFileDialog.FileName;
            }
        }
        #endregion

        #region Process
        private void btnProcess_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedCSVFilePath))
            {
                MessageBox.Show("Please select a both CSV file first.");
                return;
            }

            // Show the progress bar
            step2Progressbar.Visible = true;

            // Disable the button to prevent multiple clicks
            btnProcess.Enabled = false;

            // Create a BackgroundWorker instance
            BackgroundWorker worker = new BackgroundWorker();

            // Worker method to perform the processing
            worker.DoWork += (senderObj, eventArgs) =>
            {
                // Get the first worksheet in the CSV file
                var targetCSVData = File.ReadAllLines(selectedCSVFilePath);
                var updatedRows = new List<string>();

                foreach (var row in targetCSVData)
                {
                    var values = row.Split(',');
                    var firstValue = values.FirstOrDefault();
                    bool isCommaPresent = row.Contains(',');

                    if (dataColumn.ContainsKey(firstValue))
                    {
                        if (isCommaPresent)
                        {
                            updatedRows.Add(values[1] + " | " + dataColumn[firstValue] + "," + firstValue);
                        }
                        else
                        {
                            updatedRows.Add(dataColumn[firstValue] + "," + firstValue);
                        }
                    }
                    else
                    {
                        if (!firstValue.Equals(string.Empty) && values.Length == 1)
                        {
                            updatedRows.Add("" + "," + row); // Keep the original row if key not found in dictionary
                        }
                        else
                        {
                            int lastColumn = values.Length - 1;
                            string key = values[lastColumn];
                            if (values[0].Equals(string.Empty))
                            {
                                if (dataColumn.ContainsKey(key))
                                {
                                    updatedRows.Add(dataColumn[key] + "," + values[lastColumn]);
                                }
                                else
                                {
                                    updatedRows.Add(row);
                                }
                            }
                            else
                            {
                                if (dataColumn.ContainsKey(key))
                                {
                                    updatedRows.Add(values[0] + " | " + dataColumn[key] + "," + values[lastColumn]);
                                }
                                else
                                {
                                    updatedRows.Add(values[0] + "," + values[lastColumn]);
                                }
                            }

                        }

                    }
                }

                File.WriteAllLines(selectedCSVFilePath, updatedRows);
            };

            // Worker completed event to handle completion
            worker.RunWorkerCompleted += (senderObj, eventArgs) =>
            {
                // Hide the progress bar
                step2Progressbar.Visible = false;

                // Enable the button
                btnProcess.Enabled = true;

                // Show completion message
                MessageBox.Show("CSV file updated successfully.");

                // Show message indicating CSV file is being opened
                MessageBox.Show("Opening CSV file. Please wait...");

                // Open the processed file
                Process.Start(selectedCSVFilePath);
            };

            // Start the background worker
            worker.RunWorkerAsync();
        }
        #endregion

        #region ImageInformation
        private void imgInformation_Click(object sender, EventArgs e)
        {
            // Display the message when the icon is clicked
            MessageBox.Show("This file must be a which you have created in step-1");
        } 
        #endregion
    }
}


