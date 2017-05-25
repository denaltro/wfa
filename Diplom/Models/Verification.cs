using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diplom.Models
{
    public class Verification
    {
        public string Address { get; set; }
        public List<Counter> Counters { get; set; }
    }

    public class Counter
    {
        public string Name { get; set; }
        public string StartCount { get; set; }
        public string EndCount { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
    }
}
