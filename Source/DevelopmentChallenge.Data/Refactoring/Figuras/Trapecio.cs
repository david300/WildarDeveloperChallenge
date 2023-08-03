using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Refactoring
{
    public class Trapecio : Figura, IFormaGeometrica
    {
        decimal _baseMayor { get; }
        decimal _baseMenor { get; }
        decimal _altura { get; }
        decimal _lado1 { get; }
        decimal _lado2 { get; }

        public Trapecio(decimal baseMayor, decimal baseMenor, decimal altura, decimal lado1, decimal lado2)
        {
            this.Nombre = GetType().Name;
            _baseMayor = baseMayor;
            _baseMenor = baseMenor;
            _altura = altura;
            _lado1 = lado1;
            _lado2 = lado2;
        }

        public decimal CalcularArea()
        {
            return ((_baseMayor + _baseMenor) * _altura) / 2;
        }

        public decimal CalcularPerimetro()
        {
            return _baseMayor + _baseMenor + _lado1 + _lado2;
        }

        public string ObtenerNombre()
        {
            return this.Nombre;
        }
    }
}
