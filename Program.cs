// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

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

Console.WriteLine(agora);

Console.WriteLine("Digite uma opção entre 1 e 3");

var opcao = Console.ReadLine();

//Estrutura de condição

Console.WriteLine("Com  If");
if(opcao == "1"){
    Console.WriteLine("Opção 1 selecionada.");
}else if(opcao == "2"){
    Console.WriteLine("Opção 2 selecionada.");
}else if(opcao == "3"){
    Console.WriteLine("Opção 3 selecionada.");
}else{
    Console.WriteLine("Opção inválida");
}

// ternário
var opcaoE3 = opcao =="3"? "Sim" : "Não";

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

//Estrutura de repetição

var valores = "0 1 2 3 4 5";
var numeros = valores.Split(' '); // Criar um array

Console.WriteLine("Repetição com For");
for(var i = 0; i < numeros.Length; i++){
    Console.Write(numeros[i]);
}

Console.WriteLine();

var contador = 0;

Console.WriteLine("Com While");

while(contador < numeros.Length){
    Console.Write(numeros[contador]);
    contador++;
}

Console.WriteLine();

do{
    Console.WriteLine("Executando com do-while");
} while(numeroInt == 3);


Console.WriteLine("Executando Com Foreach");
foreach(var numero in numeros){
    Console.WriteLine(numero);
}