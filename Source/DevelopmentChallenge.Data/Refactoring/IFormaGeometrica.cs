using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Refactoring
{
    public interface IFormaGeometrica
    {
        string ObtenerNombre();
        decimal CalcularPerimetro();
        decimal CalcularArea();
    }
}
