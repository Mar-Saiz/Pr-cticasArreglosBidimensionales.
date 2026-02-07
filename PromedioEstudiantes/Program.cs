int[,] Notas = new int[4, 3];

for (int i = 0; i < 4; i++)
{
    for (int j = 0; j < 3; j++)
    {
        Console.WriteLine($"Ingrese la nota {j + 1} del estudiante {i + 1}: ");

        try
        {
            Notas[i, j] = int.Parse(Console.ReadLine());
        }
        catch (Exception error)
        {
            Console.WriteLine("Error: " + error.Message);
        }

    }

}

for (int i = 0; i < 4; i++)
{
    int suma = 0;
    for (int j = 0; j < 3; j++)
    {
        suma += Notas[i, j];
    }
    double promedio = suma / 3.0;
    Console.WriteLine($"El promedio del estudiante {i + 1} es: {promedio}");
}

for (int i = 0; i < 4; i++)
{
    int suma = 0;
    for (int j = 0; j < 3; j++)
    {
        suma += Notas[i, j];
    }
    double promedio = suma / 4.0;
    Console.WriteLine($"El promedio de la asignatura {i + 1} es: {promedio}");
}