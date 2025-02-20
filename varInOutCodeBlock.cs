// Blocos de código e escopo de variáveis
/*Quando você declara uma variável dentro de um bloco de código,
 a visibilidade dela é local para esse bloco de código 
 e essa variável não pode ser acessada fora do bloco de código.
Para garantir que uma variável esteja visível dentro e fora de um bloco de código, 
você deve declarar a variável antes do bloco de código
 (fora e acima do bloco de código).
Verifique se as variáveis são inicializadas antes que seu código tente acessá-las 
(para todos os caminhos de execução de código possíveis).*/
bool flag = true;
int value = 0;

if (flag)
{
    Console.WriteLine($"Inside the code block: {value}");
}
value = 10;
Console.WriteLine($"Outside the code block: {value}");
