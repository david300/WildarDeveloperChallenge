using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Refactoring
{
    public class Triangulo : Figura, IFormaGeometrica
    {
        private decimal _lado;
        public Triangulo(decimal lado)
        {
            this.Nombre = GetType().Name;
            this._lado = lado;
        }

        public decimal CalcularArea()
        {
            return ((decimal)Math.Sqrt(3) / 4) * _lado * _lado;
        }

        public decimal CalcularPerimetro()
        {
            return _lado * 3;
        }

        public string ObtenerNombre()
        {
            return this.Nombre;
        }
    }
}
