// Instanciar una clase o creando un ejemplar de la clase Car
Car MiCarro = new Car();
Console.WriteLine(MiCarro.marca);
Console.WriteLine(MiCarro.color);
Console.WriteLine(MiCarro.encender());

class Car
{
    public string marca = "Audi";
    public string color = "Blanco";
    int maxVelocidad = 200;
    string placa = "MTR340";
    int modelo = 2022;
    int cilindraje = 1800;

    public bool encender()
    {
        return true;
    }

    public bool apagar()
    {
        return false;
    }
}



