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
        public void Addamulet(Amulet amulet)
        {
            amulets.Add(amulet);
        }

        public Amulet GetAmulet(string itemid)
        {
            Amulet resultat = null;

            for (int i = 0; i < amulets.Count; i++)
            {
                if (amulets[i].ItemId.Equals(itemid))
                {
                    resultat = amulets[i];
                }
                return resultat;
            }
            
        }
    }
}