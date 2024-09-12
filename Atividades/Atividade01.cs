//Importações
using System;

// == Objetivo da atividade: utilizando as condições aplicadas na aula02
// Crie um algoritimo, que tira a media de um aluno e diga se ele foi aprovado ou não.
Console.Clear();

Console.WriteLine("============= Digite suas notas no console =============\n");
Console.WriteLine("OBS: Se sua nota for um numero decimal, lhé represente com virgula.");
Console.WriteLine("Ex: Tirei 3.5; deve ser representado: 3,5\n");

Console.Write("Primeira Nota: ");
float num = float.Parse(Console.ReadLine());

Console.Write("\nSegunda Nota: ");
float num2 = float.Parse(Console.ReadLine());

Console.Write("\nTerceira Nota: ");
float num3 = float.Parse(Console.ReadLine());

Console.Write("\nQuarta Nota: ");
float num4 = float.Parse(Console.ReadLine());

if((num + num2 + num3 + num4) / 4 >= 7){
    Console.WriteLine("Ebaaa, Você Passou !!!");
    Console.WriteLine("Sua media foi: " + ((num + num2 + num3 + num4) / 4));
}
else{
    Console.WriteLine("Poxa, Reprovassé");
    Console.WriteLine("Sua media foi: " + ((num + num2 + num3 + num4) / 4));
}
