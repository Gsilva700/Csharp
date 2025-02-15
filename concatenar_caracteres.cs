// Concatenar uma cadeia de caracteres literal e uma variável

//básico
//string firstName = "Bob";
//string greeting = "Hello";
//Console.WriteLine(greeting + " " + firstName + "!");

// interpolação de cadeia de caracteres

//string firstName = "Bob";
//string message = $"Hello {firstName}!";
// Console.WriteLine(message);

// Evitar variáveis intermediárias 
//int version = 11;
//string updateText = "Update to Windows";
//string message = $"{updateText} {version}";
//Console.WriteLine(message);


// sem variaveis intermediarias
int version = 11;
string updateText = "Update to Windows";
Console.WriteLine($"{updateText} {version}!");

// Combinar literais textuais e interpolação de cadeia de caracteres
string projectName = "First-Project";
Console.WriteLine($@"C:\Output\{projectName}\Data");