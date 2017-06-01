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
using Diplom.Models;

namespace Diplom
{
    public partial class oVerificationForm : Form
    {
        public oVerificationForm()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            comboBox1.Text = comboBox1.SelectedItem.ToString();
        }

        private void button_ok_Click(object sender, EventArgs e)
        {
            try
            {
                var startTicks = dateTimePicker1.Value.Date.Ticks;
                var endTicks = dateTimePicker2.Value.Date.AddDays(1).Ticks;
                var events = MongoRepositoryOrgEvent.GetByDate(startTicks, endTicks, new List<EventType> { EventType.VERIFICATION });


            }
            catch
            {
                MessageBox.Show("Проверьте введенные данные!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {


            }
            catch
            {
                MessageBox.Show("Проверьте введенные данные!");
            }

        }

        private void oVerificationForm_Load(object sender, EventArgs e)
        {
            var userList = MongoRepositoryUsers.GetAll();
            foreach (var user in userList)
            {
                comboBox1.Items.Add(new ComboBoxItem(user.Name, user.Id));
            }
        }
    }
}
