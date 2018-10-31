using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex16_Morgengry
{
   public class BookRepository
    {
        private List<Book> books;

        public BookRepository()
        {
            books = new List<Book>(); 
        }


        public void AddBook(Book book)
        {
            books.Add(book);
        }

        public Book GetBook(string itemId)
        {
            Book resultat = null;

            for (int i = 0; i < books.Count ; i++)
            {
                if (books[i].ItemId.Equals(itemId))
                {
                    resultat = books[i];
                }
            }
            return resultat;
        }



        public double GetTotalValue()
        {
            double total = 0;

            for (int i = 0; i < books.Count ; i++)
            {
                total += Utility.GetValueOfBook(books[i]); //+= betyder at man lægger til
            }
            return total;
        }

    }
}
