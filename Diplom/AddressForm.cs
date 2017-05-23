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
        private Address Address;
        private List<People> PeopleList;

        public AddressForm(Address address = null, List<People> peopleList = null)
        {
            Address = address;
            PeopleList = peopleList ?? new List<People>();
            InitializeComponent();
        }

        private void AddressForm_Load(object sender, EventArgs e)
        {
            if (Address == null) return;
            textBox_street.Text = Address.Street;
            textBox_house.Text = Address.House;
            textBox_biulding.Text = Address.Building;
            textBox_apartment.Text = Address.Apartment;

            foreach (var people in PeopleList)
            {
                dataGridView1.Rows.Add(people.Id, people.LastName, people.FirstName, people.SurName, people.Phone);
            }
        }

        private void button_ok_Click(object sender, EventArgs e)
        {
            var address = new Address
            {
                Id = Address?.Id ?? Guid.NewGuid(),
                Street = textBox_street.Text,
                Building = textBox_biulding.Text,
                House = textBox_house.Text,
                Apartment = textBox_apartment.Text
            };
            MongoRepositoryAddresses.Upsert(address);

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                var id = row.Cells[0].Value?.ToString();
                var lastName = row.Cells[1].Value?.ToString();
                var firstName = row.Cells[2].Value?.ToString();
                var surName = row.Cells[3].Value?.ToString();
                var phone = row.Cells[4].Value?.ToString();

                if (!string.IsNullOrEmpty(id) && string.IsNullOrEmpty(firstName) &&
                    string.IsNullOrEmpty(lastName) && string.IsNullOrEmpty(surName) && string.IsNullOrEmpty(phone))
                {
                    MongoRepositoryPeople.Remove(Guid.Parse(id));
                }

                if (!string.IsNullOrEmpty(firstName) || !string.IsNullOrEmpty(lastName) ||
                    !string.IsNullOrEmpty(surName) || !string.IsNullOrEmpty(phone))
                {
                    var people = new People
                    {
                        Id = id == null ? Guid.NewGuid() : Guid.Parse(id),
                        FirstName = firstName,
                        LastName = lastName,
                        SurName = surName,
                        Phone = phone,
                        AddressId = address.Id
                    };
                    MongoRepositoryPeople.Upsert(people);
                }
            }

            Close();
        }
    }
}
