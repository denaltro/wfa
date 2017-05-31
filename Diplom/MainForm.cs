using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Diplom.Models;
using Diplom.Repository;

namespace Diplom
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void исполнителиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ImplementersForm().ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new AddressForm().ShowDialog();
        }

        //private void MainForm_Load(object sender, EventArgs e)
        //{
        //    //DGVBind();

        //    //var bindingList = new BindingList<Implementer>(implementers);
        //    //var source = new BindingSource(bindingList, null);
        //    //dataGridView1.DataSource = source;
        //}

        private void MainForm_Activated(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            var eventList = MongoRepositoryOrgEvent.GetAll();
            var addressList = MongoRepositoryAddresses.GetAll();
            var implementers = MongoRepositoryImplementers.GetAll();

            foreach (var orgEvent in eventList)
            {
                var address = addressList.First(w => w.Id == orgEvent.AddressId);
                var addressString = string.Join(", ", new List<string> { address.Street, address.House, address.Building, address.Apartment });

                var implementer = implementers.First(a => a.Id == orgEvent.ImplementerId).Name;

                var counterType = String.Empty;
                switch (orgEvent.CounterType)
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

                var eventType = string.Empty;
                switch (orgEvent.EventType)
                {
                    case Models.EventType.INSTALL:
                        eventType = "Установка";
                        break;
                    case Models.EventType.REVISION:
                        eventType = "Переустановка";
                        break;
                    case Models.EventType.VERIFICATION:
                        eventType = "Поверка";
                        break;
                    case Models.EventType.DISASSEMBLY:
                        eventType = "Демонтаж";
                        break;
                }

                dataGridView1.Rows.Add(orgEvent.Id, orgEvent.AddressId, addressString, counterType, orgEvent.Place, new DateTime(orgEvent.DateTime).ToString("D"), implementer, eventType);
            }
        }


        private void button_add_Click(object sender, EventArgs e)
        {
            new OrgEventForm().ShowDialog();
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
            string a = selectedRow.Cells["Id"].Value.ToString();
            var orgEvent = MongoRepositoryOrgEvent.Get(Guid.Parse(a));

            Address address = null;
            if (orgEvent != null)
            {
                address = MongoRepositoryAddresses.Get(orgEvent.AddressId);

            }

            new OrgEventForm(orgEvent, address).ShowDialog();
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
            string a = selectedRow.Cells["Id"].Value.ToString();
            MongoRepositoryOrgEvent.Remove(Guid.Parse(a));
        }

        private void адресаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AddressesForm().ShowDialog();
        }

        private void листОсмотраToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new VerificationListForm().ShowDialog();
        }

        private void перерасчетДляРИЦToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new DocumentRecountForm().ShowDialog();
        }

        private void реестрСнятияИУстановкиЭлектросчётчиковToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new DocumentDisassemblyCountForm().ShowDialog();
        }

        private void актыПриемкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new DocumentAcceptanceActsForm().ShowDialog();
        }

        private void контролерыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ControllersForm().ShowDialog();
        }
    }
}
