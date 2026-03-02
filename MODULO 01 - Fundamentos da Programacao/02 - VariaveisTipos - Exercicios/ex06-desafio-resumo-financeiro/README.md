Exercício 06 - Desafio: resumo financeiro com variáveis
=======================================================

**Objetivo**: juntar o uso de vários tipos de variáveis numéricas com operações aritméticas e interpolação de strings para montar um pequeno resumo financeiro pessoal.

**Enunciado**  
Crie um novo projeto de console em C#.  
No `Program.cs`, faça o seguinte:

1. Declare e atribua valor às seguintes variáveis:
   - `string nome` com o seu nome.
   - `decimal salarioMensal` com o valor do seu salário mensal desejado (por exemplo, `5000.00m`).
   - `decimal gastosEssenciais` com a soma dos gastos fixos/essenciais por mês (aluguel, contas, mercado, por exemplo `3000.00m`).
   - `decimal gastosLazer` com a soma dos gastos de lazer por mês (por exemplo, `800.00m`).
2. Calcule:
   - `decimal totalGastos` como `gastosEssenciais + gastosLazer`.
   - `decimal saldoMensal` como `salarioMensal - totalGastos`.
3. Use **interpolação de strings** para montar uma mensagem de resumo financeiro, por exemplo:
   - `Resumo financeiro de <nome>: ganho R$ <salarioMensal> por mês, gasto R$ <gastosEssenciais> com essenciais e R$ <gastosLazer> com lazer, e me sobra R$ <saldoMensal> todo mês.`
4. Exiba essa mensagem no console com `Console.WriteLine`.

**Regras**  
- Use interpolação de strings (`$"..."`) para montar a mensagem.
- Use o tipo `decimal` para todos os valores em dinheiro.
- Não use laços (`for`, `while`) nem `if`.
- Não precisa ler nada do teclado; pode deixar todos os valores fixos no código.

**Desafio extra (opcional)**  
Crie uma segunda mensagem interpolada calculando quanto você juntaria em 12 meses com esse saldo mensal, por exemplo:  
`Se eu mantiver esse saldo por 12 meses, vou juntar R$ <saldoMensal * 12>.`

