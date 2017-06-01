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

namespace Diplom
{
    public partial class DocumentRecountForm : Form
    {
        public DocumentRecountForm()
        {
            InitializeComponent();
        }

        private void button_ok_Click(object sender, EventArgs e)
        {
            object fileName = Path.Combine(Application.StartupPath, "Templates\\template_recount.doc");
            Microsoft.Office.Interop.Word.Application wordApp = new Microsoft.Office.Interop.Word.Application { Visible = true };
            Microsoft.Office.Interop.Word.Document aDoc = wordApp.Documents.Open(fileName, ReadOnly: false, Visible: true);
            aDoc.Activate();

            var counterType = string.Empty;
            switch (comboBox_counterType.SelectedIndex)
            {
                case 0:
                    counterType = "хол. воды";
                    break;
                case 1:
                    counterType = "гор. воды";
                    break;
                case 2:
                    counterType = "электричетсва";
                    break;
            }

            FindAndReplace(wordApp, "{date}", dateTimePicker1.Value.ToString("D"));
            FindAndReplace(wordApp, "{name}", textBox_name.Text);
            FindAndReplace(wordApp, "{address}", textBox_address.Text);
            FindAndReplace(wordApp, "{countertype}", counterType);
            FindAndReplace(wordApp, "{count}", textBox_count.Text);


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

        private void comboBox_counterType_SelectionChangeCommitted(object sender, EventArgs e)
        {
            comboBox_counterType.Text = comboBox_counterType.SelectedItem.ToString();
        }
    }
}
