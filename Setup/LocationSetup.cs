using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamManager.Classes;

namespace TeamManager.Setup
{
    class LocationSetup
    {
        public Location[] CreateLocation(int size)
        {
            Location[] tempMap = new Location[size * size];
            for (int i = 0; i < size; i++)
            {
                char[] alph = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
                for (int t = 0; t < size; t++)
                {
                    tempMap[(i * size) + t] = new Location(i + 1, alph[t]);
                }
            }
            return tempMap;
        }
    }
}
