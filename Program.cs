
Console.WriteLine(" ---Tabuada--- \n");

Console.WriteLine("Inicio:");

Console.Write("Digite um Valor para a Tabuada...: ");
int numero = int.Parse(Console.ReadLine()!);

int contador = 1;

while (contador <= 10)
{
   int resultado = numero * contador;
    Console.WriteLine($"{numero} x {contador} = {resultado}");
    contador = contador +1;
}

 Console.WriteLine("  Fim. \n");