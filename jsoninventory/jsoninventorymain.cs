using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jsoninventory
{
    internal class jsoninventorymain
    {
        public void showJson(string filePath)
        {
            inventorymodel model = new inventorymodel();
            
            List<inventorymodelclass> Rice;
            List<inventorymodelclass> Wheet;
            List<inventorymodelclass> Pulses;

             using (StreamReader file = new StreamReader(filePath))
             {
                    var json = file.ReadToEnd();
                    inventorymodel item = JsonConvert.DeserializeObject<inventorymodel>(json);
                   
                    Rice = item.Rice;
                    Wheet = item.Wheet;
                    Pulses = item.Pulses;
                    Console.WriteLine("Enter option to see details\n1. Rice\n2. Wheet\n3. Pulses");
                    int input = Convert.ToInt32(Console.ReadLine());
                    switch (input)
                    {
                        case 1:
                            foreach (var person in Rice)
                            {
                                Console.WriteLine(person.Name + " " + person.Price + " " + person.Weight);
                            }
                            break;
                        case 2:
                            foreach (var person in Wheet)
                            {
                                Console.WriteLine(person.Name + " " + person.Price + " " + person.Weight);
                            }
                            break;
                        case 3:
                            foreach (var person in Pulses)
                            {
                                Console.WriteLine(person.Name + " " + person.Price + " " + person.Weight);
                            }
                            break;
                        default:
                            Console.WriteLine("Invalid Input");
                            break;
                    }
                 
             }
        }
    }

   
    
    
}

