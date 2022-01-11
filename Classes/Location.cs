using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamManager.Classes
{
    class Location
    {
        private int num;
        private char letter;

        private int _allies;
        public int Allies { get { return _allies; } }

        private char _status;
        public char Status { get { return _status; } }

        public Location(int n, char l)
        {
            this._status = 'u';
            this.num = n;
            this.letter = l;
            this._allies = 0;
        }

        public string MoveTo()
        {
            switch (_status)
            {
                case 'u':
                    _status = 'a';
                    return "Location Allied Controlled";
                case 't':
                    _status = 'e';
                    return "Engaged";
                case 'e':
                    _allies++;
                    return "Hot Zone/Engaged";
                case 'a':
                    _allies++;
                    return "Hot Zone/Location Allied Controlled";
                default:
                    return "Not a vaild Status";
            }
        }

        public string MoveOut()
        {
            switch (_status)
            {
                case 'e':
                    if (_allies > 1)
                    {
                        _allies--;
                        return "Hot Zone/Advance with Caution";
                    }
                    else
                    {
                        _allies--;
                        _status = 't';
                        return "Advance with Caution";
                    }
                case 'a':
                    if (_allies >= 3)
                    {
                        _allies--;
                        return "Hot Zone/Location Allied Controlled";
                    } 
                    else if(_allies == 2)
                    {
                        _allies--;
                        return "Location Allied Controlled";
                    } 
                    else
                    {
                        _allies--;
                        _status = 'u';
                        return "Location Unoccupied";
                    }
                default:
                    return "Not a vaild status";
            }
        }

        public void AllClear()
        {
            _status = 'a';
        }

        public string GetCoordinate()
        {
            return letter.ToString().ToUpper() + num;
        }
    }
}
