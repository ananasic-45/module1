namespace gagaga.Conditions
{
    public static class Conditions
    {
        const bool TRUE_BOOL = true;
        const bool FALSE_BOOL = false;

        const int THREE = 3;
        const int FIVE = 5;
        public static void Condition()
        {
            {
                if (THREE == 4)
                {
                    System.Console.WriteLine("If contidions return 'true', do it");
                }
                else if (FIVE < 1)
                {
                    System.Console.WriteLine("If contidions return 'true', do it");
                }
                else
                {
                    System.Console.WriteLine("If no one condition return 'true', do it");
                }
            }

            {

                //Shorthand, if code block is single line
                if (THREE == 4)
                    System.Console.WriteLine("If contidions return 'true', do it");
                else if (FIVE < 1)
                    System.Console.WriteLine("If contidions return 'true', do it");
                else
                    System.Console.WriteLine("If no one condition return 'true', do it");
            }

            {
                //Same
                if (THREE == 4 && FIVE < 1)
                    System.Console.WriteLine("If contidions return 'true', do it");
                else
                    System.Console.WriteLine("If no one condition return 'true', do it");
            }

            {
                //Just do it, if condition successed 
                if (THREE == 4 && FIVE < 1)
                    System.Console.WriteLine("If contidions return 'true', do it");
            }
        }

        public static void ConditionDatReturnSmt()
        {
            {

                var result = default(string); /* same as 
                string result = null;            */

                if (THREE == 3)
                    result = $"Yeap, value of {nameof(THREE)} is 3";
                else if (THREE < 4)
                    result = $"Yeap, value of {nameof(THREE)} is lesser then 4";
                else
                    result = "I dunno";

                //Or
                if (THREE == 3)
                    result = $"Value of {nameof(THREE)} its 3";
                else
                    result = "No it doesn`t";
            }

            {
                //Same
                string result = THREE == 3
                            ? $"Yeap value of {nameof(THREE)} is 3"
                                : THREE < 4
                                    ? $"Yeap value of {nameof(THREE)} is lesser then 4"
                                    : "I dunno";
                //Or
                result = THREE == 3 ? $"Value of {nameof(THREE)} its 3" : "No it doesn`t";
            }
        }
    }
}