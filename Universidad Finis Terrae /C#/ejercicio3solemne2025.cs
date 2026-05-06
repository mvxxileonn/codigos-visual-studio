//Ejercicio 3 
int tipoAnimal = 0;
int edadAnimal = 0;
bool adopcion = false;

int perros = 0;
int gatos = 0; 
int otros = 0;

int sumaEdades = 0;
int cantidadAdoptados = 0;

    Console.WriteLine("Ingrese tipo de animal: 1-> Perro, 2-> Gato , 3-> Otro animal, 0 = Fin del registro");
    tipoAnimal = int.Parse(Console.ReadLine());

while (tipoAnimal != 0)
{
    Console.WriteLine("Edad del animal");
    edadAnimal = int.Parse(Console.ReadLine());
    Console.WriteLine("ingrese si a sido adoptado (true/false)");
    adopcion = bool.Parse(Console.ReadLine());

    if (tipoAnimal == 1)
        perros++;
    else if (tipoAnimal == 2)
        gatos++;
    else if (tipoAnimal == 3)
        otros++;

    sumaEdades = sumaEdades + edadAnimal;

    if (adopcion == true)
        cantidadAdoptados += 1;

    Console.WriteLine("Ingrese tipo de animal: 1-> Perro, 2-> Gato , 3-> Otro animal, 0 = Fin del registro");
    tipoAnimal = int.Parse(Console.ReadLine());
}

Console.WriteLine("Cantidad total de perros" + perros);
Console.WriteLine("Cantidad total de perros" + gatos);
Console.WriteLine("Cantidad total de perros" + otros);
int cantidadAnimales = perros + gatos + otros;
Console.WriteLine("el promedio de edad es{ sumaEdades/(cantidadAnimales)}");
int porcentajeAniales = cantidadAdoptados * 100 / cantidadAnimales;
Console.WriteLine($"el porcentaje de animles adoptados es: ");