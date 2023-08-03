using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Refactoring.Idiomas
{
    public class Italiano : ITraductor
    {
        public string Final(int cantidad, decimal area, decimal perimetro)
        {
            string linea = Resources.ResourceItaliano.Final;
            return string.Format(linea, cantidad, perimetro, area);
        }

        public string ImprimirCabecera()
        {
            
            return Resources.ResourceItaliano.Cabecera;
        }

        public string ImprimirCabeceraVacia()
        {
            return Resources.ResourceItaliano.CabeceraVacia;
        }

        public string ObtenerLinea(int cantidad, decimal area, decimal perimetro, string forma)
        {
            //Me llegará del resources: {cantidad} {forma} | Area {area:#.##} | Perímetro {perimetro:#.##} <br/>"
            string linea = Resources.ResourceItaliano.Linea;
            forma = Resources.ResourceItaliano.ResourceManager.GetString(forma + (cantidad > 1 ? "s" : ""));

            return string.Format(linea, cantidad, forma, area, perimetro);;
        }
    }
}
