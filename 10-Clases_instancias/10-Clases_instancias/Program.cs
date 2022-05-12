
Circulo miCirculo; // Creación del objeto tipo Círculo
miCirculo = new Circulo(); // Instanciar una clase. Creación de un ejemplar de la clase
Console.WriteLine($"El área del circulo es: {miCirculo.calcularArea(6.8)} cm^2");
class Circulo
{
    double pi = 3.14;

    public double calcularArea(double radio)
    {
        //Console.WriteLine("El área del círculo es: ");
        return  pi * radio * radio;
    }
}




