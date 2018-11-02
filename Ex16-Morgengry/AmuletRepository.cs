using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex16_Morgengry
{
    public class AmuletRepository
    {
        private List<Amulet> amulets;

        public AmuletRepository()
        {
            amulets = new List<Amulet>();
        }
        public void AddAmulet(Amulet amulet)
        {
            amulets.Add(amulet);
        }

        public Amulet GetAmulet(string itemId)
        {
            Amulet resultat = null;

            for (int i = 0; i < amulets.Count; i++)
            {
                if (amulets[i].ItemId.Equals(itemId))
                {
                    resultat = amulets[i];
                }
            }
            return resultat;
        }
        /*public double GetTotalValue()
        {
            double total = 0;

            for (int i = 0; i < amulets.Count; i++)
            {
                total += Utility.GetValueOfAmulet(amulets[i]); //+= betyder at man lægger til
            }
            return total;
        }*/
    }
}