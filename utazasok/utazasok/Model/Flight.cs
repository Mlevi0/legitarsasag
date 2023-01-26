using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace utazasok.Model
{
    public class Flight
    {
        public int ID { get; set; }
        public string From { get; set; }
        public string To { get; set; }
        public int Price { get; set; }
        public int km { get; set; }
        public int kmPrice { get; set; }
        public int Time { get; set; }

    }
}
