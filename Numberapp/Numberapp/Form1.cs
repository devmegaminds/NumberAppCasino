
using IronOcr;
using Microsoft.Office.Interop.Excel;
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
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBlankSheet_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();

            // Create a new workbook
            Microsoft.Office.Interop.Excel.Workbook workbook = excelApp.Workbooks.Add();

            //// Get the active worksheet
            Microsoft.Office.Interop.Excel.Worksheet worksheet = workbook.ActiveSheet;

            // Add the header
            worksheet.Cells[1, 1] = "Data";

            // Start from the second row
            int row = 2;

            // Loop through the specified range of values
            for (int i = 0; i <= 36; i++)
            {
                for (int j = 0; j <= 36; j++)
                {
                    for (int k = 0; k <= 36; k++)
                    {
                        // Concatenate the values with dashes
                        string data = $"{i} | {j} | {k}";

                        // Write the data to the cell in Column A and the current row
                        worksheet.Cells[row, 1] = data;

                        // Move to the next row
                        row++;
                    }
                }
            }

            //// Save the workbook
            workbook.SaveAs("BlankExcelSheet.xlsx");

            // Close Excel application
            excelApp.Quit();

            // Release the resources
            System.Runtime.InteropServices.Marshal.ReleaseComObject(workbook);
            System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApp);


            MessageBox.Show("Blank Excel sheet generated successfully.");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

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
            // Get the dimensions of the image
            //int width = pictureBox1.Image.Width;
            //int height = pictureBox1.Image.Height;

            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Please upload an image first.");
                return;
            }
            // Read text from the image
            string extractedText = ReadTextFromImage(pictureBox1.Image);

            // Create a CSV file and write the extracted text to it
            string csvFilePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Extracteddata.csv");
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
    
    }
}

