using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2020
{
    public class FileReader
    {
        public List<int> GetIntsFromFile(string fileExtension)
        {
            string[] lines = System.IO.File.ReadAllLines(fileExtension);

            int[] ints = Array.ConvertAll(lines, line => int.Parse(line));

            var intList = new List<int>(ints);
            return intList;
        }
    }
}
