// Exercício – Formatar cadeias de caracteres literais em C#

 Console.WriteLine("Hello\nWorld!");
 Console.WriteLine("Hello\tWorld!");

// aspas dupla em cadeia de caracteres literal

Console.WriteLine("Hello \"World\"!");

// use \\ para exibir uma barra invertida simples.
 Console.WriteLine("c:\\source\\repos");

// Formatar a saída usando sequências de escape de caracteres

Console.WriteLine("Generating invoices for customer \"Contoso Corp\" ... \n");
Console.WriteLine("Invoice: 1021\t\tComplete!");
Console.WriteLine("Invoice: 1022\t\tComplete!");
Console.WriteLine("\nOutput Directory:\t");

// Literal de cadeia de caracteres verbatim
// manter espaço em branco usar @

Console.WriteLine(@"   c:\source\repos
(this is where your code goes)");

Console.Write(@"c:\invoices");

// Caracteres de escape Unicode

// Kon'nichiwa World
Console.WriteLine("\u3053\u3093\u306B\u3061\u306F World!");

