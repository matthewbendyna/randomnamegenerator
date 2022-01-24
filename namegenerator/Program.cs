//Generate random names

using System;
using System.Text.RegularExpressions;

namespace namegenerator
{
    public static class Program
    {
        public static int name_count=5;
        
        public static void Main(string[] arg)
        {
            RandomName rn = new RandomName();
            string[] namelist = new string[name_count];
            for(int i = 0; i< namelist.Length; i++)
            {
                namelist[i] = rn.generateName();
            }
            foreach(string name in namelist)
            {
                Console.WriteLine(name);
            }
        }
    }
}