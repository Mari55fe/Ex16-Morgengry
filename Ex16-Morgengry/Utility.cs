using System;

namespace Ex16_Morgengry
{
    public class Utility
     {
        private double low = 12.5;
        private double medium = 20.0;
        private double high = 27.5;
        private double course = 825.00;

       public double LowQualityValue
        {
            get { return low; }
            set { low = value; }
        }

        public double MediumQualityValue
        {
            get { return medium; }
            set { medium = value; }
        }
        public double HighQualityValue
        {
            get { return high; }
            set { high = value; }
        }
        public double CourseQualityValue
        {
            get { return course; }
            set { course = value; }
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
