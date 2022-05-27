using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace jsoninventory
{
    internal class inventorymodel
    {
        public List<inventorymodelclass> Rice { get; set; }
        public List<inventorymodelclass> Wheet { get; set; }
        public List<inventorymodelclass> Pulses { get; set; }
    }
}

