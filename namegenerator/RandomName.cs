using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace namegenerator
{
    public class RandomName
    {
        public string generateName()
        {
            //define random class
            Random rnd = new Random();

            //define arrays containing vowels, consonants, and adjoining letters
            string[] vowels = { "a", "e", "i", "o", "u" };
            string[] consonants = { "b", "c", "d", "f", "g", "h", "j", "k", "l", "m", "n", "p", "q", "r", "s", "t", "v", "w", "x", "z" };
            string[] abbreviations = { "br", "bl", "cr", "dw", "dr", "fr", "fl", "fw", "gu", "gl", "kl", "mw", "pr", "pl", "qu", "rh", "sw", "sl", "sr", "tr", "tl", "tw", "vr", "vl", "vw", "wh", "zr", "zl" };

            //25% probability of the name starting with a vowel
            int vstart = rnd.Next(0, 3);
            string name = "";
            if (vstart == 1)
            {
                name = name + vowels[rnd.Next(0, vowels.Length - 1)];
            }
            else
            {
                //if vowel start is negative, then create a 1 in 10 probability of the name starting with a y
                int ystart = rnd.Next(0, 10);
                if (ystart == 5)
                {
                    name = name + "y";
                }
            }

            //Define the first consonant or consonant pair of the name such as b or br

            //One in four chance of starting with a pair
            int pair_determine = rnd.Next(1, 4);
            if (pair_determine == 3)
            {
                name = name + abbreviations[rnd.Next(0, abbreviations.Length - 1)];
            }
            else
            {
                name = name + consonants[rnd.Next(0, consonants.Length - 1)];
            }

            //vowl in the first syllable with the first consonant
            int fvowel_pair = rnd.Next(1, 5);
            if (fvowel_pair == 3)
            {
                name = name + (vowels[rnd.Next(0, vowels.Length - 1)]) + vowels[rnd.Next(0, vowels.Length - 1)];
            }
            else
            {
                name = name + (vowels[rnd.Next(0, vowels.Length - 1)]);
            }

            //second consonant
            if (rnd.Next(1, 10) == 5)
            {
                name = name + consonants[rnd.Next(0, consonants.Length - 1)] + consonants[(rnd.Next(0, consonants.Length - 1))];
            }
            else
            {
                name = name + consonants[rnd.Next(0, consonants.Length - 1)];
            }

            //second vowel
            name = name + vowels[rnd.Next(0, vowels.Length - 1)];

            //final consonants
            if (rnd.Next(1, 4) == 3)
            {
                name = name + consonants[rnd.Next(0, consonants.Length - 1)];
            }

            //Capitalize the name
            string fletter = Convert.ToString(name[0]);
            string ename = "";
            for (int i = 1; i <= name.Length - 1; i++)
            {
                ename += name[i];
            }
            name = fletter.ToUpper() + ename;
            return name;
        }
    }
}
