using System;
using System.Collections;
namespace HelloApp
{

    class Program
    {
        // метод Main - стартовая точка приложения
        static void Main (string[] args)
        {
            // int[] age = new int[3] { 1, 2, 3 };
            // foreach (var item in age)
            //     System.Console.WriteLine(item);

            var result = Task2 (new string[] { "пича", "воле" });

        }

        // static int Task1(int a, string b)
        // {
        //     var qqq = 12;
        //     return qqq;
        // }

        static string Task2 (string[] aaa)
        {
            string vad = string.Empty;

            for (int i = 0; i < aaa.Length; i++)
            {
                vad += aaa[i];
            }

            return vad;
        }
    }
}