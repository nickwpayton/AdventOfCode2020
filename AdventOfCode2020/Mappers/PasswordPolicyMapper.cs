using AdventOfCode2020.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2020.Mappers
{
    public static class PasswordPolicyMapper
    {
        public static List<PasswordPolicy> Map(List<List<string>> policies)
        {
            var mappedPolicies = new List<PasswordPolicy>();

            foreach(var policy in policies)
            {
                var mappedPolicy = Map(policy);
                mappedPolicies.Add(mappedPolicy);
            }

            return mappedPolicies;
        }

        public static PasswordPolicy Map(List<string> policy)
        {
            var mappedPolicy = new PasswordPolicy();

            var occurrences = policy[0].Split('-');
            mappedPolicy.MinimumOccurrences = int.Parse(occurrences[0]);
            mappedPolicy.MaximumOccurrences = int.Parse(occurrences[1]);

            mappedPolicy.OccurringLetter = policy[1].Remove(1);

            mappedPolicy.Password = policy[2];

            return mappedPolicy;
        }
    }
}
