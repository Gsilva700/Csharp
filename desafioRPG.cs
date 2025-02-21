// Desafio de batalha em RPG
/*Um herói e um monstro começam com a mesma pontuação de integridade.
 Durante a vez do herói,
  ele gera um valor aleatório que é subtraído da vida do monstro. 
  Se a vida do monstro for maior que zero, 
  ele toma sua vez e ataca o herói. 
  Enquanto tanto o herói quanto o monstro tiverem vida maior que zero, 
  a batalha continua.*/

int hero = 10;
int monster = 10;

Random dice = new Random();

do
{
    int roll = dice.Next(1, 11);
    monster -= roll;
    Console.WriteLine($"Monster was damaged and lost {roll} health and now has {monster} health.");

    if (monster <= 0) continue;

    roll = dice.Next(1, 11);
    hero -= roll;
    Console.WriteLine($"Hero was damaged and lost {roll} health and now has {hero} health.");

} while (hero > 0 && monster > 0);

Console.WriteLine(hero > monster ? "Hero wins!" : "Monster wins!");