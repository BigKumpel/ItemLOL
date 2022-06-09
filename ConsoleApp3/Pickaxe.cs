using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LolClasses
{
    internal class Pickaxe : Item
    {
        public Pickaxe()
        {
            name = "Pickaxe";
            price = 875;
            AddStat(Stat.AD, 25);
        }
    }
}
