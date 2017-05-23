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
    public partial class ImplementersForm : Form
    {
        public ImplementersForm()
        {
            InitializeComponent();
        }

        private void ImplementersForm_Load(object sender, EventArgs e)
        {
            var implementers = MongoRepositoryImplementers.GetAll();
            foreach (var imp in implementers)
            {
                dataGridView1.Rows.Add(imp.Id, imp.ContactName, imp.Name, imp.Phone);
            }
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            new ImplementerForm().ShowDialog();
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            var selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
            var selectedRow = dataGridView1.Rows[selectedrowindex];
            var id = Guid.Parse(selectedRow.Cells["Id"].Value.ToString());
            var imp = MongoRepositoryImplementers.Get(id);
            new ImplementerForm(imp).ShowDialog();
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            var selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
            var selectedRow = dataGridView1.Rows[selectedrowindex];
            var id = Guid.Parse(selectedRow.Cells["Id"].Value.ToString());
            MongoRepositoryImplementers.Remove(id);
            dataGridView1.Rows.Remove(selectedRow);
            dataGridView1.Refresh();
        }

        private void ImplementersForm_Activated(object sender, EventArgs e)
        {
            RefreshForm();
        }

        private void RefreshForm()
        {
            dataGridView1.Rows.Clear();
            var implementers = MongoRepositoryImplementers.GetAll();
            foreach (var imp in implementers)
            {
                dataGridView1.Rows.Add(imp.Id, imp.Name, imp.ContactName, imp.Phone);
            }
        }
    }
}
