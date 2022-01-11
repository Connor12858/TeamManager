using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamManager.Classes;

namespace TeamManager.Setup
{
    class SupplyInventorySetup
    {
        public void CreateSupplyInventory()
        {
            Console.Clear();
            Console.WriteLine("Enter all Supplies (, to seperate):");
            string inputSupplies = Console.ReadLine();
            List<string> enteredItems = inputSupplies.Split(',').ToList();
            foreach(string s in enteredItems)
            {
                s.Trim();
                Program.SupplyInventory.Add(new Supply(s));
            }
            foreach(Supply s in Program.SupplyInventory)
            {
                Console.Clear();
                Console.Write("In Stock: ");
                int q = Convert.ToInt32(Console.ReadLine());
                Console.Write("In a Case: ");
                int c = Convert.ToInt32(Console.ReadLine());
                s.ExpandedCreation(q, c);
            }
        }
    }
}
