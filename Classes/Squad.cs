using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamManager.Classes
{
    class Squad
    {
        public string callSign { get; set; }
        public int memeberCount { get; set; }

        public bool IsOut { get { return _isOut; } }
        private bool _isOut;

        public Squad(string callSign, int memeberCount)
        {
            this.callSign = callSign;
            this.memeberCount = memeberCount;

            this._isOut = false;
        }

        public int Count()
        {
            return memeberCount;
        }

        public override string ToString()
        {
            return callSign;
        }

        public void SquadWipe()
        {
            _isOut = true;
        }
    }
}
