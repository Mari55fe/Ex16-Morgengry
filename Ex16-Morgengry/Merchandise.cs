using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex16_Morgengry
{
    public abstract class Merchandise
    {
        private string itemId;

        /*public Merchandise(string itemid)
        {
            Itemid = itemid; // parameter ned i mellem mand
        }*/

        public string ItemId // Mellem mand
        {
            get{return itemId;}
            set{itemId = value;} // lægger value ned i vores private data
        }

        public override string ToString()
        {
            return $"ItemId: {ItemId}";
        }
    
    }
    
    
}
