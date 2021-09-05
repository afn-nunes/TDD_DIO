using NewTalents;
using System;
using Xunit;

namespace TestNewTalent
{
    public class TestCalculadora
    {
        public Calculadora construirClasse() {
            Calculadora calc = new Calculadora();
            return calc;
        }


        [Theory]
        [InlineData (1, 2, 3)]
        [InlineData(4, 5, 9)]
        public void TestSomar(int valor1, int valor2, int resultado)
        {
            Calculadora calc = construirClasse();
            int resultadoCalculadora = calc.somar(valor1, valor2);
            Assert.Equal(resultadoCalculadora, resultado);
        }


        [Theory]
        [InlineData(1, 2, 2)]
        [InlineData(4, 5, 20)]
        public void TestMultiplicar(int valor1, int valor2, int resultado)
        {
            Calculadora calc = construirClasse();
            int resultadoCalculadora = calc.multiplicar(valor1, valor2);
            Assert.Equal(resultadoCalculadora, resultado);
        }

        [Theory]
        [InlineData(2, 1, 1)]
        [InlineData(8, 4, 4)]
        public void TestSubtrair(int valor1, int valor2, int resultado)
        {
            Calculadora calc = construirClasse();
            int resultadoCalculadora = calc.subtrair(valor1, valor2);
            Assert.Equal(resultadoCalculadora, resultado);
        }


        [Theory]
        [InlineData(6, 2, 3)]
        [InlineData(20, 5, 4)]
        public void TestDividir(int valor1, int valor2, int resultado)
        {
            Calculadora calc = construirClasse();
            int resultadoCalculadora = calc.dividir(valor1, valor2);
            Assert.Equal(resultadoCalculadora, resultado);
        }

        [Fact]
        public void TestarDivisaoPorZero()
        {
            Calculadora calc = construirClasse();
            Assert.Throws<DivideByZeroException>(() => calc.dividir(3,0));
        }

        [Fact]
        public void TestarHistorico()
        {
            Calculadora calc = construirClasse();
            calc.somar(1, 2);
            calc.somar(1, 2);
            calc.somar(1, 2);
            calc.somar(1, 2);

            var lista = calc.historico();
            Assert.NotEmpty(lista);
            Assert.Equal(3, lista.Count);
        }
    }
}
