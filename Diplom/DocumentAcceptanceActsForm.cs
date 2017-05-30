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

namespace Diplom
{
    public partial class DocumentAcceptanceActsForm : Form
    {
        public DocumentAcceptanceActsForm()
        {
            InitializeComponent();
        }

        private void button_ok_Click(object sender, EventArgs e)
        {
            var startTicks = dateTimePicker_start.Value.Date.Ticks;
            var endTicks = dateTimePicker_end.Value.Date.AddDays(1).Ticks;
            var eventTypes = new List<EventType>{EventType.INSTALL};


            var eventList = MongoRepositoryOrgEvent.GetByDate(startTicks, endTicks,eventTypes);
            var addressIdList = eventList.Select(s => s.AddressId).Distinct().ToList();
            var addressList = MongoRepositoryAddresses.Get(addressIdList);
            

            object fileName = Path.Combine(Application.StartupPath, "Templates\\template_acceptance_acts.doc");
            Microsoft.Office.Interop.Word.Application wordApp = new Microsoft.Office.Interop.Word.Application { Visible = true };
            Microsoft.Office.Interop.Word.Document aDoc = wordApp.Documents.Open(fileName, ReadOnly: false, Visible: true);
            aDoc.Activate();


            FindAndReplace(wordApp, "{date}", DateTime.Today.ToString("D"));
            object missing = System.Reflection.Missing.Value;
            for (int i = 0; i < eventList.Count; i++)
            {
                var address = addressList.First(w => w.Id == eventList[i].AddressId);

                var counterType = string.Empty;
                switch (eventList[i].CounterType)
                {
                    case CounterType.COLD:
                        counterType = "ХВС";
                        break;
                    case CounterType.HOT:
                        counterType = "ГВС";
                        break;
                    case CounterType.ELECTRO:
                        counterType = "Электр.";
                        break;
                }

                aDoc.Tables[1].Rows.Add(ref missing);
                aDoc.Tables[1].Rows[i + 4].Range.Bold = 0;
                aDoc.Tables[1].Rows[i + 4].Range.Font.Size = 10;


                aDoc.Tables[1].Rows[i + 4].Cells[1].Range.Text = address.Street;
                aDoc.Tables[1].Rows[i + 4].Cells[2].Range.Text = address.House;
                aDoc.Tables[1].Rows[i + 4].Cells[3].Range.Text = address.Apartment;
                aDoc.Tables[1].Rows[i + 4].Cells[4].Range.Text = new DateTime(eventList[i].DateTime).ToString("D");
                aDoc.Tables[1].Rows[i + 4].Cells[5].Range.Text = counterType;
                aDoc.Tables[1].Rows[i + 4].Cells[6].Range.Text = eventList[i].Place;
            }



            Close();
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            Close();
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
