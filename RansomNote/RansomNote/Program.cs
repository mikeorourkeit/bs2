using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RansomNote
{
    class Program
    {
        // check to see if a string of words is conatained within a "magazine" - report true or false
        public static char[] magazine = "qqwwweeeeerrrrttttyyyuuuuuiiiiioooooppppaaaaassssddddfffgggghhhjjjkkkllllzzxxccccvvbbbbnnnnmmmm.....,,,,,!!!!!££€€$$--                                            0000000000555111222333444666777888999".ToCharArray();
        public static char[] ransomNote = "50,000,000".ToCharArray();
        //public string ransomnote = "50,000,000";
        public static bool bombed = false;
        public static Stopwatch sw = new Stopwatch();
        static void Main(string[] args)
        {
            // does the required task but only in string
            //if (magazine.Contains(ransomnote.ToLower()))
            //{
            //    Console.WriteLine("Your message was : {0}", ransomote);
            //    Console.WriteLine("You can write this message");
            //    Console.WriteLine("---");
            //    Console.ReadKey();
            //}
            //else
            //{
            //    Console.WriteLine("Your message was : {0}", ransomnote);
            //    Console.WriteLine("You cannot write this message");
            //    Console.ReadKey();
            //}
            runTest();
            

        }// end main

        public static bool runTest()
        {
            // copies the char arrays
            char[] mag = (char[])(magazine.Clone());
            char[] note = (char[])(ransomNote.Clone());

            int idxNote = 0;
            do
            {
                int idxMag = 0;
                do
                {
                    if (note[idxNote] == mag[idxMag])
                    {
                        mag.
                        bombed = true;
                    }
                }
                while
                { bombed == true; }
            }
            for (int i = 0; i < ransomNote.Length; i++)
            {
                if (Array.IndexOf(magazine, i) > -1)
                {
                    //if(magazine.Contains(i))
                    for (int j = 0; j < magazine.Length; j++)
                    {

                    }
                }
                else
                {
                    Console.WriteLine("Your message was : {0}", ransomNote);
                    Console.WriteLine("You cannot write this message");
                    Console.ReadKey();
                }
            }
            //foreach(char in )
            //{

            //}
        }
    }// end program

}// end namespace
