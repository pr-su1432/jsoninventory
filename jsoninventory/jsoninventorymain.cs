using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jsoninventory
{
    internal class jsoninventorymain
    {
        inventorymodel model = new inventorymodel();
        List<inventorymodel> list = new List<inventorymodel>();
       

        public void convert(string jfilepath)
        {

            using (StreamReader file = new StreamReader(jfilepath))
            {
                var json = file.ReadToEnd();
                var items = JsonConvert.DeserializeObject<List<inventorymodel>>(json);
                foreach (var objects in items)
                {
                    Console.WriteLine(objects.name + " " + objects.price + " " + objects.Weight);
                   
                }
            }
        }
    }
}
