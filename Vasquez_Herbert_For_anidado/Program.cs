//creacion de la tarea
//la seleccion de los ejercicios xd
Console.WriteLine("Mostrar un cuadrado de 5x5 con números 1.\r\n\r\nMostrar un rectángulo de 4 filas y 6 columnas con asteriscos.\r\n\r\nMostrar un triángulo creciente de 5 filas con asteriscos.\r\n\r\nMostrar un triángulo invertido de 5 filas.\r\n\r\nMostrar una tabla de multiplicar del 1 al 5 (todas juntas).\r\n\r\nMostrar una matriz 3x3 con números consecutivos del 1 al 9.\r\n\r\nMostrar las combinaciones posibles de números del 1 al 3 (ejemplo: 1-1, 1-2...).\r\n\r\nMostrar una tabla donde las filas sean del 1 al 4 y las columnas del 1 al 4.\r\n\r\nMostrar un patrón donde cada fila tenga el número de la fila repetido.\r\n\r\nMostrar un patrón numérico como:");
int opcion = int.Parse(Console.ReadLine());
switch (opcion)
{

    case 1:
        Console.Clear();
        Console.WriteLine("ejercicio resuelto: ");
        for (int i = 0; i < 5; i++ )
        {
            for (int x= 0; x <5; x++)
            {
                Console.Write("1 ");
           
            }
            Console.WriteLine();
        }
        break;

    case 2:
        Console.Clear();
        Console.WriteLine("ejercicio resuelto: ");
        for (int i = 0; i < 4; i++)
        {
            for (int x = 0; x < 6; x++)
            {
                Console.Write("* ");

            }
            Console.WriteLine();
        }
        break;

    case 3:
        Console.Clear();

        string asteriscossuma = "";
        for (int i = 1; i <= 5; i++)
        {
           
            asteriscossuma += "*";
            Console.WriteLine(asteriscossuma);

        }
        break;

    case 4:
        Console.Clear();

        string asteriscoresta = "";
        for (int i = 5; i >= 1; i--)
        {
            asteriscoresta = "";
            for (int j = 1; j <= i; j++)
            {
                asteriscoresta += "*";
            }
            Console.WriteLine(asteriscoresta);
        }

        break;

    case 5:
        break;

    case 6:
        break;

    case 7:
        break;

    case 8:
        break;

    case 9:
        break;

    case 10:
        break;

    default:
        break;
}