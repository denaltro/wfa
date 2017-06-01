using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using Diplom.Models;
using Diplom.Repository;
using Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Word;
using Application = System.Windows.Forms.Application;


namespace Diplom
{
    public partial class VerificationListForm : Form
    {
        public VerificationListForm()
        {
            InitializeComponent();
        }

        // ОТРЕФАКТОРИТЬ

        private void button_open_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm";
            openFileDialog1.InitialDirectory = @"C:\";
            openFileDialog1.Title = "Выберите документ из РИЦ";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox_path.Text = openFileDialog1.FileName;
            }

            label_wait.Visible = false;

        }
        List<OrgEvent> verificList = new List<OrgEvent>();
        private void button_load_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_path.Text))
            {
                MessageBox.Show("Укажите путь к файлу!");
            }

            var exist = File.Exists(textBox_path.Text);
            if (!exist) MessageBox.Show("Файл не найден!");
            
            var addressList = MongoRepositoryAddresses.GetByUserId(((ComboBoxItem) comboBox1.SelectedItem).HiddenValue);
            verificList = MongoRepositoryOrgEvent.GetByAddressandType(addressList, EventType.VERIFICATION);
            
            progressBar1.Minimum = 0;
            var verificationList = Parse(addressList);
            Export_revision(verificationList,verificList);

        }
         
        
        private List<Verification> Parse(List<Address> addressList)
        {

            label_wait.Visible = true;
            label_wait.Text = "Считывание и обработка данных...";
            var rowNumber = 0;
            var result = new List<Verification>();
            try
            {
                Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
                Workbook xlWorkbook = xlApp.Workbooks.Open(textBox_path.Text, 0, true, 5, "", "", true, XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 0);
                _Worksheet xlWorksheet = (_Worksheet)xlWorkbook.Sheets[1];
                Microsoft.Office.Interop.Excel.Range xlRange = xlWorksheet.UsedRange;

                Verification verification = null;
                Counter prevCounter = null;
                progressBar1.Maximum = xlRange.Rows.Count;

                for (int i = 1; i < xlRange.Rows.Count; i++)
                {
                   
                    rowNumber = i;
                    var addressCell = (Microsoft.Office.Interop.Excel.Range)xlWorksheet.Cells[rowNumber, 4];
                    if (addressCell.Font.Bold == true && !string.IsNullOrEmpty(addressCell.Value))
                    {
                     
                       
                        AddressShort shortAddress = ParseAddress(addressCell.Value.ToString());
                        if (verification != null)
                        {
                            result.Add(verification);
                            verification = null;
                        }



                        if (shortAddress == null) continue;
                        var exist = addressList.FirstOrDefault(w => w.Street == shortAddress.Street &&
                                                                    w.House == shortAddress.House && w.Apartment ==
                                                                    shortAddress.Apartment);

                        if (exist == null) continue;
                        verification = new Verification
                        {
                            Address = addressCell.Value.ToString(),
                            Counters = new List<Counter>()
                        };

                    }
                   var typeCell = (Microsoft.Office.Interop.Excel.Range)xlWorksheet.Cells[rowNumber, 2];
                  
                    if (verification != null)
                    {
                        var row = (Microsoft.Office.Interop.Excel.Range)xlWorksheet.Cells[rowNumber, 1];
                        if (string.IsNullOrEmpty(row.Value) || !Regex.IsMatch(row.Value.ToString(), "^[\\d]{1,2}$")) continue;
                        var counter = new Counter();
                        counter.Name = ((Microsoft.Office.Interop.Excel.Range)xlWorksheet.Cells[rowNumber, 2])?.Value == null ? prevCounter?.Name : ((Microsoft.Office.Interop.Excel.Range)xlWorksheet.Cells[rowNumber, 2])?.Value.ToString();
                        counter.StartCount = ((Microsoft.Office.Interop.Excel.Range)xlWorksheet.Cells[rowNumber, 12]).Value.ToString();
                        counter.EndCount = ((Microsoft.Office.Interop.Excel.Range)xlWorksheet.Cells[rowNumber, 13]).Value.ToString();
                        counter.StartDate = ((Microsoft.Office.Interop.Excel.Range)xlWorksheet.Cells[rowNumber, 14]).Value.ToString();
                        counter.EndDate = ((Microsoft.Office.Interop.Excel.Range)xlWorksheet.Cells[rowNumber, 15]).Value.ToString();

                        verification.Counters.Add(counter);
                        prevCounter = counter;
                        
                        
                    }
                    progressBar1.PerformStep();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
                MessageBox.Show(ex.Message);
            }
            return result;
        }

        private void Export_verification( List<OrgEvent> verificList)
        {
            Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
            Workbook xlWorkBook = xlApp.Workbooks.Open(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Templates\\template_verification_list.xls"), 0, true, 5, "", "", true, XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 0);
            
        }

        private void Export_revision(List<Verification> verificationList, List<OrgEvent> verificList)
        {
            
            Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
            Workbook xlWorkBook = xlApp.Workbooks.Open(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Templates\\template_verification_list.xls"), 0, true, 5, "", "", true, XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 0);
            _Worksheet xlWorksheet = (_Worksheet)xlWorkBook.Sheets[1];

            int startRow = 5;
            progressBar1.Minimum = 0;
            progressBar1.Value = 0;
            progressBar1.Maximum = verificationList.Count+verificList.Count;

            label_wait.Text = "Запись данных в файл...";
            foreach (var verification in verificationList)
            { 
                var start = startRow;
                var end = startRow + verification.Counters.Count - 1;
                var startCell = xlWorksheet.Cells[start, 1];
                var endCell = xlWorksheet.Cells[end, 1];
                var range = xlWorksheet.Range[startCell, endCell];
                range.Merge(Type.Missing);
                range.Style.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                range.Style.VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;
                range.Borders.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
                range.BorderAround();

                xlWorksheet.Cells[startRow, 1] = verification.Address;
                foreach (var counter in verification.Counters)
                {
                    xlWorksheet.Cells[startRow, 2] = counter.Name;
                    //  xlWorksheet.Cells[startRow, 3] = counter.StartCount.Insert(counter.StartCount.Length - 3, ",");
                    xlWorksheet.Cells[startRow, 3] = counter.StartCount.ToString();
                    xlWorksheet.Cells[startRow, 4] = counter.EndCount.ToString();
                    xlWorksheet.Cells[startRow, 5] = counter.StartDate;
                    xlWorksheet.Cells[startRow, 6] = counter.EndDate;
                    var rng = xlWorksheet.Range[xlWorksheet.Cells[startRow, 2], xlWorksheet.Cells[startRow, 6]];
                    rng.Borders.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
                    startRow++;
                }
                progressBar1.PerformStep();
                
            }
           

            xlWorksheet = (_Worksheet)xlWorkBook.Sheets[2];
            startRow = 5;
            foreach (var ver in verificList)
            {
                var start = startRow;
                var end = startRow + ver.Count;
                var startCell = xlWorksheet.Cells[start, 1];
                var endCell = xlWorksheet.Cells[end, 1];
                var range = xlWorksheet.Range[startCell, endCell];
                range.Style.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                range.Style.VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;
                //range.Borders.LineStyle = XlLineStyle.xlContinuous;
                (range.Cells as Microsoft.Office.Interop.Excel.Range).ColumnWidth = 50;
                //range.BorderAround();

                var counterType = String.Empty;
                switch (ver.CounterType)
                {
                    case Models.CounterType.COLD:
                        counterType = "Холодная вода";
                        break;
                    case Models.CounterType.HOT:
                        counterType = "Горячая вода";
                        break;
                    case Models.CounterType.ELECTRO:
                        counterType = "Электрический";
                        break;
                }

                xlWorksheet.Cells[startRow, 1] = "ул. "+ MongoRepositoryAddresses.Get(ver.AddressId).Street+ ", дом  "
                    + MongoRepositoryAddresses.Get(ver.AddressId).House + ", кв.  "
                    + MongoRepositoryAddresses.Get(ver.AddressId).Apartment;

                

                xlWorksheet.Cells[startRow, 2] = counterType;
                xlWorksheet.Cells[startRow, 3] = new DateTime(ver.DateTime).ToShortDateString();


                var rng = xlWorksheet.Range[xlWorksheet.Cells[startRow, 2], xlWorksheet.Cells[startRow, 3]];
                rng.Borders.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
                startRow++;
                progressBar1.PerformStep();
            }
            label_wait.Text = "Документ построен.";
            xlApp.Visible = true;

        }

        private void VerificationListForm_Load(object sender, EventArgs e)
        {
            var userList = MongoRepositoryUsers.GetAll();
            foreach (var user in userList)
            {
                comboBox1.Items.Add(new ComboBoxItem(user.Name, user.Id));
            }
            
        }

        private AddressShort ParseAddress(string rawAddress)
        {
            var array = rawAddress.Split(',');
            if (array.Length != 4) return null;
            var street = array[1].ToLower().Replace("улица", string.Empty).Trim();
            var house = array[2].ToLower().Trim();
            var apartment = array[3].ToLower().Trim();
            var result = new AddressShort
            {
                Street = street,
                House = house,
                Apartment = apartment
            };
            return result;
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            comboBox1.Text = comboBox1.SelectedItem.ToString();
        }

      
}
}
