//Objetivo da atividade:
//Criar um algoritimo cuja função é exibir o dia da semana baseado no dia do mês
//Utilizando o switch case

//inicio do programa
Console.WriteLine("Digite o dia do mês:\n");
Console.Write("/> ");

//entrada
int op = int.Parse(Console.ReadLine());

//Saida
switch (op % 7){
    //caso o dia no modulo 7 for igual a 1
    case 1:
        Console.WriteLine("\nHoje é Domingo");
    break;

    //caso o dia no modulo 7 for igual a 2
    case 2:
        Console.WriteLine("\nHoje é Segunda");
    break;

    //caso o dia no modulo 7 for igual a 3
    case 3:
        Console.WriteLine("\nHoje é Terça");
    break;

    //caso o dia no modulo 7 for igual a 4
    case 4:
        Console.WriteLine("\nHoje é Quarta");
    break;

    //caso o dia no modulo 7 for igual a 5
    case 5:
        Console.WriteLine("\nHoje é Quinta");
    break;

    //caso o dia no modulo 7 for igual a 6
    case 6:
        Console.WriteLine("\nHoje é Sexta");
    break;

    //caso o dia no modulo 7 for igual a 7
    case 7:
        Console.WriteLine("\nHoje é Sabado");
    break;

    //caso nenhum dos casos
    default:
    Console.WriteLine("\nOpção Invalida");
    break;
}
