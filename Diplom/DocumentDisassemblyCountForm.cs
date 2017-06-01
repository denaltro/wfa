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
using Diplom.Models;
using Diplom.Repository;
using Microsoft.Office.Interop.Word;
using Application = System.Windows.Forms.Application;

namespace Diplom
{
    public partial class DocumentDisassemblyCountForm : Form
    {
        public DocumentDisassemblyCountForm()
        {
            InitializeComponent();
        }

        private void button_ok_Click(object sender, EventArgs e)
        {
            //var startDate = dateTimePicker1.Value.DateTime;
            //var endDate = dateTimePicker2.Value.DateTime;

            var startTicks = dateTimePicker1.Value.Date.Ticks;
            var endTicks = dateTimePicker2.Value.Date.AddDays(1).Ticks;

            var events = MongoRepositoryOrgEvent.GetByDate(startTicks, endTicks, new List<EventType> { EventType.DISASSEMBLY, EventType.INSTALL });
            var addressIdList = events.Select(s => s.AddressId).Distinct().ToList();
            var addressList = MongoRepositoryAddresses.Get(addressIdList);

            var disassemblyEventList = events.Where(w => w.EventType == EventType.DISASSEMBLY).ToList();
            var installEventList = events.Where(w => w.EventType == EventType.INSTALL).ToList();

            var result = new List<Disassembly>();

            foreach (var dis in disassemblyEventList)
            {
                var address = addressList.First(f => f.Id == dis.AddressId);
                var install = installEventList.First(w => w.AddressId == dis.AddressId && w.CounterType == dis.CounterType);

                var disassembly = new Disassembly
                {
                    Date = dis.DateTime.ToString("dd.MM.yyyy"),
                    Address = address.Street + " " + address.House + " " + address.Building + " " + address.Apartment,
                    CountDisassembly = dis.Count,
                    CountInstall = install.Count
                };
                result.Add(disassembly);
            }

            /*  var disList = new List<Disassembly>();
              disList.Add(new Disassembly
              {
                  Date = "10.12.2017",
                  Address = "ул. Репина",
                  CountDisassembly = 202103,
                  CountInstall = 123
              });
              disList.Add(new Disassembly
              {
                  Date = "10.12.2018",
                  Address = "ул. Филатова",
                  CountDisassembly = 25553,
                  CountInstall = 1
              }); */

            Export(result);






            Close();
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Export(List<Disassembly> dissasemblyList)
        {
            object fileName = Path.Combine(Application.StartupPath, "Templates\\template_disassembly_count.doc");
            Microsoft.Office.Interop.Word.Application wordApp = new Microsoft.Office.Interop.Word.Application { Visible = true };
            Microsoft.Office.Interop.Word.Document aDoc = wordApp.Documents.Open(fileName, ReadOnly: false, Visible: true);
            aDoc.Activate();


            FindAndReplace(wordApp, "{date}", DateTime.Today.ToString("D"));
            object missing = System.Reflection.Missing.Value;
            for (int i = 0; i < dissasemblyList.Count; i++)
            {
                aDoc.Tables[1].Rows.Add(ref missing);
                aDoc.Tables[1].Rows[i + 2].Range.Bold = 0;
                aDoc.Tables[1].Rows[i + 2].Range.Font.Size = 10;
                aDoc.Tables[1].Rows[i + 2].Cells[1].Range.Text = (i + 1).ToString();
                aDoc.Tables[1].Rows[i + 2].Cells[2].Range.Text = dissasemblyList[i].Date;
                aDoc.Tables[1].Rows[i + 2].Cells[3].Range.Text = dissasemblyList[i].Address;
                aDoc.Tables[1].Rows[i + 2].Cells[4].Range.Text = dissasemblyList[i].CountDisassembly.ToString();
                aDoc.Tables[1].Rows[i + 2].Cells[5].Range.Text = dissasemblyList[i].CountInstall.ToString();
            }

        }

        private void FindAndReplace(Microsoft.Office.Interop.Word.Application doc, object findText, object replaceWithText)
        {
            //options
            object matchCase = false;
            object matchWholeWord = true;
            object matchWildCards = false;
            object matchSoundsLike = false;
            object matchAllWordForms = false;
            object forward = true;
            object format = false;
            object matchKashida = false;
            object matchDiacritics = false;
            object matchAlefHamza = false;
            object matchControl = false;
            object read_only = false;
            object visible = true;
            object replace = 2;
            object wrap = 1;
            //execute find and replace
            doc.Selection.Find.Execute(ref findText, ref matchCase, ref matchWholeWord,
                ref matchWildCards, ref matchSoundsLike, ref matchAllWordForms, ref forward, ref wrap, ref format, ref replaceWithText, ref replace,
                ref matchKashida, ref matchDiacritics, ref matchAlefHamza, ref matchControl);
        }
    }
}
