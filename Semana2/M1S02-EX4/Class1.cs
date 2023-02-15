//[M1S02] Ex 4 - Crie um método para depositar valores
//Crie um método para depositar valores na conta bancária.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class1
{
    // Resposta exercicio 03
    public class ContaBancaria
    {
        public int numeros;
        public int agencia;
        public string? nomedotitular;
        public decimal saldo = 0;
        public TipoContaEnum tipoConta;

        // Resposta exercicio 04
        public void Depositar(decimal valor)
        {
            if (valor <= 0)
            {
                Console.WriteLine("O valor precisa ser maior do que 0");
            }
            else
            {
                saldo = saldo + valor;
            }
        }
        // Resposta exercicio 05
        public void Sacar(decimal valor)
        {
            if (valor <= 0)
            {
                Console.WriteLine("O valor precisa ser maior do que 0");
            }
            else if (valor > saldo)
            {
                Console.WriteLine("O valor é maior do que o saldo atual");
            }
            else
            {
                saldo = saldo - valor;
            }
        }
        // Resposta Exercicio 06
        public void ExibirSaldo()
        {
            Console.WriteLine($"O saldo atual da conta é de R$ {saldo}");
        }
    }
}