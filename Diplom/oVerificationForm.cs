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
using Diplom.Repository;
using Diplom.Models;
using Microsoft.Office.Interop.Excel;

namespace Diplom
{
    public partial class oVerificationForm : Form
    {
        public oVerificationForm()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            
        }

        private void button_ok_Click(object sender, EventArgs e)
        {
            var startTicks = dateTimePicker11.Value.Date.Ticks;
            var endTicks = dateTimePicker12.Value.Date.AddDays(1).Ticks;
            var events = MongoRepositoryOrgEvent.GetByDate(startTicks, endTicks, new List<EventType> { EventType.VERIFICATION, EventType.INSTALL, EventType.REVISION, EventType.DISASSEMBLY });

            Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
            Workbook xlWorkBook = xlApp.Workbooks.Open(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Templates\\template_report_events_period.xls"), 0, true, 5, "", "", true, XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 0);
            _Worksheet xlWorksheet = (_Worksheet)xlWorkBook.Sheets[1];

            var startRow = 8;

            var counterTypeDic = events.GroupBy(g => g.CounterType).ToDictionary(d => d.Key);
            var eventTypeDic = events.GroupBy(g => g.EventType).ToDictionary(d => d.Key);

            xlWorksheet.Cells[4, 2] = dateTimePicker11.Value.Date.ToString("D");
            xlWorksheet.Cells[4, 5] = dateTimePicker12.Value.Date.Date.ToString("D");

            foreach (var ect in counterTypeDic)
            {
                var val = ect.Value;
                xlWorksheet.Cells[startRow, 2] = val.Count(w => w.EventType == EventType.VERIFICATION);
                xlWorksheet.Cells[startRow, 3] = val.Count(w => w.EventType == EventType.REVISION);
                xlWorksheet.Cells[startRow, 4] = val.Count(w => w.EventType == EventType.INSTALL);
                xlWorksheet.Cells[startRow, 5] = val.Count(w => w.EventType == EventType.DISASSEMBLY);
                xlWorksheet.Cells[startRow, 6] = val.Count(); 
                startRow++;
            }

            xlWorksheet.Cells[11, 2] = eventTypeDic[EventType.VERIFICATION].Count();
            xlWorksheet.Cells[11, 3] = eventTypeDic[EventType.REVISION].Count();
            xlWorksheet.Cells[11, 4] = eventTypeDic[EventType.INSTALL].Count();
            xlWorksheet.Cells[11, 5] = eventTypeDic[EventType.DISASSEMBLY].Count();



            xlApp.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var startTicks = dateTimePicker21.Value.Date.Ticks;
            var endTicks = dateTimePicker22.Value.Date.AddDays(1).Ticks;

            var eventList = MongoRepositoryOrgEvent.GetByDate(startTicks, endTicks,
                new List<EventType>
                {
                    EventType.DISASSEMBLY,
                    EventType.INSTALL,
                    EventType.REVISION,
                    EventType.VERIFICATION
                });

            var userList = MongoRepositoryUsers.GetAll();
            var addressIdList = eventList.Select(s => s.AddressId).Distinct().ToList();
            var addressList = MongoRepositoryAddresses.GetMany(addressIdList);

            foreach (var orgEvent in eventList)
            {
                orgEvent.AddressId = addressList.First(f => f.Id == orgEvent.AddressId).UserId;
            }

            Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
            Workbook xlWorkBook = xlApp.Workbooks.Open(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Templates\\template_report_events_controller.xls"), 0, true, 5, "", "", true, XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 0);
            _Worksheet xlWorksheet = (_Worksheet)xlWorkBook.Sheets[1];

            xlWorksheet.Cells[4, 2] = dateTimePicker21.Value.Date.ToString("D");
            xlWorksheet.Cells[4, 5] = dateTimePicker22.Value.Date.ToString("D");

            var startRow = 7;
            var grouped = eventList.GroupBy(g => g.AddressId).ToDictionary(d => d.Key);
            foreach (var keyValue in grouped)
            {
                var val = keyValue.Value;
                var userName = userList.First(f => f.Id == keyValue.Key).Name;
                xlWorksheet.Cells[startRow, 1] = userName;
                xlWorksheet.Cells[startRow, 2] = val.Count(w => w.EventType == EventType.INSTALL);
                xlWorksheet.Cells[startRow, 3] = val.Count(w => w.EventType == EventType.VERIFICATION);
                xlWorksheet.Cells[startRow, 4] = val.Count(w => w.EventType == EventType.REVISION);
                xlWorksheet.Cells[startRow, 5] = val.Count(w => w.EventType == EventType.DISASSEMBLY);

                var startCell = xlWorksheet.Cells[startRow, 1];
                var endCell = xlWorksheet.Cells[startRow, 5];
                var range = xlWorksheet.Range[startCell, endCell];
                range.Style.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                range.Style.VerticalAlignment = XlVAlign.xlVAlignCenter;
                range.Borders.LineStyle = XlLineStyle.xlContinuous;

                var start = xlWorksheet.Cells[startRow, 1];
                var end = xlWorksheet.Cells[startRow, 1];
                xlWorksheet.Range[start, end].Font.Bold = true;
                xlWorksheet.Range[start, end].Borders.Weight = XlBorderWeight.xlMedium;

                startRow++;
            }
            xlApp.Visible = true;


        }

        private void oVerificationForm_Load(object sender, EventArgs e)
        {
        }
    }
}
