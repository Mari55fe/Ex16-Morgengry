using System;
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
        private Level quality;

        public Amulet(string itemid, Level quality, string design)
        {
            Itemid = itemid; // parameter ned i mellem mand
            Design = design; // parameter ned i mellem mand
            Quality = quality;
        }

        public Amulet(string itemid, Level quality) : this(itemid, quality, ""){}
        public Amulet(string itemid) : this(itemid, Level.medium, ""){}

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
        public string Design // Mellem mand / property
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
        public Level Quality // Mellem mand / property
        {
            get
            {
                return quality;
            }

            set
            {
                quality = value;  // lægger value ned i vores private data
            }

        }

        override
         public string ToString()
        {
            string result = null;

            result += "ItemId: " + itemid + ", ";
            result += "Quality: " + quality + ", ";
            result += "Design: " + design;

            return result;
        }

    }

}
