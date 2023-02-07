// [M01S02] Ex 3 - Separador de números ímpares e pares
// Faça um programa que receba do usuário dez números inteiros e execute os seguintes passos:
//    a) Separe em duas listas sendo um somente números ímpares e o outro números pares.
//    b) Coloque os números de cada lista em ordem crescente.
//    c) Exiba como resultado o número de elementos em cada lista e a soma dos valores de cada um.
//          Ex: “A lista de números ímpares possui 5 números e a soma deles é igual a 47”

//Declaração de Variaveis

int[] numeros = new int[10];
int[] pares = new int[10];
int[] impares = new int[10];

//Entradas
Console.WriteLine("Exercicio M01S2-EX3 Separador de números ímpares e pares\n");
Console.WriteLine("Digite 10 números aleatórios\n");

for (int i = 0; i < 10; i++)
{
    Console.Write($"Digite o {i + 1} numero: ");
    numeros[i] = Convert.ToInt32(Console.ReadLine());
}
//Processamento

for (int p = 0; p < numeros.Length; p++)
{
    if (numeros[p] % 2 == 0)
    {
        pares[p] = numeros[p];
    }
    else
    {
        impares[p] = numeros[p];
    }
}

// Ordenação dos Vetores
Array.Sort(numeros);
Array.Sort(pares);
Array.Sort(impares);

//Saídas
Console.WriteLine("\n\nESTES SÃO OS NÚMEROS QUE VOCÊ DIGITOU");
foreach (int num in numeros)
{
    Console.WriteLine(num);
}

Console.WriteLine("\n\nESTES SÃO OS PARES");
foreach (int num in pares)
{
    if (num != 0) Console.WriteLine(num);
}

Console.WriteLine("\n\nESTES SÃO OS ÍMPARES");
foreach (int num in impares)
{
    if (num != 0) Console.WriteLine(num);
}
Console.WriteLine("Digite qualquer tecla para continuar");
Console.ReadKey();