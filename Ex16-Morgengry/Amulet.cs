﻿using System;
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

        Level quality;

        public Amulet (string itemid, string design, Level quality)
        {
            Itemid = itemid; // parameter ned i mellem mand
            Design = design; // parameter ned i mellem mand
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
        public string Design // Mellem mand
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
    }

    class Book
    {
        private string itemid;
        private string title;
        private double price; 

        public Book (string itemid, string title, double price)
        {

        }
    }
}
