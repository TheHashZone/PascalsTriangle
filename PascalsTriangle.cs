using System;

namespace PascalsTriangle
{

    class program
    {
        public static int rows = 1;
        class output
        {
            public static void Main()
            {
                Console.Write("How many rows? ");
                try
                {
                    rows = int.Parse(Console.ReadLine());
                }

                catch (System.FormatException)
                {
                    Console.WriteLine("The number of rows has to be a whole number!");
                    System.Environment.Exit(1);
                }

                if (rows > 20)
                {
                    Console.WriteLine("I have set a limit of 20.");
                    System.Environment.Exit(1);
                }

                Console.WriteLine("\n");

                PascalsTriangle.create();

                Console.WriteLine("\n");
            }
        }


        class PascalsTriangle
        {
            static int edge;
            static int center;
            public static void create()
            {
                for (int i = 0; i <= rows; i++) // for loop to add more rows.
                {
                    for (center = 1; center <= rows - i; center++)
                    {
                        Console.Write("  ");
                    }

                    for (int j = 0; j <= i; j++)
                    {
                        if (j == 0 || i == 0)
                        {
                            edge = 1;
                        }

                        else
                        {
                            edge = edge * (i - j + 1) / j;
                        }

                        Console.Write($"{edge}   ");
                    }
                    
                    Console.Write("\n");
                }
            }
        }

    }
}