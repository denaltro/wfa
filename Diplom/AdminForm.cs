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
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            new UserForm().ShowDialog();
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
            string a = Convert.ToString(selectedRow.Cells["Id"].Value);
            var id = Guid.Parse(a);
            var user = MongoRepositoryUsers.Get(id);
            new UserForm(user).ShowDialog();
        }

        private void button_remove_Click(object sender, EventArgs e)
        {
            int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
            string a = Convert.ToString(selectedRow.Cells["Id"].Value);
            var id = Guid.Parse(a);
            MongoRepositoryUsers.Remove(id);

        }

        private void AdminForm_Activated(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            var userList = MongoRepositoryUsers.GetAll();
            foreach (var user in userList)
            {
                dataGridView1.Rows.Add(user.Id, user.Name, user.Password, user.IsAdmin);
            }

        }
    }
}
