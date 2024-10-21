using System;

Console.Clear();
Console.WriteLine("------------Algoritimo que exibe se um numero é par ou Impar------------");

Console.WriteLine("Digite um numero:");
int num = int.Parse(Console.ReadLine());

if (num % 2 == 0){
    Console.WriteLine("O Numero Inserido é Par");
}
else{
    Console.WriteLine("O Numero Inserido é Impar");
}

// Nesta aula aprendemos um pouco sobre condicionais.
// Vimos a tabela verdade, utilizamos as condições IF (Se) e Else (Se Não).
