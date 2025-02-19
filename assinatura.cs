// Algoritimo para checagem de assinatura

// usa a class Random para gerar um número aleatório

Random random = new Random();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;

// se os dias até expirar são iguais a 0
if (daysUntilExpiration == 0)
{
    Console.WriteLine("Your subscription has expired.");
}
// se forem iguais a 1

else if (daysUntilExpiration == 1)
{
    Console.WriteLine("Your subscription expires within a day!");
    discountPercentage = 20;
}
// se forem menor ou iguais a 5
else if (daysUntilExpiration <= 5)
{
    Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.");
    discountPercentage = 10;
}

// se forem menores ou iguais a 10
else if (daysUntilExpiration <= 10)
{
    Console.WriteLine("Your subscription will expire soon. Renew now!");
}

// se for menor que zero  
if (discountPercentage > 0)
{
    Console.WriteLine($"Renew now and save {discountPercentage}%.");
}
