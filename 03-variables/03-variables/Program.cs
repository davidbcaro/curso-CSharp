﻿string nombreCompleto;
int edad;
double peso;
Console.WriteLine("Ingresa tu nombre completo:");
nombreCompleto = Console.ReadLine();
Console.WriteLine("Ingresa tu edad:");
//edad = Convert.ToInt32(Console.ReadLine());
edad = int.Parse(Console.ReadLine());
Console.WriteLine("Ingresa tu peso:");
peso = double.Parse(Console.ReadLine());
Console.WriteLine("Hola " + nombreCompleto + ", tienes " + edad + " años y un peso de: " + peso);
Console.WriteLine($"Hola {nombreCompleto}, tienes {edad} años y un peso de {peso}");
Console.WriteLine($"Nombre: {nombreCompleto}\n Edad: {edad} años\n Peso: {peso}");
double number1 = 3.5;
double number2 = 2.1;
Console.WriteLine(number1 + number2);
