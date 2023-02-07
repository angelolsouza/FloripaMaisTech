// [M01S02] Ex 1 - Buscador de números primos
// Faça um programa que receba do usuário dez números inteiros, e ao final, 
// exiba os números primos e suas respectivas posições.

//Declaração de Variaveis
using System;
int[] numeros = new int[10];

//Entradas
Console.WriteLine("Exercicio M01S2-EX1 Buscador de números primos\n");
Console.WriteLine("Digite 10 números aleatórios sucessivamente\n");

for (int i = 0; i < 10; i++)
{
    Console.Write($"Digite um numero: ");
    numeros[i] = Convert.ToInt32(Console.ReadLine());
}
//Processamento-Saídas
Console.WriteLine("\n");
for (int i = 0; i < 10; i++){
    int contador = 1;
    for (int n = 1; n < numeros[i]; n++){
        if (numeros[i] % n == 0){
            contador++;
        }
    }
    if (contador == 2){
        Console.WriteLine($"O número {numeros[i]} é um número primo. Ela está na posição {i} do Array de números.");
    }
}
Console.WriteLine("\nDigite qualquer tecla para continuar");
Console.ReadKey();