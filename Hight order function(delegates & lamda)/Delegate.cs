using System;

namespace module1.Hight_order_function
{
    static class Delegate
    {
        static readonly Func<int, int> func = (int a) => a * 2; /*same as
        static readonly Func<int, int> func = SomeFunc */

        static readonly Action<double> action = (double a) => System.Console.WriteLine(a); /*same as
        static readonly Action<double> actio = SomeAction */

        static readonly Predicate<string> predicate = (string a) => a == default(string); /*same as
        static readonly Predicate<string> predicate = SomePredicate */


        static int SomeFunc(int a)
        {
            return a * 2;
        }

        /*shorthand

        static int SomeFunc(int a) =>
            a * 2;
        */

        static void SomeAction(double a)
        {
            System.Console.WriteLine(a);
        }

        /*shorthand

        static void SomeAction(double a) =>
           System.Console.WriteLine(a);
        */

        static bool SomePredicate(string a)
        {
            if (a == default(string))
                return true;

            return false;
        }

        //or
        static bool SomePredicateOth(string a)
        {
            return a == default(string);
        }

        /*shorthand

        static bool SomePredicateq(string a) =>
           a == default(string);
         */

    }
}
