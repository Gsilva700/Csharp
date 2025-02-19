// Checar ordem fradulentas
/*
string[] fraudulentOrderIDs = new string[3];

fraudulentOrderIDs[0] = "A123";
fraudulentOrderIDs[1] = "B456";
fraudulentOrderIDs[2] = "C789";
// fraudulentOrderIDs[3] = "D000";
*/

// Declara a matriz e inicializa os valores em uma única instrução
string[] fradulentOrderIDs = [ "A123", "B456", "C789",];


Console.WriteLine($"First: {fradulentOrderIDs[0]}");
Console.WriteLine($"Second: {fradulentOrderIDs[1]}");
Console.WriteLine($"Third: {fradulentOrderIDs[2]}");

fradulentOrderIDs[0] = "F000";

Console.WriteLine($"Reassign First: {fradulentOrderIDs[0]}");

// Propriedade Length da matriz
Console.WriteLine($"There are {fradulentOrderIDs.Length} fradulent orders to process.");
