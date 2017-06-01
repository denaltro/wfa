using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Diplom.Repository;

namespace Diplom
{
    public partial class AddressesForm : Form
    {
        public AddressesForm()
        {
            InitializeComponent();
        }

        private void button_search_Click(object sender, EventArgs e)
        {

        }

        private void button_add_Click(object sender, EventArgs e)
        {
            new AddressForm().ShowDialog();
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
            string a = selectedRow.Cells["Id"].Value.ToString();
            var address = MongoRepositoryAddresses.Get(Guid.Parse(a));
            var peopleList = MongoRepositoryPeople.GetByAddressId(Guid.Parse(a));
            new AddressForm(address, peopleList).ShowDialog();
        }

        private void button_remove_Click(object sender, EventArgs e)
        {
            int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
            var id = Guid.Parse(selectedRow.Cells["Id"].Value.ToString());
            MongoRepositoryPeople.RemoveByAddressId(id);
            MongoRepositoryAddresses.Remove(id);
            dataGridView1.Rows.Remove(selectedRow);
        }

        private void AddressesForm_Activated(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            var addressList = MongoRepositoryAddresses.GetAll();
            var userList = MongoRepositoryUsers.GetAll();
            foreach (var address in addressList)
            {
                var user = userList.First(f => f.Id == address.UserId);
                dataGridView1.Rows.Add(address.Id, address.Street, address.House, address.Building,
                    address.Apartment, user.Name);
            }
        }
    }
}
