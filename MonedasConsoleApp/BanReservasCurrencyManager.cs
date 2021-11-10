using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonedasConsoleApp
{
    //Adapter
    public class BanReservasCurrencyManager:CurrencyManager
    {
        //adaptee
        BanreservasLeerPrecioMoneda w = new BanreservasLeerPrecioMoneda();

        public override List<MonedasPrecio> ObtenerPrecio()
        {
            string precios  = w.ObtenerPrecios(); 

            MonedasPrecio dolar = new MonedasPrecio();
            dolar.MonedaId = 1;
            dolar.PrecioCompra =Convert.ToDecimal( precios.Split('|')[0].Split(',')[0]);
            dolar.PrecioVenta = Convert.ToDecimal(precios.Split('|')[0].Split(',')[1]);

            MonedasPrecio euro = new MonedasPrecio();
            euro.MonedaId = 2;
            euro.PrecioCompra = Convert.ToDecimal(precios.Split('|')[1].Split(',')[0]);
            euro.PrecioVenta = Convert.ToDecimal(precios.Split('|')[1].Split(',')[1]);

            

            return new List<MonedasPrecio>() {dolar,euro };
        }
    }
}
