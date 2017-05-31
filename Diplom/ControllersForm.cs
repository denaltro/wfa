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
    public partial class ControllersForm : Form
    {
        List<Address> AddressList = new List<Address>();
        public ControllersForm()
        {
            InitializeComponent();
        }
        private Controller Controller = null;
        private void button_controller_add_Click(object sender, EventArgs e)
        {
            var controllers = new Controller
            {
                Id = Controller == null ? Guid.NewGuid() : Controller.Id,
                FIO = textBox_controller.Text,
                Houses = new List<Houses>()
            };
            Houses houses = new Houses();
            foreach (string i in listBox_address.Items)
            {
                houses.Street = i.Split(' ')[0];
                houses.House = i.Split(' ')[1];
                controllers.Houses.Add(houses);
            }
            

            MongoRepositoryController.Upsert(controllers);
            dataGridView2.Rows.Clear();
            this.ControllersForm_Load(sender, e);
        }

        private void ControllersForm_Load(object sender, EventArgs e)
        {
            var controllers = MongoRepositoryController.GetAll();
            foreach (var imp in controllers)
            {
                dataGridView2.Rows.Add(imp.Id, imp.FIO);
            }

            AddressList = MongoRepositoryAddresses.GetAll();
            var streetList = AddressList.Select(s => s.Street).Distinct().ToList();

            foreach (var street in streetList)
            {
                comboBox_street.Items.Add(street);
            }
        }

        private void button_delete_controller_Click(object sender, EventArgs e)
        {
            int selectedrowindex = dataGridView2.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridView2.Rows[selectedrowindex];
            var id = Guid.Parse(selectedRow.Cells["Identificator"].Value.ToString());
            MongoRepositoryController.Remove(id);
            dataGridView2.Rows.Remove(selectedRow);
            dataGridView2.Rows.Clear();
            this.ControllersForm_Load(sender, e);

        }

        private void comboBox_street_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox_houses.Items.Clear();
            var selectedValue = comboBox_street.SelectedItem.ToString();
            var houseList = AddressList.Where(w => w.Street == selectedValue).Select(s => s.House).ToList();
            foreach (var house in houseList)
            {
                comboBox_houses.Items.Add(house);
            }
        }

        private void button_address_add_Click(object sender, EventArgs e)
        {
            listBox_address.Items.Add(comboBox_street.SelectedItem+ " " + comboBox_houses.SelectedItem);
        }

        private void button_address_del_Click(object sender, EventArgs e)
        {
            listBox_address.Items.Remove(listBox_address.SelectedItem);
        }

        private void dataGridView2_SelectionChanged(object sender, EventArgs e)
        {
            listBox_address.Items.Clear();
      


        }
    }
}
