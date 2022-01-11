using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamManager.Menus;
using TeamManager.Classes;

namespace TeamManager
{
    class Program
    {
        private static Menu myMenus = new Menu();

        public static int CRNumber = 1;
        public static Location[] Map;
        public static List<CasualtyReport> Reports = new List<CasualtyReport>();
        public static List<Squad> Militia = new List<Squad>();
        public static List<Supply> SupplyInventory = new List<Supply>();

        static void Main(string[] args)
        {
            myMenus.Home();
        }
    }
}
