using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Refactoring
{
    public class Circulo : Figura, IFormaGeometrica
    {
        private decimal _diametro;
        public Circulo(decimal diametro)
        {
            this.Nombre = GetType().Name;
            this._diametro = diametro;
        }
        public decimal CalcularArea()
        {
            return (decimal)Math.PI * (_diametro / 2) * (_diametro / 2);
        }

        public decimal CalcularPerimetro()
        {
            return (decimal)Math.PI * _diametro;
        }

        public string ObtenerNombre()
        {
            return this.Nombre;
        }
    }
}
