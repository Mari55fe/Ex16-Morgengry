using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex16_Morgengry
{
    public class Book
    {
        private string itemid;
        private string title;
        private double price;

        public Book(string itemid, string title, double price)
        {
            Itemid = itemid;
            Title = title;
            Price = price;
        }

        public Book(string itemid, string title) : this(itemid, title, 0)
        {
        }

        public Book(string itemid) : this(itemid, "", 0)
        {
        }

        public string Itemid
        {
            get
            {
                return itemid;
            }
            set
            {
                itemid = value;
            }
        }
        public string Title
        {
            get
            {
                return title;
            }
            set
            {
                title = value;
            }
        }
        public double Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
            }
        }
        override
                public string ToString()
        {
            string result = null;

            result += "ItemId: " + itemid + ", ";
            result += "Title: " + title + ", ";
            result += "Price: " + price;

            return result;
        }
    }
}
