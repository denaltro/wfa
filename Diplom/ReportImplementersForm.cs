using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Diplom.Models;
using Diplom.Repository;

namespace Diplom
{
    public partial class ReportImplementersForm : Form
    {
        public ReportImplementersForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            chart1.Visible = true;
            var startTicks = dateTimePicker1.Value.Date.Ticks;
            var endTicks = dateTimePicker2.Value.Date.AddDays(1).Ticks;

            var eventList = MongoRepositoryOrgEvent.GetByDate(startTicks, endTicks, new List<EventType>
            {
                EventType.DISASSEMBLY,
                EventType.INSTALL,
                EventType.REVISION,
                EventType.VERIFICATION
            });

            var implementers = MongoRepositoryImplementers.GetAll();
            
            chart1.Series.Clear();
            chart1.Series.Add(new Series(""));
            chart1.Series[0].ChartType = SeriesChartType.Pie;

            foreach (var imp in implementers)
            {
                var count = eventList.Count(c => c.ImplementerId == imp.Id);
                var perc = eventList.Count != 0 ? decimal.Round((decimal)count / (decimal)eventList.Count * 100, 2) : 0;
                chart1.Series[0].Points.AddXY(imp.Name + " (" + perc + "%)", count);
            }


        }

        private void ReportImplementersForm_Load(object sender, EventArgs e)
        {
            chart1.Visible = false;
        }
    }
}
