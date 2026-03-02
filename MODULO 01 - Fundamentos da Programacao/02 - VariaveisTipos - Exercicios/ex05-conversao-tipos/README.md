Exercício 05 - Conversão e tipos numéricos
=========================================

**Objetivo**: praticar o uso de tipos numéricos (`double` e `int`), conversão (cast) entre tipos e interpolação de strings.

**Enunciado**  
Crie um novo projeto de console em C#.  
No `Program.cs`, faça o seguinte:

1. Declare e atribua valor às seguintes variáveis:
   - `double temperaturaCelsius` com um valor decimal (por exemplo, `26.8`).
2. Calcule:
   - `double temperaturaFahrenheit` usando a fórmula:  
     `temperaturaFahrenheit = (temperaturaCelsius * 9 / 5) + 32;`
   - `int temperaturaInteira` contendo apenas a parte inteira de `temperaturaCelsius` (use cast: `(int)temperaturaCelsius`).
3. Monte uma mensagem usando **interpolação de strings**, seguindo o modelo (pode adaptar o texto, mas mantenha as informações):
   - `A temperatura de <temperaturaCelsius>°C corresponde a <temperaturaFahrenheit>°F. A parte inteira em Celsius é <temperaturaInteira>°C.`
4. Exiba essa mensagem no console com `Console.WriteLine`.

**Regras**  
- Use interpolação de strings (`$"..."`) para montar a mensagem.
- Use `double` para as variáveis com casas decimais e `int` para a parte inteira.
- Utilize o cast explícito `(int)` para converter de `double` para `int`.
- Não use laços (`for`, `while`) nem `if`.
- Não precisa ler nada do teclado; pode deixar todos os valores fixos no código.

**Desafio extra (opcional)**  
Calcule também a temperatura em Kelvin em uma nova variável `double temperaturaKelvin`, usando a fórmula:  
`temperaturaKelvin = temperaturaCelsius + 273.15;`  
Crie uma segunda mensagem interpolada exibindo o valor em Kelvin.

