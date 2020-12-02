using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2020
{
    [TestFixture]
    class IntegrationTests
    {
        [Test]
        public void FindTwoEntriesSummingToTotal_andMultiplyThem()
        {
            var fileReader = new FileReader();
            var expenseReport = new ExpenseReport();
            var fileExtension = @"C:\Users\ucpayto\source\repos\AdventOfCode2020\day-1-input.txt";
            var entries = fileReader.GetIntsFromFile(fileExtension);
            var twentyTwenty = 2020;

            var candidates = expenseReport.FindTwoEntriesSummingToTotal(twentyTwenty, entries);

            var item1 = candidates.Item1;
            var item2 = candidates.Item2;

            var total = item1 * item2;
        }

        [Test]
        public void FindThreeEntriesSummingToTotal_andMultiplyThem()
        {
            var fileReader = new FileReader();
            var expenseReport = new ExpenseReport();
            var fileExtension = @"C:\Users\ucpayto\source\repos\AdventOfCode2020\day-1-input.txt";
            var entries = fileReader.GetIntsFromFile(fileExtension);
            var twentyTwenty = 2020;


            var candidates = expenseReport.FindThreeEntriesSummingToTotal(twentyTwenty, entries);

            var total = candidates.MultiSum();
        }
    }
}
