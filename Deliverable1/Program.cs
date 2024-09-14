// See https://aka.ms/new-console-template for more information

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("        **************************   \n");
        Console.WriteLine("        Welcome to restocking tool. \n");
        Console.WriteLine("        **************************   \n");

        int sodaStock = 100;
        int sodaRestock = 40;

        int chipsStock = 40;
        int chipsRestock = 20;

        int candyStock = 60;
        int candyRestock = 40;

        /*****************************
        *  Checking stock for Soda
        ******************************/

        Console.WriteLine("How many Sodas have been sold today? " + sodaStock + " are in stock. ");
        int sodasSold = int.Parse(Console.ReadLine());
        //Console.WriteLine(sodasSold);

        if (sodasSold > sodaStock)
        {
            Console.WriteLine("The value is too high, don't adjust the stock. \n");
        }
        else
        {
            sodaStock -= sodasSold;
            Console.WriteLine("There are " + sodaStock + " Sodas left \n");

        }

        /*****************************
        *Checking stock for Chips
        ******************************/

        Console.WriteLine("How many Chips packets have been sold today? " + chipsStock + " are in stock. ");
        int chipsSold = int.Parse(Console.ReadLine());
        //Console.WriteLine(chipsSold);

        if (chipsSold > chipsStock)
        {
            Console.WriteLine("Too high, don't adjust the stock. \n");
        }
        else
        {
            chipsStock -= chipsSold;

            Console.WriteLine("There are " + chipsStock + " Chips left \n");

        }

        /*****************************
        *  Checking stock for Candy  *
        ******************************/

        Console.WriteLine("How many Chips packets have been sold today? " + candyStock + " are in stock. ");
        int candySold = int.Parse(Console.ReadLine());
        //Console.WriteLine(candySold);

        if (candySold > candyStock)
        {
            Console.WriteLine("Too high, don't adjust the stock. \n");
        }
        else
        {
            candyStock -= candySold;

            Console.WriteLine("There are " + candyStock + " Chips left \n");

        }

        Console.WriteLine("Thank you for filling out the values. Here's what needs to be restocked.\n");
        if (sodaStock <= sodaRestock)
        {
            Console.WriteLine("Soda needs to be restocked. \n");

        }
        if (chipsStock <= chipsRestock)
        {
            Console.WriteLine("Chips needs to be restocked.\n");
        }

        if (candyStock <= candyRestock)
        {
            Console.WriteLine("Candy needs to be restocked.\n");
        }
        else
        {
            Console.WriteLine("Nothing is needed to restock for other items.");
        }
    }
}

