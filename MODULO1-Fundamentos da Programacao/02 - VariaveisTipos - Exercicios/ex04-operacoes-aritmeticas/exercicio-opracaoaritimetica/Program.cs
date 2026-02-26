decimal precoProduto = 99.90m;
int quantidade = 3;
decimal frete = 20.00m;
decimal descontoPercentual = 10m;//Valor equivalente a 10%.

//Calculando
decimal valorBruto = precoProduto * quantidade;
decimal valorDesconto =  valorBruto * (descontoPercentual / 100);
decimal valorTotal = valorBruto - valorDesconto + frete;
decimal valorMedioPorUnidade = valorTotal / quantidade;



//Retorno dos resultados:
Console.WriteLine($"O valor bruto da compra é R$ {valorBruto},  o desconto será de R${valorDesconto} e tatal do frete será de R${valorTotal} ");
Console.WriteLine();
Console.WriteLine($"Valor médio po unidade é de {valorMedioPorUnidade}");