using System;

namespace Assignment_7_Auction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Item[] items =
            {
                new Item("Lamp", 50),
                new Item("Teddy Bear", 150),
                new Item("Gun", 250),
                new Item("Old Coffee", 550),
            };
            while (true)
            {
                PrintItems(items);
                PlaceBid(items);
                PrintSoldItems(items);
            }
       
        }

        static void PrintItems(Item[] items)
        {
            for(int i = 0; i < 4; i++)
            {
                Console.WriteLine($"{i, -5}{items[i].GetDescripton(), -30}{items[i].GetHighestBid(),-10}");
            }
        }

        static void PlaceBid(Item[] items)
        {
            int ItemToBid;
            int InputBidID;
            int InputBidAmount;

            Console.WriteLine("What is your BidderID?");
            InputBidID = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What item would you like to bid on?");
            ItemToBid = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("How much would you like to bid?");
            InputBidAmount = Convert.ToInt32(Console.ReadLine());

            if (items[ItemToBid].SetHighestBid(InputBidAmount, InputBidID))
            {
                Console.WriteLine("Your bid has been placed");
            }
            else
            {
                Console.WriteLine("Your bid isn't high enough");
            }
        }
        static void PrintSoldItems(Item[] items)
        {
            for(int i = 0; i< 4; i++)
            {
                if (items[i].IsSold())
                {
                    Console.WriteLine(" ");
                    Console.WriteLine("Item " + i + ": " + items[i].GetDescripton() + " has been sold for " + items[i].GetHighestBid() + " to BidderID " + items[i].GetHighestBidderID());
                    Console.WriteLine(" ");
                }
            }
        }
    }
}
