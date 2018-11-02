using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex16_Morgengry
{
    public class ValuableRepository
    {
        private List<IValuable> valuables;

        public ValuableRepository()
        {
            valuables = new List<IValuable>();
        }
        public void AddIValuable(IValuable valuable)
        {
            valuables.Add(valuable);
        }

        public IValuable GetValuable(string id)
        {
            IValuable result = null;
            valuables.ForEach(x =>
           {
               if (x is Merchandise merchandise)
               {
                   result = x;
               }
               else if (x is Course course)
               {
                   result = x;
               }
           });
            return result;
        }


    }
}
