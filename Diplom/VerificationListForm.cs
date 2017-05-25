using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Diplom.Models;
using Microsoft.Office.Interop.Excel;

namespace Diplom
{
    public partial class VerificationListForm : Form
    {
        public VerificationListForm()
        {
            InitializeComponent();
        }

        private void button_open_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm";
            openFileDialog1.InitialDirectory = @"C:\";
            openFileDialog1.Title = "Выберите документ из РИЦ";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox_path.Text = openFileDialog1.FileName;
            }
        }

        private void button_load_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_path.Text))
            {
                MessageBox.Show("Укажите путь к файлу!");
            }

            var exist = File.Exists(textBox_path.Text);
            if (!exist) MessageBox.Show("Файл не найден!");
            var rowNumber = 0;
            var verificationList = new List<Verification>();
            try
            {
                Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
                Workbook xlWorkbook = xlApp.Workbooks.Open(textBox_path.Text, 0, true, 5, "", "", true, XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 0);
                _Worksheet xlWorksheet = (_Worksheet)xlWorkbook.Sheets[1];
                Range xlRange = xlWorksheet.UsedRange;

                Verification verification = null;
                Counter prevCounter = null;

                for (int i = 1; i < xlRange.Rows.Count; i++)
                {
                    rowNumber = i;

                    //if (rowNumber == 234)
                    //{
                    //    var dd = 1;
                    //}

                    var addressCell = (Range)xlWorksheet.Cells[rowNumber, 4];
                    if (addressCell.Font.Bold == true && !string.IsNullOrEmpty(addressCell.Value))
                    {
                        if (verification != null) verificationList.Add(verification);

                        verification = new Verification
                        {
                            Address = addressCell.Value.ToString(),
                            Counters = new List<Counter>()
                        };
                    }
                    if (verification != null)
                    {
                        var row = (Range)xlWorksheet.Cells[rowNumber, 1];
                        if (string.IsNullOrEmpty(row.Value) || !Regex.IsMatch(row.Value.ToString(), "^[\\d]{1,2}$")) continue;
                        var counter = new Counter();
                        counter.Name = ((Range)xlWorksheet.Cells[rowNumber, 2])?.Value == null ? prevCounter?.Name : ((Range)xlWorksheet.Cells[rowNumber, 2])?.Value.ToString();
                        counter.StartCount = ((Range)xlWorksheet.Cells[rowNumber, 12]).Value.ToString();
                        counter.EndCount = ((Range)xlWorksheet.Cells[rowNumber, 13]).Value.ToString();
                        counter.StartDate = ((Range)xlWorksheet.Cells[rowNumber, 14]).Value.ToString();
                        counter.EndDate = ((Range)xlWorksheet.Cells[rowNumber, 15]).Value.ToString();

                        verification.Counters.Add(counter);
                        prevCounter = counter;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
                MessageBox.Show(ex.Message);
            }
        }

    }
}
