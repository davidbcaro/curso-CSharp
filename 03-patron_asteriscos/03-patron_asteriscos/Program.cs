Console.WriteLine("Ingrese el caracter para imprimir el patrón: ");
string patron = Console.ReadLine();
Console.WriteLine("");

for (int a = 1; a <= 5; a++)
{
    for (int b = 1; b <= a; b++)
    {
        Console.Write(patron);
    }
    Console.WriteLine("");
}
for (int a = 4; a >= 1; a--)
{
    for (int b = 1; b <= a; b++)
    {
        Console.Write(patron);
    }
    Console.WriteLine("");
}