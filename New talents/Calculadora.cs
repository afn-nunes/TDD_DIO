using System;
using System.Collections.Generic;
using System.Text;

namespace NewTalents
{
    public class Calculadora
    {
        private List<string> _historico;

        public Calculadora()
        {
            _historico = new List<string>();
        }

        public int somar(int valor1, int valor2)
        {
            int resultado = valor1 + valor2;

            _historico.Insert(0, "Resultado: " + resultado);
            return resultado;
        }
        public int subtrair(int valor1, int valor2)
        {
            int resultado = valor1 - valor2;

            _historico.Insert(0, "Resultado: " + resultado);
            return resultado;
        }
        public int multiplicar(int valor1, int valor2)
        {
            int resultado = valor1 * valor2;

            _historico.Insert(0, "Resultado: " + resultado);
            return resultado;
        }
        public int dividir(int valor1, int valor2)
        {
            int resultado = valor1 / valor2;

            _historico.Insert(0, "Resultado: " + resultado);
            return resultado;
        }

        public List<string> historico()
        {
            _historico.RemoveRange(3, _historico.Count -3);
            return _historico;
        }
    }
}
