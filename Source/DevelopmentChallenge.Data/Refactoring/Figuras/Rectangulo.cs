using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Refactoring
{
    public class Rectangulo : Figura, IFormaGeometrica
    {
        decimal _base { get; }
        decimal _altura { get; }

        public Rectangulo(decimal baseRectangulo, decimal altura)
        {
            this.Nombre = GetType().Name;
            _base = baseRectangulo;
            _altura = altura;
        }

        public decimal CalcularArea()
        {
            return _base * _altura;
        }

        public decimal CalcularPerimetro()
        {
            return 2 * (_base + _altura);
        }

        public string ObtenerNombre()
        {
            return this.Nombre;
        }
    }
}
