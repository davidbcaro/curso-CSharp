// Operadores aritméticos
float numero1 = 32F;
float numero2 = 10F;
float numero3 = 3F;
float numero4 = 3F;
float suma;
float resta;
float multiplicacion;
float division;
float modulo;
double potencia;

suma = numero1 + numero2;
resta = numero1 - numero2;
multiplicacion = numero1 * numero2;
division = numero1 / numero2;
modulo = numero1 % numero2;
// Función potencia
potencia = Math.Pow(numero3, numero4);

Console.WriteLine($"El resultado de la suma es {suma}");
Console.WriteLine($"El resultado de la resta es {resta}");
Console.WriteLine($"El resultado de la multiplicación es {multiplicacion}");
Console.WriteLine($"El resultado de la división es {division}");
Console.WriteLine($"El resultado del módulo es {modulo}");
Console.WriteLine($"El resultado de la potencia es {potencia}");

Console.WriteLine($"Los resultados son:\n suma = {suma}" +
                                     $"\n resta = {resta} " +
                                     $"\n multiplicación {multiplicacion}");
