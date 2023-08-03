using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Refactoring.Idiomas
{
    public interface ITraductor
    {
        string ImprimirCabeceraVacia();
        string ImprimirCabecera();
        string ObtenerLinea(int cantidad, decimal area, decimal perimetro, string forma);
        string Final(int cantidad, decimal area, decimal perimetro);
    }
}
