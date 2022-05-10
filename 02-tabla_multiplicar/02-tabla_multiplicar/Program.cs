Console.WriteLine("Ingrese el número de la tabla de multiplicar: ");
int number = int.Parse(Console.ReadLine());

for (int row = 1; row <= 10; row++)
{
    Console.WriteLine($"{number} x {row} = {number * row}");
}
