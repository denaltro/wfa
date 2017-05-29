using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diplom.Models
{
    public class Disassembly
    {
        public string Date { get; set; }
        public string Address { get; set; }
        public decimal CountDisassembly { get; set; }
        public decimal CountInstall { get; set; }
    }
}
