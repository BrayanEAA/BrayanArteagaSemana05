Console.WriteLine("ingrese el valor inicial: ");
int ValorInicial = int.Parse(Console.ReadLine());

Console.WriteLine("ingrese el valor final: ");
int ValorFinal = int.Parse(Console.ReadLine());

Console.WriteLine("los numeros pares dentro del rango ingresado son: ");

for (int i = ValorInicial; i <= ValorFinal; i++)
{
    if (i % 2 ==0)
    {
        Console.WriteLine(i + " ");
    }
}

