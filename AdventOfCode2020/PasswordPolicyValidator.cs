using AdventOfCode2020.Models;
using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode2020
{
    class PasswordPolicyValidator
    {
        public List<PasswordPolicy> GetValidPolicies(List<PasswordPolicy> passwordPolicies)
        {
            var validPolicies = new List<PasswordPolicy>();

            foreach(var passwordPolicy in passwordPolicies)
            {
                var occurringLetterCount = passwordPolicy.Password.Count(character => character == passwordPolicy.OccurringLetter);

                if (passwordPolicy.MinimumOccurrences <= occurringLetterCount &&
                    occurringLetterCount <= passwordPolicy.MaximumOccurrences)
                {
                    validPolicies.Add(passwordPolicy);
                }
            }

            return validPolicies;
        }
    }
}
