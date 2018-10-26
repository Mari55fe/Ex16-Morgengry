using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex16_Morgengry
{
    public class Book : Merchandise
    {
        
        private string title;
        private double price;

        public Book(string itemid, string title, double price) : base (itemid)
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
        public override string ToString()
        {
            return $"ItemId: {Itemid}, Title: {Title}, Price: {Price}";
        }
    }
}
