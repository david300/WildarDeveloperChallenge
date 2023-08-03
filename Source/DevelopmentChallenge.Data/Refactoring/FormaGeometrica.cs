using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevelopmentChallenge.Data.Refactoring.Idiomas;

namespace DevelopmentChallenge.Data.Refactoring
{
    public class FormaGeometrica
    {
        public static string Imprimir(List<IFormaGeometrica> formas)
        {
            return Imprimir(formas, new Castellano());
        }

        public static string Imprimir(List<IFormaGeometrica> formas, ITraductor traductor)
        {
            var sb = new StringBuilder();

            if (!formas.Any())
            {
                sb.Append(traductor.ImprimirCabeceraVacia());
            }
            else
            {
                sb.Append(traductor.ImprimirCabecera());
                ReporteFormas reporteFormas = new ReporteFormas(formas);

                foreach (var resumen in reporteFormas.Resumen)
                {
                    sb.Append(traductor.ObtenerLinea(resumen.Cantidad, resumen.AreaTotal, resumen.PerimetroTotal, resumen.Forma));
                }

                sb.Append(traductor.Final(reporteFormas.ObtenerCantidadTotalFormas(), reporteFormas.ObtenerAreaTotalFormas(), reporteFormas.ObtenerPerimetroTotalFormas()));
            }

            return sb.ToString();
        }
    }
}
