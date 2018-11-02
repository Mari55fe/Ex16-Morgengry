using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex16_Morgengry
{
    
    public class Amulet : Merchandise
    {
        private  double low = 12.5;
        private  double medium = 20.0;
        private  double high = 27.5;
        private string design; // private variable
        private Level quality;

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

        

        public Amulet(string itemId, Level quality, string design) //:base (ItemId) [til brug i abstract class]
        {
            ItemId = itemId;
            Design = design; // parameter ned i mellem mand
            Quality = quality;
        }

        public Amulet(string itemId, Level quality) : this(itemId, quality, ""){}
        public Amulet(string itemId) : this(itemId, Level.medium, ""){}

       
        public string Design // Mellem mand / property
        {
            get {return design;}
            set { design = value;}  // lægger value ned i vores private data
        }
        public Level Quality // Mellem mand / property
        {
            get { return quality; }
            set { quality = value; } // lægger value ned i vores private data
        }

        public override string ToString()
        {
            return $"ItemId: {ItemId}, Quality: {Quality}, Design: {Design}";
        }

        public override double GetValue()
        {
            if (Quality == Level.low)
            {
                return LowQualityValue;
            }

            else if (Quality == Level.medium)
            {
                return MediumQualityValue;
            }

            else if (Quality == Level.high)
            {
                return HighQualityValue;
            }
            return 0;
        }
            
        
    }

}
