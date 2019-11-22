using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Sample.Delegates
{
    public class IO
    {
        private delegate void Print(string s);
        private delegate string Read();

        private static Print P;
        private static Read R;

        public static void Output(string s)
        {
            if (P == null)
                P = new Print(PrintToConsole);

            P.Invoke(s);
        }

        public static string Input()
        {
            if (R == null)
                R = new Read(ReadFromConsole);

            return R.Invoke();
        }

        private static void PrintToConsole(string s)
        {
            Console.WriteLine(s);
        }

        private static string ReadFromConsole()
        {
            var input = Console.ReadLine();
            return input;
        }
    }
}
