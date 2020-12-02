using AdventOfCode2020.Models;
using System.Collections.Generic;

namespace AdventOfCode2020
{
    class PasswordPolicyValidator
    {
        public List<PasswordPolicy> GetValidPolicies(List<PasswordPolicy> passwordPolicies)
        {
            var validPolicies = new List<PasswordPolicy>();

            foreach(var passwordPolicy in passwordPolicies)
            {
                if (passwordPolicy.Password[passwordPolicy.FirstCharLocation] == passwordPolicy.OccurringLetter ^
                    passwordPolicy.Password[passwordPolicy.SecondCharLocation] == passwordPolicy.OccurringLetter)
                {
                    validPolicies.Add(passwordPolicy);
                }
            }

            return validPolicies;
        }
    }
}
