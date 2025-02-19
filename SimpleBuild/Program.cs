/* A finalidade desse código é inverter uma cadeia de caracteres
 e contar o número de vezes que um caractere específico é exibido. 
*/


string str = "The quick brown fox jumps over the lazy dog.";

char[] charMessage = str.ToCharArray();
Array.Reverse(charMessage);

int x = 0;

foreach (char i in charMessage) 

   { if (i == 'o') 
   
   { x++; } 
   
   }

string new_message = new String(charMessage);

Console.WriteLine(new_message);

Console.WriteLine($"'o' appears {x} times.");