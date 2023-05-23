using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewMaui.Model
{
    public class Invoice
    {
        public DateTime serviceDate { get; set; }
        public string totalPartsName { get; set; }
        public int workTimeUsed { get; set; }
        public decimal workPrice { get; set; }
        public int transportTimeUsed { get; set; }
        public decimal transportTimePrice { get; set; }
        public int transportKmUsed { get; set; }
        public decimal transportKmPrice { get; set; }
        public decimal totalPrice { get; set; }

    }
}
