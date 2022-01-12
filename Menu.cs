using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamManager.Setup;
using TeamManager.Classes;

namespace TeamManager.Menus
{
    class Menu
    {
        public void Home()
        {
            Console.Clear();
            Console.WriteLine(@" __  __       _        " + "\n" +
                              @"|  \/  | __ _(_)_ __   " + "\n" +
                              @"| |\/| |/ _` | | '_ \  " + "\n" +
                              @"| |  | | (_| | | | | | " + "\n" +
                              @"|_|  |_|\__,_|_|_| |_| " + "\n" +
                              @"=======================" + "\n");
            Console.WriteLine("1. Status\n2. Supply\n3. Casualty\n4. Setup\n\n99. Quit");
            int userInput = Convert.ToInt32(Console.ReadLine());
            switch (userInput)
            {
                case 1:
                    Status();
                    break;
                case 2:
                    Supply();
                    break;
                case 3:
                    Casulaties();
                    break;
                case 4:
                    Setup();
                    break;
                case 99:
                    System.Environment.Exit(1);
                    break;
                default:
                    Home();
                    break;
            }
        }

        public void Setup()
        {
            SquadSetup ss = new SquadSetup();
            SupplyInventorySetup sis = new SupplyInventorySetup();

            Console.Clear();
            Console.WriteLine(@" ____       _                  " + "\n" +
                              @"/ ___|  ___| |_ _   _ _ __     " + "\n" +
                              @"\___ \ / _ \ __| | | | '_ \    " + "\n" +
                              @" ___) |  __/ |_| |_| | |_) |   " + "\n" +
                              @"|____/ \___|\__|\__,_| .__/    " + "\n" +
                              @"                     |_|       " + "\n" +
                              @"===============================" + "\n");
            Console.WriteLine("1. Location\n2. Squads\n3. Supply\n4. Intel\n\n99. Back");
            int userInput = Convert.ToInt32(Console.ReadLine());
            switch (userInput)
            {
                case 1:
                    Console.Write("Grid Size: ");
                    int gridSize = Convert.ToInt32(Console.ReadLine());
                    LocationSetup ls = new LocationSetup();
                    Program.Map = ls.CreateLocation(gridSize);
                    Setup();
                    break;
                case 2:
                    ss.SquadCreation();
                    Setup();
                    break;
                case 3:
                    sis.CreateSupplyInventory();
                    Setup();
                    break;
                case 4:
                    Home();
                    break;
                case 99:
                    Home();
                    break;
                default:
                    Setup();
                    break;
            }
        }

        public void Status()
        {
            Console.Clear();
            Console.WriteLine(@" ____  _        _              " + "\n" +
                              @"/ ___|| |_ __ _| |_ _   _ ___  " + "\n" +
                              @"\___ \| __/ _` | __| | | / __| " + "\n" +
                              @" ___) | || (_| | |_| |_| \__ \ " + "\n" +
                              @"|____/ \__\__,_|\__|\__,_|___/ " + "\n" +
                              @"===============================" + "\n");
            Console.WriteLine("1. Casualties\n2. Supply\n3. Squad\n\n99. Back");
            int userInput = Convert.ToInt32(Console.ReadLine());
            switch (userInput)
            {
                case 1:
                    Console.Clear();

                    int totalNotCLeared = 0;
                    int totalsClear = 0;
                    int totalReports = Program.Reports.Count;
                    foreach(CasualtyReport cr in Program.Reports)
                    {
                        if (cr.Revived)
                        {
                            totalsClear++;
                        }
                        else
                        {
                            totalNotCLeared++;
                        }
                    }
                    Console.WriteLine("Total   \n==========\n>> Cleared : " + totalsClear + "  Not Cleared : " + totalNotCLeared + "   Reports : " + totalReports + "\n");
                    Console.ReadKey();

                    Console.WriteLine("Reports  \n==========");
                    foreach(CasualtyReport cr in Program.Reports)
                    {
                        Console.WriteLine(cr.ToString() + "\n");
                    }
                    Console.ReadKey();

                    Status();
                    break;
                case 2:
                    Console.Clear();
                    Status();
                    break;
                case 3:
                    Console.Clear();

                    int totalAmount = 0;
                    int totalDead = 0;
                    int totalSquads = Program.Militia.Count;
                    foreach(Squad s in Program.Militia)
                    {
                        totalAmount += s.memeberCount;
                    }
                    foreach(CasualtyReport cr in Program.Reports)
                    {
                        if (!cr.Revived)
                        {
                            totalDead += cr.alliesKilled;
                        }
                    }
                    int totalAlive = totalAmount - totalDead;
                    Console.WriteLine("Total   \n==========\n>> Squads : " + totalSquads + "   Members : " + totalAmount + "       Alive : " + totalAlive + "  Dead : " + totalDead + "\n");
                    Console.ReadKey();

                    Console.WriteLine("Squads   \n==========");
                    foreach(Squad s in Program.Militia)
                    {
                        int currentDead = 0;
                        foreach(CasualtyReport cr in Program.Reports)
                        {
                            if(cr.initialSquad.callSign == s.callSign && !cr.Revived)
                            {
                                currentDead += cr.alliesKilled;
                            }
                        }
                        int currentAlive = s.memeberCount - currentDead;
                        Console.WriteLine(">> Callsign : " + s.callSign + " Out : " + s.IsOut + "   Alive : " + currentAlive + "  Dead : " + currentDead);
                    }
                    Console.ReadKey();

                    Status();
                    break;
                case 99:
                    Home();
                    break;
                default:
                    Status();
                    break;
            }
        }

        public void Supply()
        {
            Console.Clear();
            Console.WriteLine(@" ____                    _          " + "\n" +
                              @"/ ___| _   _ _ __  _ __ | |_   _    " + "\n" +
                              @"\___ \| | | | '_ \| '_ \| | | | |   " + "\n" +
                              @" ___) | |_| | |_) | |_) | | |_| |   " + "\n" +
                              @"|____/ \__,_| .__/| .__/|_|\__, |   " + "\n" +
                              @"            |_|   |_|      |___/    " + "\n" +
                              @"====================================" + "\n");
            Console.WriteLine("1. View\n2. Add\n3. Edit\n\n99.Back");
            int userInput = Convert.ToInt32(Console.ReadLine());
            switch(userInput)
            {
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 99:
                    Home();
                    break;
                default:
                    Supply();
                    break;
            }
        }

        public void Casulaties()
        {
            CasualtyReportCreation crc = new CasualtyReportCreation();

            Console.Clear();
            Console.WriteLine(@"  ____                      _ _             " + "\n" +
                              @" / ___|__ _ ___ _   _  __ _| | |_ _   _     " + "\n" +
                              @"| |   / _` / __| | | |/ _` | | __| | | |    " + "\n" +
                              @"| |__| (_| \__ \ |_| | (_| | | |_| |_| |    " + "\n" +
                              @" \____\__,_|___/\__,_|\__,_|_|\__|\__, |    " + "\n" +
                              @"                                  |___/     " + "\n" +
                              @"============================================" + "\n");
            Console.WriteLine("1. View\n2. Add\n3. Edit\n\n99. Back");
            int userInput = Convert.ToInt32(Console.ReadLine());
            switch (userInput)
            {
                case 1:
                    Console.Clear();
                    foreach(CasualtyReport cr in Program.Reports)
                    {
                        Console.WriteLine(cr.ToString() + "\n\n================================\n");
                    }
                    Console.ReadKey();
                    Casulaties();
                    break;
                case 2:
                    crc.CreateReport(); 
                    Console.Clear();
                    foreach (CasualtyReport cr in Program.Reports)
                    {
                        Console.WriteLine(cr.ToString() + "\n\n================================\n");
                    }
                    Console.ReadKey();
                    Casulaties();
                    break;
                case 3:
                    crc.EditReport();
                    Console.Clear();
                    foreach (CasualtyReport cr in Program.Reports)
                    {
                        Console.WriteLine(cr.ToString() + "\n\n================================\n");
                    }
                    Console.ReadKey();
                    Casulaties();
                    break;
                case 99:
                    Home();
                    break;
                default:
                    Casulaties();
                    break;
            }
        }
    }
}
