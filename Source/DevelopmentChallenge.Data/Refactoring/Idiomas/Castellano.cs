using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Refactoring.Idiomas
{
    class Castellano : ITraductor
    {
        public string Final(int cantidad, decimal area, decimal perimetro)
        {
            string linea = Resources.ResourceCastellano.Final;
            return string.Format(linea, cantidad, perimetro, area);
        }

        public string ImprimirCabecera()
        {
            
            return Resources.ResourceCastellano.Cabecera;
        }

        public string ImprimirCabeceraVacia()
        {
            return Resources.ResourceCastellano.CabeceraVacia;
        }

        public string ObtenerLinea(int cantidad, decimal area, decimal perimetro, string forma)
        {
            //Me llegará del resources: {cantidad} {forma} | Area {area:#.##} | Perímetro {perimetro:#.##} <br/>"
            string linea = Resources.ResourceCastellano.Linea;
            forma = Resources.ResourceCastellano.ResourceManager.GetString(forma + (cantidad > 1 ? "s" : ""));

            return string.Format(linea, cantidad, forma, area, perimetro);
        }
    }
}
