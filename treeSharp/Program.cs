using System;
using System.Windows.Input;
using System.Collections.Generic;
using System.Threading;

namespace treeSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            bool debug = false;
            int delay = 0;
            string hackerTyper = "";
            //if(System.IO.Directory.GetCurrentDirectory() != "C:\\") return;
            string treeFile = treeSharp.Properties.Resources.fakeTree;
            string[] fakeTree = treeFile.Split('\n');
               /*System.IO.File.ReadAllLines(@"C:\\Users\\George\\Documents\\fakeTree.txt");*/

            for(int i = 0; i < fakeTree.Length; i++)
            {
                Console.WriteLine(fakeTree[i]);
                if (debug && i > 10) break;
                if (Console.KeyAvailable)
                {
                    delay += 25;
                    hackerTyper = hackerTyper + Console.ReadKey().KeyChar;
                }
                Thread.Sleep(delay);
                if (delay >= 500) break;
            }

            Console.WriteLine("\n\nSystem clean. No viruses or hackers found.");
            //Console.WriteLine("")
           // hackerTyper = Reverse(hackerTyper);
            //Console.WriteLine("\nC:\\>" + hackerTyper);
            //Console.WriteLine("\'" + hackerTyper + "\' is not recognized as an internal or external command,\noperable program or batch file.");
            //Console.ReadKey();
            return;
            
        }

        static void DebugPrint(bool debugBool, string toPrint)
        {
            if (debugBool) Console.WriteLine(toPrint);
        }

        public static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
