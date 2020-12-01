using System.Collections.Generic;

namespace AdventOfCode2020
{
    public static class LinqHelper
    {
        public static List<int> RemoveFirst(this List<int> list)
        {
            list.RemoveAt(0);

            return list;
        }

        public static int MultiSum(this List<int> list)
        {
            var total = 1;

            foreach(var item in list)
            {
                total = total * item;
            }

            return total;
        }
    }
}
