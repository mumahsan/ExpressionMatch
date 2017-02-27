using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ExpressionMatch.BL
{
    public class Class1
    {
        public bool isMatch(string toMatch, string pat)
        {
            // Instantiate the regular expression object.
            System.Text.RegularExpressions.Regex r = new Regex(pat, RegexOptions.IgnoreCase);

            // Match the regular expression pattern against a text string.
            Match m = r.Match(toMatch);
            if (m.Success)
            {
                return true;
            }
            else
                return false;
        }
    }
}
