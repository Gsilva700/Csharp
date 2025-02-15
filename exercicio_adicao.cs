// Exercício Realizar adição com conversão implícita de dados

int firstNumber = 12;
int secondNumber = 7;
Console.WriteLine(firstNumber + secondNumber);

// Adicionar parênteses para esclarecer sua intenção ao compilador
string firstName = "Bob";
int widgetsSold = 7;
Console.WriteLine(firstName + " sold " + (widgetsSold + 7) + " widgets."); 

// Executar operações matemáticas básicas

int sum = 7 + 5;
int difference = 7 - 5;
int product = 7 * 5;
//int quotient = 7 / 5;

Console.WriteLine("Sum: " + sum);
Console.WriteLine("Difference: " + difference);
Console.WriteLine("Product " + product);

// int não pode conter valores após a casa decimal
//Console.WriteLine("Quotient: " + quotient);

decimal decimalQuotient = 7.0m / 5;
Console.WriteLine($"Decimal quotient: {decimalQuotient}");

// Para converter int em decimal, você adiciona o operador de conversão antes do valor.

int first = 7;
int second = 5;
decimal quotient = (decimal)first / (decimal)second;
Console.WriteLine(quotient);


// O operador de módulo % informa o resto da divisão de int.
Console.WriteLine($"Modulos of 200 / 5 : {200 % 5}");
Console.WriteLine($"Modulos of 7 / 5 : {7 % 5}");

// Ordem das operações

int value1 = 3 + 4 * 5;
int value2 = (3 + 4) * 5;
Console.WriteLine(value1);
Console.WriteLine(value2);