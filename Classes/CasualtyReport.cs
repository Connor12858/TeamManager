using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamManager.Classes
{
    class CasualtyReport
    {
        public Squad initialSquad;
        public Location initialEngaged;

        public bool Revived { get { return _revived; } }
        private bool _revived;

        public int TotalLoss { get { return _totalLoss; } }
        private int _totalLoss;

        public int TotalAlive {  get { return _totalAlive; } }
        private int _totalAlive;

        public int ReportNumber { get { return _reportNumber; } }
        private int _reportNumber;

        public int enemyKilled { get; set; }
        public int enemyEngaged { get; set; }
        public int alliesKilled { get; set; }

        public CasualtyReport(int alliesKilled, int enemyEngaged, int enemyKilled, Squad initialSquad, Location initialEngaged)
        {
            this.alliesKilled = alliesKilled;
            this.enemyEngaged = enemyEngaged;
            this.enemyKilled = enemyKilled;

            this._totalAlive = (initialSquad.Count() - alliesKilled) + (enemyEngaged - enemyKilled);
            this._totalLoss = alliesKilled + enemyKilled;

            this.initialEngaged = initialEngaged;
            this.initialSquad = initialSquad;

            this._revived = false;
            this._reportNumber = Program.CRNumber;
            Program.CRNumber++;

            if(alliesKilled == initialSquad.Count())
            {
                initialSquad.SquadWipe();
            }
        }

        public override string ToString()
        {
            string initialData = "Report Number: " + ReportNumber + "   Initially Engaged " + initialSquad.ToString() + " at " + initialEngaged.GetCoordinate();
            string lossStats = "Loses   \n-----------\n>> Allies : " + alliesKilled + " Enemies : " + enemyKilled + "   Total : " + TotalLoss;
            string aliveStats = "Alive  \n-----------\n>> Allies : " + initialSquad.Count() + " Enemies : " + enemyEngaged + "    Total : " + TotalAlive;
            if (_revived)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("CLEARED");
                Console.ResetColor();
                return initialData + "\n" + aliveStats + "\n" + lossStats;
            }
            else
            {
                return initialData + "\n" + aliveStats + "\n" + lossStats;
            }
        }

        public void IsRevived()
        {
            _revived = true;
        }

        public void IsNotRevived()
        {
            _revived = false;
        }
    }
}
