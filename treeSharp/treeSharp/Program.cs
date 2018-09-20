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
            bool slashGArg = false;
            if (args.Length > 0) { // if /g is entered, run anywhere. otherwise, only run in the C:\ directory
                if (args[0] == "/g") {
                    slashGArg = true;
                }
            }
            if(System.IO.Directory.GetCurrentDirectory() != @"C:\" && slashGArg == false) return;
            string treeFile = treeSharp.Properties.Resources.fakeTree; // get the embedded fake tree output
            string[] fakeTree = treeFile.Split('\n'); // a line by line representation of the fake tree

            for(int i = 0; i < fakeTree.Length; i++)
            {
                if (debug && i > 10) break; // if debug mode is on it will only do 10 lines
                if (Console.KeyAvailable) // if they type something
                {
                    delay += 25; // increment the delay
                    hackerTyper = hackerTyper + Console.ReadKey().KeyChar; // figure out what key they pressed and save it
                    Console.WriteLine(fakeTree[i].Remove(1, 1)); // remove the second character to get rid of the annoying offset
                    Thread.Sleep(delay);
                    continue;
                }
                Thread.Sleep(delay);
                if (delay >= 5000) break;
                Console.WriteLine(fakeTree[i]);
            }

            Console.WriteLine("\n\nSystem clean. No viruses or hackers found.");
            if (debug) Console.ReadKey();
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
