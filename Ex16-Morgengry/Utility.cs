using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex16_Morgengry
{
     public class Utility
    {
       static public double GetValueOfBook(Book book)
        {
            double price = book.Price;
            return price;
        }

       static public double GetValueOfAmulet(Amulet Amulet)
        {
            double price = 12.5;


            if (Amulet.Quality == Level.medium)
            {
                price = 20.0; 
            }

            if (Amulet.Quality == Level.high)
            {
                price = 27.5;
            }

            return price;
        }

       static public double GetValueOfCourse(Course course)
        {
            double minutter = course.DurationInMinutes;
            double hoursInitialized = Math.Ceiling(minutter / 60); // en metode på hvordan man runder op 
            double price = hoursInitialized * 875.00;
            return price;
        }
        
    }
}
