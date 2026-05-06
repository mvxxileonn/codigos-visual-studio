//Pregunta 2
    int jugadoresPP = 0;
    int jugadoresAIQ = 0;
    int jugadoresPrin = 0;
    int puntuacionFinal = 0;

    Console.WriteLine("Ingrese la cantidad de jugadores");
    int N = int.Parse(Console.ReadLine());

    for (int i = 1; i <= N; i++)
    {
        Console.WriteLine($"Ingrese puntuación final jugador{i} (debe ser entre 0 y 1000)");
        puntuacionFinal = int.Parse(Console.ReadLine());

        while (puntuacionFinal < 0 || puntuacionFinal > 1000)
        {
            Console.WriteLine("Ingrese puntuación en el rango");
            puntuacionFinal = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Ingrese nivel de experiencia jugador " + i + ": 1-> Principiante | 2-> Avanzado");
        int nivelExperiencia = int.Parse(Console.ReadLine());

        if (nivelExperiencia == 1 && puntuacionFinal % 2 == 0)
            jugadoresPP += 1;
        if (nivelExperiencia == 2 && puntuacionFinal % 2 != 0 && puntuacionFinal > 500)
        {
            jugadoresAIQ++;
        }
        if (nivelExperiencia == 1)
            jugadoresPrin++;
    }

    Console.WriteLine($"La cantidad de jugadores principiantes que obtuvieron puntuación par es {jugadoresPP}");
    Console.WriteLine($"La cantidad de jugadores avanzados que obtuvieron una puntuación impar, mayor a 500 es {jugadoresAIQ}");
    //comprobar division por cero
    if (N != 0)
    {
        Console.WriteLine($"El porcentaje de jugadores principiantes es {jugadoresPrin * 100 / N}");
        Console.WriteLine($"El porcentaje de jugadores avanzados es {(N - jugadoresPrin) * 100 / N}");
    }