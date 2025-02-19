// Executar um loop em uma matriz usando o foreach
using System.Collections;

int[] inventory = { 200, 450, 700, 175, 250 };

// variavel para soma de todos os prontos
int sum =0;
// var para armazenar o número do compartimento que tem um estoque sendo processado no momento.
int bin = 0;

foreach (int items in inventory)
{
    sum += items;
    bin++;
    Console.WriteLine($"Bin {bin} = {items} items (Running total: {sum})");
}

Console.WriteLine($"We have {sum} items in inventory.");

