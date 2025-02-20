// Operadores de Comparação  


// (==) Operador de igualdade
// Console.WriteLine("a" == "a");
// Console.WriteLine("a" == "A");
// Console.WriteLine(1 == 2);

// string myValue = "a";
// Console.WriteLine(myValue == "a");

// (!=) Operador de desigualdade
// Console.WriteLine("a" != "a");
// Console.WriteLine("a" != "A");
// Console.WriteLine(1 != 2);

// string myValue = "a";
// Console.WriteLine(myValue != "a");

//  Operadores de comparação

// Console.WriteLine(1 > 2); Maior
// Console.WriteLine(1 < 2); Menor
// Console.WriteLine(1 >= 1); Maior ou igual
// Console.WriteLine(1 <= 1); Menor ou igual

// Método que retorna um booliano
// string pangram = "The quick brown fox jumps over the lazy dog.";
// Console.WriteLine(pangram.Contains("fox"));
// Console.WriteLine(pangram.Contains("cow"));

// operador de negação lógica !NOT
// String pangram = "The quick brown fox jumps over the lazy dog.";
// Console.WriteLine(!pangram.Contains("fox"));
// Console.WriteLine(!pangram.Contains("cow"));

/* Operador de desigualdade versus negação lógica
O operador de desigualdade != 
inclui um caractere !, 
mas não deve ser confundido com negação lógica. 
O operador de desigualdade retornará true se seus operandos não forem iguais 
e retornará false se os operandos forem iguais. 
Para os operandos dos tipos internos, 
a expressão x != y produz o mesmo resultado que a expressão !(x == y) 

O exemplo de código a seguir demonstra o uso do operador !=: */

// int a = 7;
// int b = 6;
// Console.WriteLine(a != b); // output: True
// string s1 = "Hello";
// string s2 = "Hello";
// Console.WriteLine(s1 != s2); // output: False

// Operador condicional
/*O operador condicional ?: 
avalia uma expressão booliana 
e retorna um dos dois resultados,
 dependendo se a expressão booliana é avaliada como verdadeira ou falsa. 
 O operador condicional normalmente é chamado de operador condicional ternário.
Este é o formato básico:*/

//<evaluate this condition> ? <if condition is true, return this value> : <if condition is false, return this value>