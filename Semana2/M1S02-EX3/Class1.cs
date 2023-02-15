//[M1S02] Ex 3 - Defina uma classe chamada ContaBancaria
//Defina uma classe chamada ContaBancaria com os seguintes
//atributos: número, agência, nome do titular, saldo, tipo de conta.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M1S02_EX3.ContaBancaria
{
    public class ContaBancaria
    {
        public int numeros;
        public int agencia;
        public string ?nomedotitular;
        public int saldo = 0;
        public TipoConta tipConta;
    }
    public enum TipoConta
    {
        corrente = 0,
        poupanca = 0,
    }
}
