using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Refactoring
{
    public class Cuadrado : Figura, IFormaGeometrica
    {
        private decimal _lado;
        public Cuadrado(decimal lado)
        {
            this.Nombre = GetType().Name;
            this._lado = lado;
        }
        public decimal CalcularArea()
        {
            return _lado * _lado;
        }

        public decimal CalcularPerimetro()
        {
            return _lado * 4;
        }

        public string ObtenerNombre()
        {
            return this.Nombre;
        }
    }
}
