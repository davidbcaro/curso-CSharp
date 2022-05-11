Console.WriteLine("Ingrese el valor de la cuenta: ");
int valor = int.Parse(Console.ReadLine());

if (valor < 150000)
{
    Console.WriteLine("El tipo de pago a usar es efectivo");
}
else if (valor >= 150000 && valor <= 300000)
{
    Console.WriteLine("El tipo de pago a usar es pago con celular");
}
else if (valor > 300000 && valor <= 600000)
{
    Console.WriteLine("El tipo de pago a usar es tarjeta débito");
}
else
{
    Console.WriteLine("El tipo de pago a usar es tarjeta crédito");
}