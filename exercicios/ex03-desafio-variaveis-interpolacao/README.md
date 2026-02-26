Exercício 03 - Desafio: variáveis + interpolação
================================================

**Objetivo**: juntar o uso de vários tipos de variáveis com interpolação de strings para montar um “resumo” sobre uma pessoa.

**Enunciado**  
Crie um novo projeto de console em C#.  
No `Program.cs`, faça o seguinte:

1. Declare e atribua valor às seguintes variáveis:
   - `string nome` com o seu nome.
   - `int idade` com a sua idade.
   - `double altura` com a sua altura em metros.
   - `string profissao` com a profissão que você gostaria de ter (por exemplo, `"Desenvolvedor C#"`).
   - `decimal salarioDesejado` com um valor de salário desejado (por exemplo, `7500.50m`).
2. Monte uma única frase usando **interpolação de strings**, seguindo o modelo (você pode adaptar o texto, mas mantendo todas as informações):
   - `Meu nome é <nome>, tenho <idade> anos, tenho <altura>m de altura, quero trabalhar como <profissao> e meu salário desejado é R$ <salarioDesejado>.`
3. Exiba essa frase no console usando `Console.WriteLine`.

**Regras**  
- Use interpolação de strings (`$"..."`) para colocar todas as variáveis dentro da mensagem.
- Use tipos adequados: `string`, `int`, `double`, `decimal`.
- Não use laços (`for`, `while`) nem `if`.
- Não precisa ler nada do teclado; pode deixar todos os valores fixos no código.

**Desafio extra (opcional)**  
Crie uma segunda mensagem interpolada que faça uma pequena “conta” simples, por exemplo:  
`Se eu ganhar R$ <salarioDesejado> por mês, em 12 meses vou ganhar R$ <salarioDesejado * 12>.`

