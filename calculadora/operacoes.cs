using System;
namespace Calculadora
{
    public class Operacoes
    {
        public int valorA {get;set;} // manter valor inteiro
        public char operador { get; set; }
        public int valorB { get; set; } // manter valor inteiro
        public decimal resultado { get; set; } // tipo decimal para poder receber os resultados da operação de divisão

    }
}