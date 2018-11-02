using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex16_Morgengry
{
     public class MerchandiseRepository
    {
        private List<Merchandise> merchandise1;

        public MerchandiseRepository()
        {
            merchandise1 = new List<Merchandise>();
        }
        public void AddMerchandise(Merchandise merchandise)
        {
            merchandise1.Add(merchandise);
        }

        public Merchandise GetMerchandise(string itemId)
        {
            Merchandise resultat = null;

            for (int i = 0; i < merchandise1.Count; i++)
            {
                if (merchandise1[i].ItemId.Equals(itemId))
                {
                    resultat = merchandise1[i];
                }
            }
            return resultat;
        }
        public double GetTotalValue()
        {
            double total = 0;

            for (int i = 0; i < merchandise1.Count; i++)
            {
                total += Utility.GetValueOfMerchandise(merchandise1[i]); //+= betyder at man lægger til
            }
            return total;
        }
    }
}
