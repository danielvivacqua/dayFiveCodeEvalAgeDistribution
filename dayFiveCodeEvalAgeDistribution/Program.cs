using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dayFiveCodeEvalAgeDistribution
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = 19;
            int personAge = Convert.ToInt32(line);

            if (personAge >= 0 && personAge <= 2)
            {
                Console.WriteLine("Still in Mama's arms");
            }
            else if (personAge >= 3 && personAge <= 4)
            {
                Console.WriteLine("Preschool Maniac");
            }
            else if (personAge >= 5 && personAge <= 11)
            {
                Console.WriteLine("Elementary school");
            }
            else if (personAge >= 12 && personAge <= 14)
            {
                Console.WriteLine("Middle school");
            }
            else if (personAge >= 15 && personAge <= 18)
            {
                Console.WriteLine("High school");
            }
            else if (personAge >= 19 && personAge <= 22)
            {
                Console.WriteLine("College");
            }
            else if (personAge >= 23 && personAge <= 65)
            {
                Console.WriteLine("Working for the man");
            }
            else if (personAge >= 66 && personAge <= 100)
            {
                Console.WriteLine("The Golden Years");
            }
            else
            {
                Console.WriteLine("This program is for humans");
            }
        }
    }
}
