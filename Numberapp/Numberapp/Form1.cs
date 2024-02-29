
using ExcelDataReader;
using IronOcr;
using Microsoft.Office.Interop.Excel;
using OfficeOpenXml;
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

namespace Numberapp
{
    public partial class Form1 : Form
    {
        Dictionary<string, string> Dict = new Dictionary<string, string>();
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


        private void btnUploadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog.Title = "Select an Image File";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Load the selected image into the PictureBox
                pictureBox1.Image = new System.Drawing.Bitmap(openFileDialog.FileName);

            }
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Please upload an image first.");
                return;
            }
            // Read text from the image
            string extractedText = ReadTextFromImage(pictureBox1.Image);

            // Create a CSV file and write the extracted text to it
            string csvFilePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "mm.csv");

            File.WriteAllText(csvFilePath, extractedText);

        }

        private string ReadTextFromImage(Image image)
        {
            // Initialize an OCR engine
            var ocr = new IronTesseract();

            // Read text from the image
            var result = ocr.Read(image);

            // Return the extracted text
            return result.Text;
        }

        private void btnUploadCSVFile_Click(object sender, EventArgs e)
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
              
            }

        }
        private string SelectedCSVFilePath;
        private void btnupdateoldcsvfile_Click(object sender, EventArgs e)
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
        }

        private void btnUpdateSheet1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(SelectedCSVFilePath))
            {
                MessageBox.Show("Please select a CSV file first.");
                return;
            }


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
                        message += "," + row.Split(',')[1] + " " + Dict[values];
                    }
                    else
                    {
                        message += "," + Dict[values];
                    }
                }
                message += "\n";
            }

            File.WriteAllText(SelectedCSVFilePath, message);
            MessageBox.Show("Excel file updated successfully.");
            MessageBox.Show(message);
        }

    }
}

