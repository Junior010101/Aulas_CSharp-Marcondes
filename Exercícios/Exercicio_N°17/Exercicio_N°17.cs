//objetivo: Escreva um algoritimo que leia um vetor de 15 posições de inteiros Em seguida, o algoritimo
//deve ler um valor inteiro e imprimir o numero de vezes que este valor ocorre no vetor.

//inicio do algoritimo
Console.Clear();

//variaveis
int[] vetor = new int[15];
int ValorBuscado;
int contador = 0;

//entrada
Console.WriteLine($"{new string('=', 12)} Algoritimo que le um vetor de é mostra o numero de ocorrencias {new string('=', 12)}\n");
Console.WriteLine("Para realizar o cauculo é preciso que você digite 15 numeros inteiros");

for (int i = 0; i < vetor.Length; i++){
    Console.ForegroundColor = ConsoleColor.DarkYellow;
    Console.WriteLine($"\nDigite o numero para a posição {i + 1}, do vetor");
    Console.Write("C/> ");
    Console.ResetColor();
    vetor[i] = Convert.ToInt32(Console.ReadLine());

    Console.Clear();
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.WriteLine($"numero adicionado na posição {i + 1}.");
    Console.ResetColor();
}

Console.ForegroundColor = ConsoleColor.DarkCyan;
Console.WriteLine("\nDigite o numero que deseja buscar no vetor");
Console.Write("C/> ");
Console.ResetColor();
ValorBuscado = Convert.ToInt32(Console.ReadLine());

//saida
for (int i = 0; i < vetor.Length; i++){
    if (vetor[i] == ValorBuscado){
        contador++;
    }
}

Console.ForegroundColor = ConsoleColor.DarkMagenta;
Console.WriteLine($"\nO número {ValorBuscado} aparece {contador} vez(es) no vetor.");
Console.ResetColor();
