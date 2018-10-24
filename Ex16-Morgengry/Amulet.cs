using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex16_Morgengry
{
    public class Amulet
    {
      
        private string itemid; // privat variable
        private string design; // private variable

        public enum Level
        {
            Low,
            Medium,
            High
        };

        private Level quality;

        public Amulet (string itemid, Level quality, string design )
        {
            Itemid = itemid; // parameter ned i mellem mand
            Design = design; // parameter ned i mellem mand
        }

        public Amulet (string itemid, Level quality) : this (itemid, quality, "No Design" )
        {
        }
        public Amulet(string itemid) : this (itemid, 0 , "No Design")
        {
        }

        public string Itemid // Mellem mand
        {
            get
            {
                return itemid;
            }

            set
            {
                itemid = value; // lægger value ned i vores private data
            }
        }
        public string Design // Mellem mand / property
        {
            get
            {
                return design;
            }

            set
            {
                design = value;  // lægger value ned i vores private data
            }

        }
        public Level Quality // Mellem mand / property
        {
            get
            {
                return quality;
            }

            set
            {
                quality = value;  // lægger value ned i vores private data
            }

        }

    }

    class Book
    {
        private string itemid;
        private string title;
        private double price; 

        public Book (string itemid, string title, double price)
        {
            Itemid = itemid;
            Title = title;
            Price = price;
        }

        public Book (string itemid, string title) : this(itemid, title, 0)
        {
        }

        public Book (string itemid) : this (itemid, "No Title", 0)
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

    }

}
