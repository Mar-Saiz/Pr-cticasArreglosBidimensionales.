using System;

class Program
{
    static void Main()
    {
      
      int filas= 0, columnas = 0;

        try {
            Console.Write("Ingrese el número de filas: ");
             filas = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el número de columnas: ");
             columnas = int.Parse(Console.ReadLine());

        }
        catch(Exception error)
        {
            Console.WriteLine("Error al ingresar el número de columnas: " + error.Message);
            
        }
      

        int[,] matriz = new int[filas, columnas];

     
        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                Console.Write($"Ingrese el valor para la posición [{i},{j}]: ");

                try {

                    matriz[i, j] = int.Parse(Console.ReadLine());
                }
                catch(Exception error)
                {
                    Console.WriteLine("Error al ingresar el valor: " + error.Message);
                    return;
                }
            }
        }

       
        Console.WriteLine("\nMatriz ingresada:");
        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                Console.Write(matriz[i, j] + "\t");
            }
            Console.WriteLine();
        }

        // Inicializar mayor y menor
        int mayor = matriz[0, 0];
        int menor = matriz[0, 0];
        int filaMayor = 0, columnaMayor = 0;
        int filaMenor = 0, columnaMenor = 0;

       
        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                if (matriz[i, j] > mayor)
                {
                    mayor = matriz[i, j];
                    filaMayor = i;
                    columnaMayor = j;
                }

                if (matriz[i, j] < menor)
                {
                    menor = matriz[i, j];
                    filaMenor = i;
                    columnaMenor = j;
                }
            }
        }
       
        Console.WriteLine($"\nValor mayor: {mayor} en la posición [{filaMayor},{columnaMayor}]");
        Console.WriteLine($"Valor menor: {menor} en la posición [{filaMenor},{columnaMenor}]");
    }
}
