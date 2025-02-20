// Desafio de código: escrever um código para exibir o resultado de um lançamento de moeda.
Random coin = new Random();
int flip = coin.Next(0, 2);
Console.WriteLine((flip == 0) ? "heads" : "tails");