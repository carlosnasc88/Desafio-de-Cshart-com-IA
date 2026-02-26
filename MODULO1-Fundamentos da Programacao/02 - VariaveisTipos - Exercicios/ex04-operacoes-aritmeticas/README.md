Exercício 04 - Operações aritméticas com variáveis
==================================================

**Objetivo**: praticar operações aritméticas com variáveis numéricas (`int` e `decimal`) e o uso de interpolação de strings para montar um pequeno resumo de compra.

**Enunciado**  
Crie um novo projeto de console em C#.  
No `Program.cs`, faça o seguinte:

1. Declare e atribua valor às seguintes variáveis:
   - `decimal precoProduto` com o preço de um produto (por exemplo, `99.90m`).
   - `int quantidade` com a quantidade comprada (por exemplo, `3`).
   - `decimal frete` com o valor do frete (por exemplo, `20.00m`).
   - `decimal descontoPercentual` com um valor de desconto em porcentagem (por exemplo, `10m` para 10%).
2. Calcule:
   - `decimal valorBruto` como `precoProduto * quantidade`.
   - `decimal valorDesconto` como `valorBruto * (descontoPercentual / 100)`.
   - `decimal valorTotal` como `valorBruto - valorDesconto + frete`.
3. Monte uma frase usando **interpolação de strings**, contendo todas as informações, por exemplo:
   - `O valor bruto da compra é R$ <valorBruto>, o desconto será de R$ <valorDesconto> e o total com frete será de R$ <valorTotal>.`
4. Exiba essa frase no console usando `Console.WriteLine`.

**Regras**  
- Use interpolação de strings (`$"..."`) para montar a mensagem final.
- Use tipos adequados: `int` para quantidade e `decimal` para valores em dinheiro.
- Não use laços (`for`, `while`) nem `if`.
- Não precisa ler nada do teclado; pode deixar todos os valores fixos no código.

**Desafio extra (opcional)**  
Crie uma segunda mensagem interpolada que mostre o **valor médio por unidade**, por exemplo:  
`Cada unidade está saindo por R$ <valorTotal / quantidade>.`

