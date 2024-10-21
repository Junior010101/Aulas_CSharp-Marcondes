//objetivo: Escreva um algoritimo que leia o indice pluviometrico de cada dia do mês de junho
//e informe o dia que mais choveu, o dia que menos choveu e as medidas pluviometricas de cada
//uma das duas quinzenas.

//inicio do algoritimo
Console.Clear();

//variaveis
double[] indice_pluviometrico = new double[30];
int dia_maior_indice = 0;
int dia_menor_indice = 0;
double PrimeraQuizena = 0;
double SegundaQuizena = 0;
double PrimeiraMedia;
double SegundaMedia;

//entrada
Console.WriteLine($"{new string('=', 12)} Algoritimo que informa as medidas pluviometricas de junho{new string('=', 12)}");
Console.WriteLine("\nPara que o programa possa funcionar é precisso que informe o indice do pluviometro do dia 1 até 30 de junho");

for (int dia = 0; dia < 30; dia++){
    Console.WriteLine($"\nInforme o índice pluviometrico do dia {dia + 1} de junho");
    Console.Write("C/> ");
    indice_pluviometrico[dia] = Convert.ToDouble(Console.ReadLine());

    Console.Clear();
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.WriteLine("Indice adicionado a lista.");
    Console.ResetColor();
}
//saida
for (int i = 1; i < 30; i++){
    if (indice_pluviometrico[i] > indice_pluviometrico[dia_maior_indice]){
        dia_maior_indice = i;
    }
    if (indice_pluviometrico[i] < indice_pluviometrico[dia_menor_indice]){
        dia_menor_indice = i;
    }
}
for (int i = 0; i < 15; i++){
    PrimeraQuizena += indice_pluviometrico[i];
}
for (int i = 15; i < 30; i++){
    SegundaQuizena += indice_pluviometrico[i];
}

PrimeiraMedia = PrimeraQuizena / 15;
SegundaMedia = SegundaQuizena / 15;

Console.ForegroundColor = ConsoleColor.DarkYellow;
Console.Write("\nDia que Mais choveu: ");
Console.ResetColor();
Console.ForegroundColor = ConsoleColor.DarkCyan;
Console.Write($"{dia_maior_indice + 1} com {indice_pluviometrico[dia_maior_indice]} mm");

Console.ForegroundColor = ConsoleColor.DarkYellow;
Console.Write("\nDia que Menos choveu: ");
Console.ResetColor();
Console.ForegroundColor = ConsoleColor.DarkCyan;
Console.Write($"{dia_menor_indice + 1} com {indice_pluviometrico[dia_menor_indice]} mm");

Console.ForegroundColor = ConsoleColor.DarkYellow;
Console.Write("\nMerdia Pluviometrica da Primeira Quizena: ");
Console.ResetColor();
Console.ForegroundColor = ConsoleColor.DarkCyan;
Console.Write($"{PrimeiraMedia:F2} mm");

Console.ForegroundColor = ConsoleColor.DarkYellow;
Console.Write("\nMerdia Pluviometrica da Segunda Quizena: ");
Console.ResetColor();
Console.ForegroundColor = ConsoleColor.DarkCyan;
Console.Write($"{SegundaMedia:F2} mm\n");
Console.ResetColor();
Console.WriteLine("\n");
