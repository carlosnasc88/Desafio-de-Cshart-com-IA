Exercício 02 - Interpolação de strings em C#
============================================

**Objetivo**: praticar interpolação de strings (`$"..."`) para montar mensagens com variáveis.

**Enunciado**  
Crie um novo projeto de console em C#.  
No `Program.cs`, faça o seguinte:

1. Declare e atribua valor às seguintes variáveis:
   - `string nome` com seu nome.
   - `string cidade` com o nome da cidade em que você mora.
   - `int anoAtual` com o ano atual (por exemplo, `2026`).
2. Use **interpolação de strings** para montar uma mensagem em uma única linha, seguindo o modelo:
   - `Olá, meu nome é <nome>, moro em <cidade> e estamos no ano de <anoAtual>.`
3. Exiba essa mensagem no console usando `Console.WriteLine`.

**Regras**  
- A mensagem deve usar o formato de interpolação: `$\"Olá, meu nome é {nome} ...\"`.
- Não use concatenação com `+`, apenas interpolação.
- Não use laços (`for`, `while`) nem `if`.

**Desafio extra (opcional)**  
Crie uma segunda mensagem interpolada que diga quantas letras tem o seu nome, por exemplo:  
`Meu nome tem 4 letras.`  
Para isso, você pode usar a propriedade `nome.Length` dentro da interpolação.

