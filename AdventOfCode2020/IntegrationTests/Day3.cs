using AdventOfCode2020.Mappers;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode2020.IntegrationTests.Day1
{
    [TestFixture]
    class Day3
    {
        private int _treeEncounters;

        [Test]
        public void Part1_GetTreeEncounterCount()
        {
            var fileExtension = @"C:\Users\ucpayto\source\repos\AdventOfCode2020\day-3-input.txt";
            var fileReader = new FileReader();
            var treeGrid = fileReader.GetLinesFromFile(fileExtension).ToList();

            //char[][] forest = treeGrid.Select(tile => tile.ToArray()).ToArray();
            var down = 2;
            var right = 1;

            var result = new List<string>();

            for (int x = 0; x < treeGrid.Count; x++)
            {
                var rowOfTrees = string.Empty;

                for (int y = 0; y < treeGrid.Count * right; y += treeGrid[x].Length)
                {
                    rowOfTrees += treeGrid[x];
                }

                result.Add(rowOfTrees);
            }

            char[][] forest = result.Select(tile => tile.ToArray()).ToArray();

            int i = 1;
            int j = 0;
            var forestRowLength = forest[i].Length;
            while (i < forest.Length)
            {
                //if (j + right > forestRowLength - 1)
                //{
                //    j = j + right - forestRowLength;
                //    TallyTreeEncounter(forest[i][j]);
                //}
                //else
                //{
                //    j += right;
                //    TallyTreeEncounter(forest[i][j]);
                //}
                j += right;
                TallyTreeEncounter(forest[i][j]);
                i += down;
            }
            var encounters = _treeEncounters;
            var twentyTwenty = 2020;
        }

        private void TallyTreeEncounter(char tile)
        {
            if(tile == '#')
            {
                _treeEncounters++;
            }
        }
    }
}
