using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giraffe
{
    class Football
    {
        public string Name;
        public string League;
        public int Position;

        public Football(string name, string league, int position)
        {
            Name = name;
            League = league;
            Position = position;
        }

        public bool IsFirst()
        {
            if (Position == 1)
            {
                return true;
            }
            return false;
        }
        public bool IsSecond()
        {
            if (Position == 2)
            {
                return true;
            }
            return false;
        }
        public bool IsThird()
        {
            if (Position == 3)
            {
                return true;
            }
            return false;
        }
        public bool IsFourth()
        {
            if (Position == 4)
            {
                return true;
            }
            return false;
        }
        public bool IsFifth()
        {
            if (Position == 5)
            {
                return true;
            }
            return false;
        }
    }


    

}
