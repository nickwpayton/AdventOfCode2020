using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2020.Models
{
    public class PasswordPolicy
    {
        public int FirstCharLocation { get; set; }

        public int SecondCharLocation { get; set; }

        public char OccurringLetter { get; set; }

        public string Password { get; set; }
    }
}
