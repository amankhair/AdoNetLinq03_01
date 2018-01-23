using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNetLinqConsApp03
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        static void Example()
        {
            int[] seq1 = { 1, 2, 3 };
            int[] seq2 = { 3, 4, 5 };
            IEnumerable<int> concat = seq1.Concat(seq2); //vozvrashaet elementy 1 i 2 posledovatelnosti

            IEnumerable<int> union = seq1.Union(seq2); //tozhe samoe no ubiraet povtoreniya
        }

        //Intersect
        //Except
        static void Example2()
        {
            int[] seq1 = { 1, 2, 3 };
            int[] seq2 = { 3, 4, 5 };

            IEnumerable<int> commonality = seq1.Intersect(seq2); //obshiy dlya dvuh posledovatelnosti

            IEnumerable<int> difference = seq1.Except(seq2); //iz 1 pervoi, kotoryh net vo vtoroi

            //not in, non exests - sql
        }

        static void Example3()
        {
            int[] seq1 = { 1, 2, 3 };
            string[] seq2 = { "e3", "4", "5" };

            IEnumerable<int> seq1int =  seq2.Cast<int>(); //VOZBUZHDAET ISKLUCHENIYA

            IEnumerable<int> seq1IntNotErr = seq2.OfType<int>(); //ignoriruet

            var asEn = seq1IntNotErr.AsEnumerable();

            var asEnQ = seq1IntNotErr.AsQueryable();
        }
    }
}
