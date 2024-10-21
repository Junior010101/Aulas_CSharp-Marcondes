//objetivo: Criar um algoritimo que leia a data de nascimento e o nome de uma pessoa,
//e imprima a idade atual da pessoa. Se a pessoa for maior de 18 imprima o nome da pessoa e 
//uma mensagem informando que sua entrada é permitida

//inicio do algoritimo
Console.Clear();

//variaveis
DateTime DataDeNascimento;
string Data;
string nome;
int idade;
int dia;
int mes;
int ano;

//entrada
Console.WriteLine($"{new string('=', 12)} Olá, Este é um algoritimo de autenticação {new string('=', 12)}\n");

Console.ForegroundColor = ConsoleColor.DarkYellow;
Console.Write("Digite seu nome: ");
Console.ResetColor();
nome = new string(Console.ReadLine());

Console.ForegroundColor = ConsoleColor.DarkYellow;
Console.WriteLine("\nDigite sua data de nascimento com dia, mês e ano separados por '/' deste jeito: 00/00/0000");

Console.Write("\nData de Nascimento: ");
Console.ResetColor();
Data = new string(Console.ReadLine());

//saida
if (Data.IndexOf('/') == 2 && Data.LastIndexOf('/') == 5){
    bool NumeroAp1 = int.TryParse(string.Join("", Data.Split('/'))[..2], out dia);
    bool NumeroAp2 = int.TryParse(string.Join("", Data.Split('/')).Substring(2,2), out mes);
    bool NumeroAp3 = int.TryParse(string.Join("", Data.Split('/'))[4..], out ano);

    if (NumeroAp1 == true && NumeroAp2 == true && NumeroAp3 == true && ano <= Convert.ToInt32(DateTime.Today.ToString()[6..10])){
        try {
            DataDeNascimento = new DateTime(ano, mes, dia);

            idade = Convert.ToInt32(DateTime.Today.Subtract(DataDeNascimento).TotalDays / 365);

            if (idade > 18){
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine($"\n{nome}, Você tem {idade} anos. Sua entrada é permitida");
                Console.ResetColor();
            }
            else {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine($"\n{nome}, Você tem {idade} anos. Acesso negado !");
                Console.ResetColor();
            }
        }
        catch (Exception){
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("\nData de Nascimento Invalida");
            Console.ResetColor();
        }
    }
    else {
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("\nErro de Formatação !!");
        Console.ResetColor();
    }
}
else {
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine("\nErro de Formatação !!");
    Console.ResetColor();
}
