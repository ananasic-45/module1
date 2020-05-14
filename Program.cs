using System;
using System.Collections;
namespace HelloApp
{

    class Program
    {
        static void Main(string[] args)
        {
            var result = Task2(new string[] { "пича", "воле" });
        }

        static string Task2(string[] aaa)
        {
            string vad = string.Empty;

            for (int i = 0; i < aaa.Length; i++)
                vad += aaa[i];

            return vad;
        }
    }
}