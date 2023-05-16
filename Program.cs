// See https://aka.ms/new-console-template for more information
/*Console.WriteLine("Hello, World!");

var nome = Console.ReadLine();

Console.WriteLine("Hello," + nome);
Console.WriteLine($"Hello, {nome}");

var umaString = "Jornada .NET";
var numeroInt = 5;
var numeroFloat = 5.4f;
var numeroDouble = 5.4;
var numeroDecimal = 5.4m;
var caractere = 'a';
var data = new DateTime(1992, 1, 1);
var agora = DateTime.Now;

Console.WriteLine(agora);*/

Console.WriteLine("Digite uma opção entre 1 e 3");

var opcao = Console.ReadLine();

if(opcao == "1"){
    Console.WriteLine("Opção 1 selecionada.");
}else if(opcao == "2"){
    Console.WriteLine("Opção 2 selecionada.");
}else if(opcao == "3"){
    Console.WriteLine("Opção 3 selecionada.");
}else{
    Console.WriteLine("Opção inválida");
}

Console.WriteLine("Com Switch");
switch(opcao){
    case "1" :
        Console.WriteLine("Opção 1 selecionada.");
        break;
    case "2" :
        Console.WriteLine("Opção 2 selecionada.");
        break;
    case "3" :
        Console.WriteLine("Opção 3 selecionada.");
        break;
    default: 
        Console.WriteLine("Opção inválida");
        break;
}