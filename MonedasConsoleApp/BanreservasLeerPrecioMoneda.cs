using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace MonedasConsoleApp
{
    //adaptee
    class BanreservasLeerPrecioMoneda
    {
        public string ObtenerPrecios()
        {
            HttpWebRequest req = (HttpWebRequest)HttpWebRequest.Create("https://www.banreservas.com");

            var res = req.GetResponse();
            StreamReader sr = new StreamReader(res.GetResponseStream());
            string html = sr.ReadToEnd();

            HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
            doc.LoadHtml(html);
            var table = doc.DocumentNode.SelectNodes("//table[contains(@class,'currency-box-table')]//td").ToList();
            sr.Close();
            sr.Dispose();

            return String.Format("{0},{1}|{2},{3}", table[4].InnerText, table[5].InnerText, table[7].InnerText, table[8].InnerText);
        }
    }
}
 