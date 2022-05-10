
Circulo miCirculo; // Creación del objeto tipo Círuclo
miCirculo = new Circulo(); // Instanciar una clase. Creación de un ejemplar de la clase
Console.WriteLine($"El área del circulo es: {miCirculo.calcularArea(6)} cm");
class Circulo
{
    double pi = 3.14;

    public double calcularArea(double radio)
    {
        //Console.WriteLine("El área del ciruclo es: ");
        return  pi * radio * radio;
    }
}




