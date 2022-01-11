using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamManager.Classes;

namespace TeamManager.Setup
{
    class CasualtyReportCreation
    {
        public void CreateReport()
        {
            Console.Clear();

            Squad initialSquad = null;
            Location engagedLocation = null;
            int alliesKilled;
            int enemiesKilled;
            int enemiesEngaged;

            string input;

            Console.Write("Squad Callsign: ");
            input = Console.ReadLine();
            foreach(Squad sqd in Program.Militia)
            {
                if(sqd.callSign == input)
                {
                    initialSquad = sqd;
                    continue;
                }
            }
            Console.Write("Coordniate: ");
            input = Console.ReadLine();
            foreach(Location l in Program.Map)
            {
                if(l.GetCoordinate() == input)
                {
                    engagedLocation = l;
                    continue;
                }
            }
            Console.Write("Allies Killed: ");
            alliesKilled = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enemies Engaged: ");
            enemiesEngaged = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enemies Killed: ");
            enemiesKilled = Convert.ToInt32(Console.ReadLine());
            CasualtyReport newCR = new CasualtyReport(alliesKilled, enemiesEngaged, enemiesKilled, initialSquad, engagedLocation);
            Program.Reports.Add(newCR);
            Console.Clear();
            Console.WriteLine("Report Number: " + newCR.ReportNumber);
            Console.ReadKey();
        }

        public void EditReport()
        {
            CasualtyReport report = null;
            int reportNumber;
            ConsoleKeyInfo input;

            Console.Write("Report Number: ");
            reportNumber = Convert.ToInt32(Console.ReadLine());
            foreach (CasualtyReport r in Program.Reports)
            {
                if (r.ReportNumber == reportNumber)
                {
                    report = r;
                    continue;
                }
            }

            Console.Write("Revived? (y/n)");
            input = Console.ReadKey();
            if(input.Key == ConsoleKey.Y)
            {
                report.IsRevived();
            }
            else if (input.Key == ConsoleKey.N)
            {
                report.IsNotRevived();
            }
            else
            {
                Console.Write("Error");
                Console.ReadKey();
                EditReport();
            }
        }
    }
}
