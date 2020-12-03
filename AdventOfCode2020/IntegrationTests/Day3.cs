using AdventOfCode2020.Mappers;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode2020.IntegrationTests.Day1
{
    [TestFixture]
    class Day3
    {
        [Test]
        public void Part1_GetTreeEncounterCount()
        {
            var fileExtension = @"C:\Users\ucpayto\source\repos\AdventOfCode2020\day-3-input.txt";
            var fileReader = new FileReader();
            var treeGrid = fileReader.GetLinesFromFile(fileExtension);
            var patternRepeatsAt = treeGrid.First().Length;
            var forest = string.Empty;

            foreach (var line in treeGrid) 
            {
                forest += line;
            }

            var iteration = patternRepeatsAt + 3;
            var treeEncounters = 0; 
            for (int i = 0; i < forest.Length; i += iteration)
            {
                if (forest[i] == '#')
                {
                    treeEncounters++;
                }
            }

            var twentyTwenty = 2020;
        }
    }
}
