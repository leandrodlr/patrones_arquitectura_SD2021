using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonedasConsoleApp
{
    //Target
    public class CurrencyManager
    {
        MonedasEntities db = new MonedasEntities();

        public virtual List<MonedasPrecio> ObtenerPrecio()
        {

            return db.MonedasPrecios.ToList();

        }
    }
}
