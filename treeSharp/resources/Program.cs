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
            //if(System.IO.Directory.GetCurrentDirectory() != "C:\\") return;
            Console.WriteLine("Hello World!");
            string[] fakeTree = System.IO.File.ReadAllLines(@"C:\\Users\\George\\Documents\\fakeTree.txt");

            for(int i = 0; i < fakeTree.Length; i++)
            {
                Console.WriteLine(fakeTree[i]);
                if (debug && i > 10) break;
                if (Console.KeyAvailable) delay += 10;
                if(delay >= 1000)
                {
                    break;
                } else
                {
                    while(delayTimer(delay))
                    {
                        if (Console.KeyAvailable) delay += 10;
                    }
                }

            }

            Console.WriteLine("\nSystem clean. No viruses or hackers found.\n");
            //Console.ReadKey();
            return;
            
        }

        static void DebugPrint(bool debugBool, string toPrint)
        {
            if (debugBool) Console.WriteLine(toPrint);
        }

        static bool delayTimer(int millis)
        {
            Thread.Sleep(millis);
            return true;
        }
    }
}
