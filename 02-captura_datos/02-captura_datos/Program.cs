Console.WriteLine("Ingrese su nombre completo: ");
string nombre = Console.ReadLine();
Console.WriteLine("Ingrese su peso en kilogramos (Ej. 67,98 kg.): ");
float peso = float.Parse(Console.ReadLine());
Console.WriteLine($"Usuario {nombre} su peso es {peso} kg.");