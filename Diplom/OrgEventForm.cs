using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Diplom.Models;
using Diplom.Repository;

namespace Diplom
{
    public partial class OrgEventForm : Form
    {
        private OrgEvent OrgEvent = null;
        private Address Address = null;

        public OrgEventForm(OrgEvent orgEvent = null, Address address = null)
        {
            OrgEvent = orgEvent;
            Address = address;
            InitializeComponent();
        }

        private void button_ok_Click(object sender, EventArgs e)
        {
            var address = MongoRepositoryAddresses.Get(textBox_street.Text, textBox_house.Text, textBox_building.Text,
                textBox_apartment.Text);

            if (address == null)
            {
                MessageBox.Show("Адрес не занесен в базу!");
                return;
            }

            var orgEvent = new OrgEvent
            {
                Id = OrgEvent?.Id ?? Guid.NewGuid(),
                EventType = GetEventType(),
                CounterType = GetCounterType(),
                AddressId = address.Id,
                DateTime = dateTimePicker_date.Value.Ticks,
                ImplementerId = ((ComboBoxItem)comboBox_implementer.SelectedItem).HiddenValue,
                Place = string.IsNullOrEmpty(textBox_place.Text) ? null : textBox_place.Text,
                Count = Convert.ToDecimal(textBox_count.Text)
            };

            MongoRepositoryOrgEvent.Upsert(orgEvent);

            Close();
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void EventForm_Load(object sender, EventArgs e)
        {
            var implementers = MongoRepositoryImplementers.GetAll();
            foreach (var imp in implementers)
            {
                comboBox_implementer.Items.Add(new ComboBoxItem(imp.Name, imp.Id));
            }
            if (OrgEvent == null)
            {
                comboBox_implementer.SelectedIndex = 0;
                comboBox_eventType.SelectedIndex = 0;
                comboBox_counterType.SelectedIndex = 0;
            }
            else
            {
                textBox_street.Text = Address?.Street;
                textBox_house.Text = Address?.House;
                textBox_building.Text = Address?.Building;
                textBox_apartment.Text = Address?.Apartment;
                comboBox_eventType.SelectedIndex = (int)OrgEvent.EventType;
                textBox_place.Text = OrgEvent.Place;
                dateTimePicker_date.Value = new DateTime(OrgEvent.DateTime);
                comboBox_counterType.SelectedIndex = (int) OrgEvent.CounterType;
                textBox_count.Text = OrgEvent.Count.ToString(CultureInfo.InvariantCulture);

                var impId = OrgEvent.ImplementerId;
                //var index = comboBox_implementer.Items.

                //var impIndex = ((ComboBoxItem)comboBox_implementer.SelectedItem).HiddenValue,
                //comboBox_implementer.SelectedIndex = comboBox_implementer
            }

        }

        private EventType GetEventType()
        {
            var result = EventType.INSTALL;
            var index = comboBox_eventType.SelectedIndex;
            switch (index)
            {
                case 0:
                    result = EventType.INSTALL;
                    break;
                case 1:
                    result = EventType.REVISION;
                    break;
                case 2:
                    result = EventType.VERIFICATION;
                    break;
                case 3: 
                    result = EventType.DISASSEMBLY;
                    break;
            }
            return result;
        }

        private CounterType GetCounterType()
        {
            var result = CounterType.COLD;
            var index = comboBox_counterType.SelectedIndex;
            switch (index)
            {
                case 0:
                    result = CounterType.COLD;
                    break;
                case 1:
                    result = CounterType.HOT;
                    break;
                case 2:
                    result = CounterType.ELECTRO;
                    break;
            }
            return result;
        }

        private void comboBox_eventType_SelectionChangeCommitted(object sender, EventArgs e)
        {
            comboBox_eventType.Text = comboBox_eventType.SelectedItem.ToString();
        }

        private void comboBox_counterType_SelectionChangeCommitted(object sender, EventArgs e)
        {
            comboBox_counterType.Text = comboBox_counterType.SelectedItem.ToString();
        }

        private void comboBox_implementer_SelectionChangeCommitted(object sender, EventArgs e)
        {
            comboBox_implementer.Text = comboBox_implementer.SelectedItem.ToString();
        }
    }

    public class ComboBoxItem
    {
        string displayValue;
        Guid hiddenValue;

        //Constructor
        public ComboBoxItem(string d, Guid h)
        {
            displayValue = d;
            hiddenValue = h;
        }

        //Accessor
        public Guid HiddenValue
        {
            get
            {
                return hiddenValue;
            }
        }

        //Override ToString method
        public override string ToString()
        {
            return displayValue;
        }
    }
}
