using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamManager.Classes;

namespace TeamManager.Setup
{
    class SquadSetup
    {
        public void SquadCreation()
        {
            int memCount;
            string callSign;

            Console.Clear();
            Console.Write("Call Sign: ");
            callSign = Console.ReadLine();
            Console.Write("Team Size: ");
            memCount = Convert.ToInt32(Console.ReadLine());

            Program.Militia.Add(new Squad(callSign, memCount));
        }
    }
}
