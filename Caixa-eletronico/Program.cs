using System.Diagnostics;

Console.WriteLine("(1) Realizar o depósito do dinheiro");
Console.WriteLine("(2) Realizar o saque do dinheiro");
Console.WriteLine("(3) Realizar a transferência do dinheiro");
Console.WriteLine("(4) Realizar a impressão do extrato");
Console.WriteLine("Sair");

string opcao = Console.ReadLine();

switch(opcao)
{
case "1":
Console.WriteLine("Informar os dados necessários para o depósito");
Console.WriteLine("Informe o número da agência: ");
string agencia = Console.ReadLine();
Console.WriteLine("Informar o número da conta: ");
string conta = Console.ReadLine();
Console.WriteLine("Informar o valor a ser depositado: ");
decimal valor = Console.ReadLine();
break;

case "2":
Console.WriteLine("Solicitar a quantia necessária");
break;

case "3":
Console.WriteLine("Determine o local onde será transferido o dinheiro");
break;

case "4":
Console.WriteLine("Escolha o local e a forma de transferência do extrato");
break;

}





