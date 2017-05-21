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
        private Implementer Implementer = null;

        public ImplementerForm(Implementer implementer = null)
        {
            Implementer = implementer;
            InitializeComponent();
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            var implementer = new Implementer
            {
                Id = Implementer == null ? Guid.NewGuid() : Implementer.Id,
                Name = textBox_name.Text,
                ContactName = textBox_contactName.Text,
                Phone = textBox_phone.Text
            };
            
            MongoRepositoryImplementers.Upsert(implementer);
            Close();
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ImplementerForm_Load(object sender, EventArgs e)
        {
            if (Implementer == null) return;
            textBox_name.Text = Implementer.Name;
            textBox_contactName.Text = Implementer.ContactName;
            textBox_phone.Text = Implementer.Phone;
        }
    }
}
