// Instanciar una clase o creando un ejemplar de la clase Car
Car MiCarro = new Car();
Console.WriteLine("Objeto Vehículo");
Console.WriteLine($"Marca: {MiCarro.marca}");
Console.WriteLine($"Color: {MiCarro.color}");
Console.WriteLine($"Placa: {MiCarro.placa}");
Console.WriteLine($"Velocidad: {MiCarro.maxVelocidad}");
Console.WriteLine($"Encendido: {MiCarro.encender()}");
Console.WriteLine($"Apagado: {MiCarro.apagar()}");

class Car
{
    public string marca = "Audi";
    public string color = "Blanco";
    public int maxVelocidad = 200;
    public string placa = "MTR340";
    int modelo = 2022;
    int cilindraje = 1800;

    public bool encender()
    {
        return true;
    }

    public bool apagar()
    {
        return true;
    }
}



