//[M01S02] Ex 2 - Organizador de lista de frutas
//Crie um programa que receba do usuário uma lista de frutas com no máximo 15 itens.
//Organize as frutas em ordem alfabética e exiba a lista.

//Entradas
using System.Runtime.CompilerServices;
using System.Security.Principal;

Console.WriteLine("Exercicio M01S2-EX2 Organizador de lista de frutas\n");
Console.WriteLine("Digite nome de frutas para gerar uma lista de frutas em ordem alfabética\n");

//lista
List<string> frutas = new List<string>();
bool continuar = true;

//Entradas+Processamento
while (continuar)
{
    if (frutas.Count == 15)
    {
        continuar = false;
    }
    Console.Write("Digite o nome de uma fruta: ");
    frutas.Add(Console.ReadLine());
    Console.WriteLine("Voce deseja continuar?: (Sim? / Não?)");
    string resposta = Console.ReadLine();

    if (resposta == "nao" || resposta == "n"){
        continuar = false;
    }
}
//Ordena lista
frutas.Sort();

//Saidas
Console.WriteLine("\nLista de frutas ordenadas alfabeticamente");
foreach (string fruta in frutas){
    Console.WriteLine(fruta); 
}
Console.WriteLine("\nDigite qualquer tecla para continuar");
Console.ReadKey();


