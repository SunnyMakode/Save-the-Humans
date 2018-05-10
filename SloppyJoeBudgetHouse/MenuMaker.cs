using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SloppyJoeBudgetHouse
{
    class MenuMaker
    {
        Random Randomizer = new Random();

        string[] Sabji = { "Chana Masala", "Baigan Sabji", "Daal Tadka", "Patwadi" };
        string[] SabjiStyle = { "Agri", "Maharashtrain", "Goan", "Tandoor"};
        string[] Breads = { "Phulka", "Missi Roti", "Paratha", "Stuffed chilla", "Appam"};

        public string GetMenuItem()
        {
            string randomSabji = Sabji[Randomizer.Next(Sabji.Length)];
            string randomSabjiStyle = SabjiStyle[Randomizer.Next(SabjiStyle.Length)];
            string randomBreads = Breads[Randomizer.Next(Breads.Length)];

            return  randomSabji + " with " + randomSabjiStyle + " style goes good with some " + randomBreads;
        }
    }
}
