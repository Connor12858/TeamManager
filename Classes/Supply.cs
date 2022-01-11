using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamManager.Classes
{
    class Supply
    {
        public string Name { get { return _name; } }
        private string _name;
        public int Quantity { get { return _quantity; } }
        private int _quantity;
        public int CaseOf { get { return _caseOf; } }
        private int _caseOf;
        public int TotalAmount { get { return _totalAmount; } }
        private int _totalAmount;

        public Supply(string name)
        {
            this._name = name;
        }

        public void ExpandedCreation(int q, int c)
        {
            _quantity = q;
            _caseOf = c;
            _totalAmount = q * c;
        }

        public void //Edit amounts
    }
}
