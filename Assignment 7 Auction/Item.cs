using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_7_Auction
{
    internal class Item
    {
        private string Description;
        private double ReservePrice;
        private double HighestBid = 0;
        private int BidderID = 0; //the ID of the highest bidder

        public Item(string description, double reserveprice)
        {
            Description = description;
            ReservePrice = reserveprice;
        }

        public string GetDescripton()
        {
            return Description;
        }

        public double GetReservePrice()
        {
            return ReservePrice;
        }

        public double GetHighestBid()
        {
            return HighestBid;
        }

        public int GetHighestBidderID()
        {
            return BidderID;
        }
        public bool SetHighestBid(double BidAmount, int bidderid)
        {
            if (BidAmount > HighestBid)
            {
                BidderID = bidderid;
                HighestBid = BidAmount;
                return true;
            }
            return false;
        }

        public bool IsSold()
        {
            if (HighestBid > ReservePrice)
            {
                return true;
            }
            return false;
        }
    }
}
