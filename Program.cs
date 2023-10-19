
// HomeSales PT2 
// By Addison Roy


using System;
class HomeSales
{
    static void Main()
    {
        string[] names = { "Danielle", "Edward", "Francis" };
        double[] totals = new double[3];

        char initial;
        double saleAmount;

        do
        {
            Console.Write("Homesales program for Danielle, Edward, and Francis \n");
            Console.Write("Enter a salesperson initial (D, E, F) or Z to show totals: ");
            initial = char.ToUpper(Console.ReadKey().KeyChar);

            if (initial == 'Z')
            {
                break;
            }

            Console.WriteLine();

            int index = Array.IndexOf(new char[] { 'D', 'E', 'F' }, initial);

            if (index != -1)
            {
                Console.Write($"Enter the sale amount for {names[index]}: ");
                if (double.TryParse(Console.ReadLine(), out saleAmount) && saleAmount >= 0)
                {
                    totals[index] += saleAmount;
                }
                else
                {
                    Console.WriteLine("Invalid enter a number!");
                }
            }
            else
            {
                Console.WriteLine("Enter a valid initial (D, E, F)!");
            }

            Console.WriteLine();
        } while (true);

        double grandTotal = totals[0] + totals[1] + totals[2];

        Console.WriteLine("\nSales Report:");
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine($"Total sales for {names[i]}: {totals[i]}");
        }
        Console.WriteLine($"Grand Total: {grandTotal}");

        int highestIndex = Array.IndexOf(totals, totals.Max());
        Console.WriteLine($"Salesperson with highest revenue: {names[highestIndex]}");
    }
}

