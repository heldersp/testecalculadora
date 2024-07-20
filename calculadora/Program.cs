using System;
using System.Collections;
using System.Collections.Generic;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<Operacoes> filaOperacoes = new Queue<Operacoes>();
            filaOperacoes.Enqueue(new Operacoes { valorA = 2, valorB = 3, operador = '+' });
            filaOperacoes.Enqueue(new Operacoes { valorA = 14, valorB = 8, operador = '-' });
            filaOperacoes.Enqueue(new Operacoes { valorA = 5, valorB = 6, operador = '*' });
            filaOperacoes.Enqueue(new Operacoes { valorA = 2147483647, valorB = 2, operador = '+' });
            filaOperacoes.Enqueue(new Operacoes { valorA = 18, valorB = 3, operador = '/' });

            Calculadora calculadora = new Calculadora();

            //instancia pilha para armazenamento
            Stack<decimal> resultados = new Stack<decimal>(); 


            // retirar o sinal "=" para não criar um laço infinito
            while (filaOperacoes.Count > 0) 
            {
                // trocar para metodo dequeue que percorre a estrutura até esvaziá-la
                Operacoes operacao = filaOperacoes.Dequeue(); 
                calculadora.calcular(operacao);
                Console.WriteLine("{0} {1} {2} = {3}", operacao.valorA, operacao.operador, operacao.valorB, operacao.resultado);

                // inputa o resultado na pilha
                resultados.Push(operacao.resultado);

                // output operações restantes na fila
                Console.WriteLine("As operações restantes na fila são:");
                foreach (var op in filaOperacoes)
                {
                    Console.WriteLine("{0} {1} {2}", op.valorA, op.operador, op.valorB);
                }
            }

            // output resultados na pilha
            Console.WriteLine("Os resultados armazenados na pilha são: ");
            foreach (var resultado in resultados)
            {
                Console.WriteLine(resultado);
            }
        }
    }
}