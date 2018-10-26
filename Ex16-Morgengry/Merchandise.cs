using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex16_Morgengry
{
    public class Merchandise
    {
        private string itemid;

        public Merchandise(string itemid)
        {
            Itemid = itemid; // parameter ned i mellem mand
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

        public override string ToString()
        {
            return $"ItemId: {Itemid}";
        }
    
    }
    
    
}
