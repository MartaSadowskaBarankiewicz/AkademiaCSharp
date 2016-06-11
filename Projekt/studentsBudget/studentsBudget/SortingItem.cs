using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studentsBudget
{
    class SortingItem : IComparer<Item>
    {
        public int Compare(Item x, Item y)
        {
            string[] dateX = x.Date.Split('.');
            string[] dateY = y.Date.Split('.');

            int day1= int.Parse(dateX[0]);
            int day2= int.Parse(dateY[0]);
            int month1= int.Parse(dateX[1]);
            int month2=int.Parse(dateY[1]);
            int year1 = 0;
            int year2 = 0;

            if(dateX.Length>2)
                year1= int.Parse(dateX[2]);
            if(dateY.Length>2)
                year2= int.Parse(dateY[2]);

            if (year1 > year2)
                return 1;

            if (year1 < year2)
                return -1;

            if (year1 == year2)
            {
                if (month1 > month2)
                    return 1;
                if (month1 < month2)
                    return -1;
                if (month1 == month2)
                {
                    if (day1 > day2)
                        return 1;
                    if (day1 < day2)
                        return -1;
                    return 0;
                }
            }

            return 0;
        }
    }
}
