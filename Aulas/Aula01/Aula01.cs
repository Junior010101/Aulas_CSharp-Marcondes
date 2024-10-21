//Importações
using System;

//Operações: soma, subtração, multiplicação e divisão
Console.WriteLine("Demonstração de Soma");

Console.WriteLine("Digite um numero");
int num = int.Parse(Console.ReadLine());

Console.WriteLine("Digite outro numero");
int num2 = int.Parse(Console.ReadLine());

Console.WriteLine("A soma entre "+ num + " e " + num2 +" é "+ (num+num2));
Console.WriteLine("A subtração entre "+ num + " e " + num2 +" é "+ (num  - num2));
Console.WriteLine("A multiplicação entre "+ num + " e " + num2 +" é "+ (num * num2));
Console.WriteLine("A divisão entre "+ num + " e " + num2 +" é "+ (num / num2));

// Na aula 01, fomos apresentados aos metodos de emtrada e saida de texto no console.
// Depois vimos os operadores numericos.
