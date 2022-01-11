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
        public int RemainderOfCase { get { return _remainderOfCase; } }
        private int _remainderOfCase;
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

        public void SupplyDropOff(int packages)
        {
            _quantity += packages;
            _totalAmount = _quantity * _caseOf;
        }

        public void DeliveredSupply(int amount)
        {
            if (_remainderOfCase == 0)
            {
                if (amount % _caseOf == 0)
                {
                    _quantity -= amount / _caseOf;
                    _totalAmount = (_quantity * _caseOf) + _remainderOfCase;
                }
                else
                {
                    _remainderOfCase = amount % _caseOf;
                    amount -= _remainderOfCase;
                    _quantity -= amount / _caseOf;
                    _totalAmount = (_quantity * _caseOf) + _remainderOfCase;
                }
            }
            else
            {
                amount -= _remainderOfCase;
                _remainderOfCase = 0;
                if (amount % _caseOf == 0)
                {
                    _quantity -= amount / _caseOf;
                    _totalAmount = (_quantity * _caseOf) + _remainderOfCase;
                }
                else
                {
                    _remainderOfCase = amount % _caseOf;
                    amount -= _remainderOfCase;
                    _quantity -= amount / _caseOf;
                    _totalAmount = (_quantity * _caseOf) + _remainderOfCase;
                }
            }
        }
    }
}
