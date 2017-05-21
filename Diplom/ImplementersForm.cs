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

        private void button_add_Click(object sender, EventArgs e)
        {
            new ImplementerForm().ShowDialog();
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            new ImplementerForm().ShowDialog();
        }

        private void ImplementersForm_Load(object sender, EventArgs e)
        {
            var implementers = MongoRepositoryImplementers.GetAll();
            var bindingList = new BindingList<Implementer>(implementers);
            var source = new BindingSource(bindingList, null);
            dataGridView1.DataSource = source;
        }
    }
}
