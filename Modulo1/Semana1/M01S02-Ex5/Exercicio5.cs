//[M01S02] Ex 5 - Sequência de Fibonacci
//Faça um algoritmo que receba um número inteiro que será a quantidade de números
//calculados pela sequência de Fibonacci. Em seguida, exiba a sequência no terminal.
//Ex: Se receber o número 7, você irá exibir a sequência “1 2 3 5 8 13 21” que contém ao todo 7
//números.

//Variaveis
int  n;
int x = 1, y = 0, z =0;

//Entradas
n = int.Parse(Console.ReadLine());  

//Processamento-Saída
for (int i = 0; i < n; i++)
    //z=0, x=1, y=0
{
    z = x + y;
    Console.WriteLine(z);
    y = x;
    x = z;
}
Console.WriteLine("\nDigite qualquer tecla para continuar");
Console.ReadKey();
