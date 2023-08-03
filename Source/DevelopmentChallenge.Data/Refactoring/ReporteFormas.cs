using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Refactoring
{
    public class ReporteFormas
    {
        public List<ResumenPorForma> Resumen { get; set; }
        public ReporteFormas()
        {
            this.Resumen = new List<ResumenPorForma>();
        }

        public ReporteFormas(List<IFormaGeometrica> formas)
        {
            this.Resumen = new List<ResumenPorForma>();
            foreach (var forma in formas)
            {
                this.Agregar(forma);
            }
        }

        public int ObtenerCantidadTotalFormas() {
            return this.Resumen.Sum(x => x.Cantidad);
        }

        public decimal ObtenerAreaTotalFormas()
        {
            return this.Resumen.Sum(x => x.AreaTotal);
        }

        public decimal ObtenerPerimetroTotalFormas()
        {
            return this.Resumen.Sum(x => x.PerimetroTotal);
        }

        public void Agregar(IFormaGeometrica forma) 
        {
            if (this.Resumen.Any(x => x.Forma == forma.ObtenerNombre()))
            {
                foreach (var resumenForma in this.Resumen)
                {
                    if (resumenForma.Forma == forma.ObtenerNombre())
                    {
                        resumenForma.Cantidad++;
                        resumenForma.AreaTotal += forma.CalcularArea();
                        resumenForma.PerimetroTotal += forma.CalcularPerimetro();
                    }
                }
            }
            else
            {
                this.Resumen.Add(new ResumenPorForma()
                {
                    Forma = forma.ObtenerNombre(),
                    AreaTotal = forma.CalcularArea(),
                    PerimetroTotal = forma.CalcularPerimetro(),
                    Cantidad = 1
                });
            }
        }
    }

    public class ResumenPorForma
    {
        public string Forma { get; set; }
        public int Cantidad { get; set; }
        public decimal AreaTotal { get; set; }
        public decimal PerimetroTotal { get; set; }
    }
}
