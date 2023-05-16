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
}*/

//Estruturas de dados

//Matrizes e Listas

var matriz = new int[5]{0, 1, 2, 3 ,4};

 var matrizV2 = new int[5];

 matrizV2[0] = 0;
 matrizV2[1] = 1;
 matrizV2[2] = 2;
 matrizV2[3] = 3;
 matrizV2[4] = 4;

 Console.WriteLine(matrizV2[3]);

 var lista = new List<int>{0, 1, 2, 3 ,4};
 var listaV2 = new List<int>();
 listaV2.Add(0);
 listaV2.Add(1);
 listaV2.Add(2);
 listaV2.Add(3);
 listaV2.Add(4);

 var maiorQue2 = lista.Where(n => n > 2);

 foreach(var numero in maiorQue2){
    Console.WriteLine(numero);
 }
 var soma = lista.Sum();
 var media = lista.Average();
 var max = lista.Max();
 var min = lista.Min();

 Console.WriteLine($"Soma: {soma}");
 Console.WriteLine($"Media: {media}");
 Console.WriteLine($"Max: {max}");
 Console.WriteLine($"Min: {min}");
 
 //Dicionarios