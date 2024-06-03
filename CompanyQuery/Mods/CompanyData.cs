using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyQuery.Mods
{
    public class CompanyData
    {
        public int ID { get; set; }
        public string CompanyName { get; set; }
        public string Province { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string Remarks { get; set; }
        public bool Interview { get; set; }
    }
}
