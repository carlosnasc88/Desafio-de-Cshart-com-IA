

using System.Diagnostics;
while(true){    
Console.WriteLine("----------------------------------------------");
Console.WriteLine(" Seja bem vindo ao nosso modulo de pagamentos");
Console.WriteLine("----------------------------------------------");
Console.WriteLine(@"
Informe o mei de pagmento:
1 - Dinheiro
2 - Cartão de Crédito
3 - Cartão de Débito
4 - Pix
0 - Sair
");
int opcao = int.Parse(Console.ReadLine());
Console.Clear();
switch(opcao){
    case 1 : 
    Console.WriteLine("Você escolheu pagar com Dinheiro....");Thread.Sleep(1500);
    break;
    case 2 : 
    Console.WriteLine("Você escolheu pagar com Cartão de Crédito....");Thread.Sleep(1500);
    break;
    case 3 : 
    Console.WriteLine("Você escolheu pagar com Cartão de Débito....");Thread.Sleep(1500);
    break;
    case 4 : 
    Console.WriteLine("Você escolheu pagar com  Pix....");Thread.Sleep(1500);
    break;
    case 0 : 
    Console.WriteLine("Saindo do programa....");Thread.Sleep(1500);
    return;
    default : 
    Console.WriteLine("Opção inválida....");Thread.Sleep(1500);
    continue;
}


Console.WriteLine("Digite valor total da compra: ");
double valorTotal = double.Parse(Console.ReadLine());



if(valorTotal >100 && valorTotal < 500){
    double desconto =valorTotal * 0.05;
    Console.WriteLine($"Parabéns pela compra! Voce Obteve 5% de desconto R${desconto:F2}");
    Thread.Sleep(1500);
    Console.WriteLine($"O valor totaol a ser pago é R${valorTotal - desconto:F2}");

}
else if(valorTotal >=500 && valorTotal < 1000)
{
    double desconto =valorTotal * 0.1;
    Console.WriteLine($"Parabéns pela compra! Voce Obteve 10% de desconto R${desconto:F2}");
    Thread.Sleep(1500);
    Console.WriteLine($"O valor totaol a ser pago é R${valorTotal - desconto:F2}");
}
else if(valorTotal >=1000){
    double desconto =valorTotal * 0.15;
    Console.WriteLine($"Parabéns pela compra! Voce Obteve15% de desconto R${desconto:F2}");
    Thread.Sleep(1500);
    Console.WriteLine($"O valor totaol a ser pago é R${valorTotal - desconto:F2}");
}

}