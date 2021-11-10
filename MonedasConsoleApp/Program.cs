using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonedasConsoleApp
{
    //client
    class Program
    {
        static void Main(string[] args)
        {
            //CurrencyManager cm = new CurrencyManager();
            CurrencyManager cm = new BanReservasCurrencyManager();

            foreach(var item in cm.ObtenerPrecio())
            {
             
                Console.WriteLine("{0} Precio compra: {1:n2} Precio venta: {2:n2}", item.MonedaId, item.PrecioCompra, item.PrecioVenta);
            }
            
            Console.ReadKey();
        }
    }
}
