using AdventOfCode2020.Mappers;
using NUnit.Framework;

namespace AdventOfCode2020.IntegrationTests.Day1
{
    [TestFixture]
    class Day2
    {
        [Test]
        public void Part1_GetValidPolicies()
        {
            var fileReader = new FileReader();
            var fileExtension = @"C:\Users\ucpayto\source\repos\AdventOfCode2020\day-2-input.txt";
            var stringPolicies = fileReader.GetStringListsFromFile(fileExtension);

            var passwordPolicies = PasswordPolicyMapper.Map(stringPolicies);

            var validator = new PasswordPolicyValidator();
            var validPolicies = validator.GetValidPolicies(passwordPolicies);

            var twentyTwenty = 2020;
        }
    }
}
