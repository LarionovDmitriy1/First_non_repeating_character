using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_non_repeating_character;

public class NonRepeating
{
    public static string FirstNonRepeatingLetter(string s)
    {
        int counter = 0;
        foreach (char c in s)
        {
            foreach (char c2 in s)
            {
                if (char.ToLower(c) == char.ToLower(c2))
                {
                    counter++;
                }
                if (counter > 1)
                {
                    break;
                }
            }
            if (counter == 1) { return c.ToString(); }
            else { counter = 0; }
        }
        return "";
    }
}
