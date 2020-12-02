using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2020.Models
{
    public class PasswordPolicy
    {
        public int MinimumOccurrences { get; set; }

        public int MaximumOccurrences { get; set; }

        public string OccurringLetter { get; set; }

        public string Password { get; set; }
    }
}
