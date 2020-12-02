using AdventOfCode2020.Mappers;
using NUnit.Framework;

namespace AdventOfCode2020.IntegrationTests.Day1
{
    [TestFixture]
    class Day2
    {
        [Test]
        public void Day1_FindTwoEntriesSummingToTotal_andMultiplyThem()
        {
            var fileReader = new FileReader();
            var expenseReport = new ExpenseReport();
            var fileExtension = @"C:\Users\ucpayto\source\repos\AdventOfCode2020\day-2-input.txt";
            var stringPolicies = fileReader.GetStringListsFromFile(fileExtension);

            var passwordPolicies = PasswordPolicyMapper.Map(stringPolicies);

            var twentyTwenty = 2020;
        }
    }
}
