Console.WriteLine("Ingrese su edad");
int edad = int.Parse(Console.ReadLine());
Console.WriteLine("Eliga la membresia");
string membresia = Console.ReadLine();
if (edad<18)
{
    Console.WriteLine("descuento del 15%");
}
else if (edad<=18 && edad<=60)
{
    if (membresia == "regular")
        Console.WriteLine("No recibe descuento");
    else if (membresia == "Premium")
        Console.WriteLine("descuento del 10%");
    else if (membresia =="VIP")
        Console.WriteLine("descueto del 20%");
}
else if (edad>60)
    Console.WriteLine("descueto del 25%");
{
    string descuento = null;
    Console.WriteLine("descuento aplicado:" + descuento + "%");
}