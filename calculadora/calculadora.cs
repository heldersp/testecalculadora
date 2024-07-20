using System;
namespace Calculadora
{
    public class Calculadora
    {
        public Operacoes calcular(Operacoes operacao)
        {
            switch(operacao.operador)
            {
                case '+': 
                    operacao.resultado = soma(operacao); 
                    break;
                case '-': 
                    operacao.resultado = subtracao(operacao); 
                    break;
                case '*': 
                    operacao.resultado = multiplicacao(operacao); 
                    break;
                case '/': 
                    operacao.resultado = divisao(operacao); 
                    break;
                default: 
                    operacao.resultado = 0; 
                    break;
            }
            return operacao;
        }

        public int soma(Operacoes operacao) // manter tipo int
        {
            return operacao.valorA + operacao.valorB;
        }

        public int subtracao(Operacoes operacao) // manter tipo int
        {
            return operacao.valorA - operacao.valorB;
        }

        public int multiplicacao(Operacoes operacao) // manter tipo int
        {
            return operacao.valorA * operacao.valorB;
        }

        public decimal divisao(Operacoes operacao) // usar tipo decimal para divisão
        {
            if (operacao.valorB == 0)
            {
                throw new DivideByZeroException("Não existe divisão por zero!");
            }
            return (decimal)operacao.valorA / operacao.valorB;
        }
    }
}