public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello, welcome to the restocking tool.");
        Console.WriteLine();
        Console.WriteLine("How many Sodas have been sold today? 100 are in stock.");
        int sodaSold = int.Parse(Console.ReadLine());
        int sodaStock;
        sodaStock = 100 - sodaSold;
        if (sodaSold <= 100)
        {
            Console.WriteLine("The number of sodas remaining is " + sodaStock);
        }
        else if (sodaSold > 100)
        {
            Console.WriteLine("Value too high! Stock not adjusted.");
        }
        Console.WriteLine();
        Console.WriteLine("How many chips have been sold today? 40 are in stock.");
        int chipSold = int.Parse(Console.ReadLine());
        int chipStock;
        chipStock = 40 - chipSold;
        if (chipSold <= 40)
        {
            Console.WriteLine("The number of chips remaining is " + chipStock);
        }
        else if (chipSold > 40)
        {
            Console.WriteLine("Value too high! Stock not adjusted.");
        }
        Console.WriteLine();
        Console.WriteLine("How many Candies have been sold today? 60 are in stock.");
        int candySold = int.Parse(Console.ReadLine());
        int candyStock;
        candyStock = 60 - candySold;
        if (candySold <= 60)
        {
            Console.WriteLine("The number of candies remaining is " + candyStock);
        }
        if (candySold > 60)
        {
            Console.WriteLine("Value too high! Stock not adjusted.");
        }
        Console.WriteLine();
        Console.WriteLine("Thank you for filling out the values! Here's what needs to be restocked:");
        Console.WriteLine();

        if (sodaStock <= 40 && sodaStock >= 0)
        {
            
            Console.WriteLine("Soda needs to be restocked.");
        }


        else if (chipStock <= 20 && chipStock >= 0)
        {
            Console.WriteLine("Chips need to be restocked.");
        }


        else if (candyStock <= 40 && candyStock >= 0)
        {
            Console.WriteLine("Candy needs to be restocked.");
        }

        else
        {
            Console.WriteLine("Nothing to be restocked. Go take a break.");
        }
        Console.WriteLine();
        Console.WriteLine("Thank you for using the restocking Tool!");




    }


}