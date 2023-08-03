using System;
using System.Collections.Generic;
using DevelopmentChallenge.Data.Refactoring;
using DevelopmentChallenge.Data.Refactoring.Idiomas;
using NUnit.Framework;

namespace DevelopmentChallenge.Data.Tests
{
    [TestFixture]
    public class DataTestsRefactoring
    {
        [TestCase]
        public void TestResumenListaVaciaRefactoring()
        {
            Assert.AreEqual("<h1>Lista vacía de formas!</h1>",
                FormaGeometrica.Imprimir(new List<IFormaGeometrica>()));
        }

        [TestCase]
        public void TestResumenListaVaciaFormasEnIngles()
        {
            Assert.AreEqual("<h1>Empty list of shapes!</h1>",
                FormaGeometrica.Imprimir(new List<IFormaGeometrica>(), new Ingles()));
        }

        [TestCase]
        public void TestResumenListaConUnCuadrado()
        {
            var cuadrados = new List<IFormaGeometrica> { new Cuadrado(5) };

            //Por defecto el idioma es castellano
            var resumen = FormaGeometrica.Imprimir(cuadrados);
            Assert.AreEqual("<h1>Reporte de Formas</h1>1 Cuadrado | Area 25 | Perimetro 20 <br/>TOTAL:<br/>1 formas Perimetro 20 Area 25", resumen);
        }
        
        [TestCase]
        public void TestResumenListaConMasCuadrados()
        {
            var cuadrados = new List<IFormaGeometrica>
            {
                new Cuadrado(5),
                new Cuadrado(1),
                new Cuadrado(3)
            };

            var idiomaIngles = new Ingles();
            var resumen = FormaGeometrica.Imprimir(cuadrados, idiomaIngles);
            Assert.AreEqual("<h1>Shapes report</h1>3 Squares | Area 35 | Perimeter 36 <br/>TOTAL:<br/>3 shapes Perimeter 36 Area 35", resumen);
        }

        [TestCase]
        public void TestResumenListaConMasTiposEnCastellano()
        {
            var formas = new List<IFormaGeometrica>
            {
                new Cuadrado(5),
                new Circulo(3),
                new Triangulo(4),
                new Cuadrado(2),
                new Triangulo(9),
                new Circulo(2.75m),
                new Triangulo(4.2m)
            };

            var resumen = FormaGeometrica.Imprimir(formas);

            Assert.AreEqual(
                "<h1>Reporte de Formas</h1>2 Cuadrados | Area 29 | Perimetro 28 <br/>2 Círculos | Area 13,01 | Perimetro 18,06 <br/>3 Triángulos | Area 49,64 | Perimetro 51,6 <br/>TOTAL:<br/>7 formas Perimetro 97,66 Area 91,65",
                resumen);
        }

        [TestCase]
        public void TestResumenListaConMasTiposEnItaliano()
        {
            var formas = new List<IFormaGeometrica>
            {
                new Cuadrado(5),
                new Circulo(3),
                new Triangulo(4),
                new Cuadrado(2),
                new Triangulo(9),
                new Circulo(2.75m),
                new Triangulo(4.2m)
            };
            var idiomaItaliano = new Italiano();
            var resumen = FormaGeometrica.Imprimir(formas, idiomaItaliano);

            Assert.AreEqual(
                "<h1>Relazione sulle forme geometriche</h1>2 Piazze | Area 29 | Perimetro 28 <br/>2 Cerchi | Area 13,01 | Perimetro 18,06 <br/>3 Triangoli | Area 49,64 | Perimetro 51,6 <br/>TOTAL:<br/>7 forme geometriche perimetro 97,66 area 91,65",
                resumen);
        }

        [TestCase]
        public void TestResumenListaTrapeciosRectangulosItaliano()
        {
            var formas = new List<IFormaGeometrica>
            {
                new Trapecio(2, 1, 4, 1, 1),
                new Rectangulo(1, 4),
                new Trapecio(3, 1, 4, 6, 3),
                new Rectangulo(2, 2)
            };
            var idiomaItaliano = new Italiano();
            var resumen = FormaGeometrica.Imprimir(formas, idiomaItaliano);

            Assert.AreEqual(
                "<h1>Relazione sulle forme geometriche</h1>2 Trapezi | Area 14 | Perimetro 18 <br/>2 Rettangoli | Area 8 | Perimetro 18 <br/>TOTAL:<br/>4 forme geometriche perimetro 36 area 22",
                resumen);
        }
    }
}
