using System;

namespace Ex16_Morgengry
{
    public class Utility
     {
        private static double low = 12.5;
        private static double medium = 20.0;
        private static double high = 27.5;
        private static double course = 875.00;

        public static double LowQualityValue
        {
            get { return low; }
            set { low = value; }
        }

        public static double MediumQualityValue
        {
            get { return medium; }
            set { medium = value; }
        }
        public static double HighQualityValue
        {
            get { return high; }
            set { high = value; }
        }
        public static double CourseHourValue
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
                
                if (amulet.Quality == Level.low)
                {
                   price = LowQualityValue; 
                }

                if (amulet.Quality == Level.medium)
                {
                    price = MediumQualityValue;
                }

                if (amulet.Quality == Level.high)
                {
                    price = HighQualityValue;
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

       public static double GetValueOfCourse(Course course)
       {
            double minutter = course.DurationInMinutes;
            double hoursInitialized = Math.Ceiling(minutter / 60); // en metode på hvordan man runder op 
            double price = hoursInitialized * CourseHourValue;
            return price;
       }
        
     } 
}
