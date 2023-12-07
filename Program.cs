using System;
class dimension
{
  static void Main(string[] args)

    {
        Console.WriteLine("Dame el radio de la circusferencia");
        float radio = Convert.ToSingle(Console.ReadLine());
        float pi = (float)Math.PI;

        float superficie = 4 * (float)Math.PI * radio * radio;
        float volumen = (4.0f / 3) * (float)Math.PI * radio * radio * radio;

        Console.WriteLine("Los valores de dimensión son los siguientes: ");
        Console.WriteLine($"Superficie: {superficie}");
        Console.WriteLine($"Volumen: {volumen}");
    }
}