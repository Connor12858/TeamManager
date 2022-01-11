using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamManager.Classes
{
    class SupplyRequest
    {
        public Squad squadRequest { get { return _squadRequest; } }
        private Squad _squadRequest = null;

        public List<Supply> supplyOrder { get { return _supplyOrder; } }
        private List<Supply> _supplyOrder = new List<Supply>();

        private string[] processSteps = { "On Order", "Loading", "Delivering", "Delivered"};
        private bool isDelivered = false;
    }
}
