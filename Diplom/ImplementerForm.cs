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
    public partial class ImplementerForm : Form
    {
        public ImplementerForm()
        {
            InitializeComponent();
        }

        private void button_ok_Click(object sender, EventArgs e)
        {
            var implementer = new Implementer
            {
                Id = Guid.NewGuid(),
                Name = textBox_name.Text,
                ContactName = textBox_contactName.Text,
                Phone = textBox_phone.Text
            };
            MongoRepositoryImplementers.Add(implementer);
            Close();
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
