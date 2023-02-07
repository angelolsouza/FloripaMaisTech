//[M01S02] Ex 4 - Cálculo de média de aprovação
//Faça um programa que receba o nome e média final de cinco alunos.
//Armazene em um array ou list os nomes e em outra as médias.
//Ao final, exiba o nome de cada aluno e a mensagem “APROVADO” para quem tiver média acima de 6 e “REPROVADO” para quem não.

using System.ComponentModel;

Console.WriteLine("Exercicio M01S2-EX4 Cálculo de média de aprovação\n");
Console.WriteLine("Digite os nomes dos alunos e suas respectivas médias\n");

//Entradas
string?[] nomeAlunos = new string[5];
decimal[] mediaAlunos = new decimal[5];

for (int i = 0; i < 5; i++){
    Console.Write($"Digite o nome do {i + 1} aluno: ");
    nomeAlunos[i] = Console.ReadLine();

    Console.Write($"Digite a média do {i + 1} aluno: ");
    mediaAlunos[i] = decimal.Parse (Console.ReadLine());
}
//Processamento-Saídas
Console.WriteLine("\n");
for (int i = 0; i < 5; i++)
{
    if (mediaAlunos[i] >= 7){
        Console.WriteLine($"O aluno {nomeAlunos[i]} está APROVADO");
    }
    else{
        Console.WriteLine($"O aluno {nomeAlunos[i]} está REPROVADO");
    }
}
Console.WriteLine("\nDigite qualquer tecla para continuar");
Console.ReadKey();