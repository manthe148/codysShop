using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodysShop
{
    public class Inventory
    {
        public string InventoryID { get; set; }
        public string ItemDescription { get; set; }
        public string Date { get; set; }
        public string Vendor { get; set; }
        public bool Parts { get; set; }
        public bool Shop { get; set; }
    }
}
