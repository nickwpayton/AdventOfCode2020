using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2020
{
    public class ExpenseReport
    {
        public Tuple<int,int> FindTwoEntriesSummingToTotal(int total, List<int> entries)
        {
            foreach(var entry in entries)
            {
                int? sumCandidate = entries.Where(e => (total - e) == entry).Cast<int?>().FirstOrDefault();
                if (sumCandidate != null)
                {
                    return Tuple.Create(entry, sumCandidate.Value);
                }
            }

            return Tuple.Create(0, 0);
        }

        public List<int> FindThreeEntriesSummingToTotal(int total, List<int> entries)
        {
            foreach (var entry in entries)
            {
                var remainingEntries = entries.RemoveFirst();

                foreach (var remainingEntry in remainingEntries)
                {
                    int? sumCandidate = remainingEntries.Where(re => (total - re - remainingEntry) == entry).Cast<int?>().FirstOrDefault();
                    if (sumCandidate != null)
                    {
                        return new List<int> { entry, remainingEntry, sumCandidate.Value };
                    }
                }
            }

            return new List<int>();
        }
    }
}
