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
            DGVBind();
        }

        private void DGVBind()
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Add("Street", "Улица");
            dataGridView1.Columns.Add("House", "Дом");
            dataGridView1.Columns.Add("Building", "Строение");
            dataGridView1.Columns.Add("Apartment", "Квартира");
            dataGridView1.Columns.Add("LastName", "Фамилия");
            dataGridView1.Columns.Add("FirstName", "Имя");
            dataGridView1.Columns.Add("SurName", "Отчество");
            dataGridView1.Columns.Add("Phone", "Телефон");

            var addresses = MongoRepositoryAddresses.GetAll();
            foreach (var address in addresses)
            {
                foreach (var item in address.People)
                {
                    dataGridView1.Rows.Add(address.Street, address.House, address.Building, address.Apartment, item.LastName, item.FirstName, item.SurName, item.Phone);
                }
            }
        }
    }
}
