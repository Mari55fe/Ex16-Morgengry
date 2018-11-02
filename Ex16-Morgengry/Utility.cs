using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex16_Morgengry
{
     public class Utility
     {
        private double low = 12.5;
        private double medium = 20.0;
        private double high = 27.5;
        private double påbegyndt = 875;
        public double Low
        {
            get
            {
                return low;
            }
            set
            {
                Low = low;
            }
        }
        public double Medium
        {
            get
            {
                return medium;
            }
            set
            {
                medium = value;
            }
        }
        public double High
        {
            get
            {
                return high;
            }
            set
            {
                high = value;
            }
        }

        public double Påbegyndt
        {
            get
            {
                return påbegyndt;
            }
            set
            {
                påbegyndt = value;
            }
        }




        public static double GetValueOfMerchandise(Merchandise merchandise)
        {
            double price = 0; 
            if (merchandise is Book book)
            {
                //Book book = (Book)merchandise; [kan også gøres i stedet for book i  if (merchandise is Book book)]
                price = book.Price;
            }
            if (merchandise is Amulet amulet)
            {
                //Amulet amulet = (Amulet)merchandise;
                price = 12.5;

                if (amulet.Quality == Level.medium)
                {
                    price = 20.0;
                }

                if (amulet.Quality == Level.high)
                {
                    price = 27.5;
                }
            }
            return price;
        }

        /*static public double GetValueOfBook(Book book)
       {
            double price = book.Price;
            return price;
       }

       static public double GetValueOfAmulet(Amulet amulet)
       {
            double price = 12.5;


            if (amulet.Quality == Level.medium)
            {
                price = 20.0; 
            }

            if (amulet.Quality == Level.high)
            {
                price = 27.5;
            }

            return price;
       }*/

       static public double GetValueOfCourse(Course course)
       {
            double minutter = course.DurationInMinutes;
            double hoursInitialized = Math.Ceiling(minutter / 60); // en metode på hvordan man runder op 
            double price = hoursInitialized * 875.00;
            return price;
       }
        
     } 
}
