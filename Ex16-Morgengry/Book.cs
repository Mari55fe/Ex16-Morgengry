﻿using System;
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

        public Book(string itemId, string title, double price) //:base (itemId) [til brug i abstract class]
        {
            ItemId = itemId;
            Title = title;
            Price = price;
        }

        public Book(string itemId, string title) : this(itemId, title, 0)
        {
        }

        public Book(string itemId) : this(itemId, "", 0)
        {
        }

        public string Title
        {
            get { return title; }
            set { title = value; }
        }    
        
        public double Price
        {
            get { return price; }
            set { price = value; }
        }
        public override string ToString()
        {
            return $"ItemId: {ItemId}, Title: {Title}, Price: {Price}";
        }

        public override double GetValue()
        {
            return Price;
        }
    }
}
