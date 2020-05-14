namespace gagaga.Cycle
{
    static class Cycle
    {
        static readonly int[] SOME_ARRAY = new int[] { 1, 2, 3, 4, 5 };

        static void For()
        {
            for (int i = 0; i < SOME_ARRAY.Length; i++)
                System.Console.WriteLine(SOME_ARRAY[i]);
        }

        static void ForEach()
        {
            foreach (var item in SOME_ARRAY)
                System.Console.WriteLine(item);
        }

        static void While()
        {
            var counter = default(int); /* Same as 
            int counter = 0             */

            while (SOME_ARRAY.Length > counter)
                System.Console.WriteLine(SOME_ARRAY[counter]);
        }
    }
}