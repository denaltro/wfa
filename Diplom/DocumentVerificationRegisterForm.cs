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
    public partial class DocumentVerificationRegisterForm : Form
    {
        public DocumentVerificationRegisterForm()
        {
            InitializeComponent();
        }

        private void button_ok_Click(object sender, EventArgs e)
        {
            var startDate = dateTimePicker_start.Value.Date.Ticks;
            var endDate = dateTimePicker_end.Value.Date.AddDays(1).Ticks;

            var counterTypeList = new List<CounterType>();
            if (comboBox1.SelectedIndex == 0)
            {
                counterTypeList.Add(CounterType.COLD);
                counterTypeList.Add(CounterType.HOT);
            }
            else
            {
                counterTypeList.Add(CounterType.ELECTRO);
            }

            var events = MongoRepositoryOrgEvent.GetByDate(startDate, endDate,
                new List<EventType> {EventType.VERIFICATION}, counterTypeList);


            object fileName = Path.Combine(Application.StartupPath, "Templates\\template_verification_register.doc");
            Microsoft.Office.Interop.Word.Application wordApp = new Microsoft.Office.Interop.Word.Application { Visible = true };
            Microsoft.Office.Interop.Word.Document aDoc = wordApp.Documents.Open(fileName, ReadOnly: false, Visible: true);
            aDoc.Activate();


            FindAndReplace(wordApp, "{date}", DateTime.Today.ToString("D"));
            object missing = System.Reflection.Missing.Value;

            
            if (comboBox1.SelectedIndex == 0)
            {
                var dd = events.GroupBy(g => new {g.AddressId, g.Place}).ToDictionary(d => d.Key.AddressId);

                for (int i = 0; i < 8; i++)
                {
                    aDoc.Tables[1].Columns.Add(ref missing);
                }

                aDoc.Tables[1].Rows[1].Range.Bold = 1;
                aDoc.Tables[1].Rows[1].Cells[1].Range.Text = "№ п/п";
                aDoc.Tables[1].Rows[1].Cells[2].Range.Text = "Адрес";
                aDoc.Tables[1].Rows[1].Cells[3].Range.Text = "Дата поверки";
                aDoc.Tables[1].Rows[1].Cells[4].Range.Text = "ХВС № заводск.";
                aDoc.Tables[1].Rows[1].Cells[5].Range.Text = "показания";
                aDoc.Tables[1].Rows[1].Cells[6].Range.Text = "Дата след.гос.поверки";
                aDoc.Tables[1].Rows[1].Cells[7].Range.Text = "ГВС № заводск.";
                aDoc.Tables[1].Rows[1].Cells[8].Range.Text = "показания";
                aDoc.Tables[1].Rows[1].Cells[9].Range.Text = "Дата след.гос.поверки";




                foreach (var rec in dd)
                {
                    var cold = rec.Value.FirstOrDefault(w => w.CounterType == CounterType.COLD);
                    var hot = rec.Value.FirstOrDefault(w => w.CounterType == CounterType.HOT);

                    var i = 1;
                    aDoc.Tables[1].Rows.Add(ref missing);
                    aDoc.Tables[1].Rows[i + 1].Range.Bold = 0;
                    aDoc.Tables[1].Rows[i + 1].Range.Font.Size = 10;
                    aDoc.Tables[1].Rows[i + 1].Cells[1].Range.Text = i.ToString();
                    aDoc.Tables[1].Rows[i + 1].Cells[2].Range.Text = "LEL";
                    aDoc.Tables[1].Rows[i + 1].Cells[3].Range.Text = new DateTime(cold.DateTime).ToString("D"); 
                    aDoc.Tables[1].Rows[i + 1].Cells[4].Range.Text = cold.Place;
                    aDoc.Tables[1].Rows[i + 1].Cells[5].Range.Text = cold.Count.ToString();
                    aDoc.Tables[1].Rows[i + 1].Cells[6].Range.Text = new DateTime(cold.DateTime).AddYears(4).ToString("D");
                    aDoc.Tables[1].Rows[i + 1].Cells[7].Range.Text = hot?.Place;
                    aDoc.Tables[1].Rows[i + 1].Cells[8].Range.Text = hot?.Count.ToString();
                    aDoc.Tables[1].Rows[i + 1].Cells[9].Range.Text = hot == null ? null : new DateTime(hot.DateTime).AddYears(4).ToString("D");
                }




                //for (int i = 0; i < dissasemblyList.Count; i++)
                //{
                //      aDoc.Tables[1].Rows.Add(ref missing);
                //    aDoc.Tables[1].Rows[i + 2].Range.Bold = 0;
                //    aDoc.Tables[1].Rows[i + 2].Range.Font.Size = 10;
                //    aDoc.Tables[1].Rows[i + 2].Cells[1].Range.Text = (i + 1).ToString();
                //    aDoc.Tables[1].Rows[i + 2].Cells[2].Range.Text = dissasemblyList[i].Date;
                //    aDoc.Tables[1].Rows[i + 2].Cells[3].Range.Text = dissasemblyList[i].Address;
                //    aDoc.Tables[1].Rows[i + 2].Cells[4].Range.Text = dissasemblyList[i].CountDisassembly.ToString();
                //    aDoc.Tables[1].Rows[i + 2].Cells[5].Range.Text = dissasemblyList[i].CountInstall.ToString();
                //}
            }
            else
            {
                
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
