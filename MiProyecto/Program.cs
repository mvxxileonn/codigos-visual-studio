Console.WriteLine("Ingrese su edad:");
string input = Console.ReadLine();
int edad;
if (int.TryParse(input, out edad))
{
    if (edad >= 18)
    {
        Console.WriteLine("Eres mayor de edad.");
    }
    else
    {
        Console.WriteLine("Eres menor de edad.");
    }
}
else
{
    Console.WriteLine("Entrada no válida. Por favor, ingresa un número.");
} 