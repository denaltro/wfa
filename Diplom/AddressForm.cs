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
    public partial class AddressForm : Form
    {
        public AddressForm()
        {
            InitializeComponent();
        }

        private void button_ok_Click(object sender, EventArgs e)
        {
            //var address = new Address
            //{
            //    Id = Guid.NewGuid(),
            //    Street = textBox_street.Text,
            //    House = textBox_house.Text,
            //    Building = textBox_biulding.Text,
            //    Apartment = textBox_apartment.Text,
            //    People = new List<Guid>()
            //};

            //foreach (DataGridViewRow row in dataGridView1.Rows)
            //{
            //    var item = new People
            //    {
            //        LastName = row.Cells[0].Value.ToString(),
            //        FirstName = row.Cells[1].Value.ToString(),
            //        SurName = row.Cells[2].Value.ToString(),
            //        Phone = row.Cells[3].Value.ToString()
            //    };
            //    address.People.Add(item);
            //}


            //MongoRepositoryAddresses.Add(address);
            Close();
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add();
        }

        private void button_update_Click(object sender, EventArgs e)
        {

        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 1) return;
            Int32 selectedRowCount = dataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount > 0)
            {
                for (int i = 0; i < selectedRowCount; i++)
                {
                    dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
                }
            }
        }
    }
}
