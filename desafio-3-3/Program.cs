Random aleatorio = new Random();
int num_aleatorio = aleatorio.Next(1, 101);

Console.WriteLine(num_aleatorio);

Boolean adivinado = false;
int intentos = 0;

while (adivinado != true)
{
    Console.WriteLine("Adivina el número entre 1 y 100");
    int num_jugador = Convert.ToInt32(Console.ReadLine());

    intentos++;

    if (num_jugador == num_aleatorio)
    {
        Console.WriteLine("¡Felicidades! Adivinaste el número en " + intentos + " intentos.");
    }
    else if (num_jugador < num_aleatorio)
    {
        Console.WriteLine("El número seleccionado es demasiado bajo. Intenta de nuevo.");
    }
    else
    {
        Console.WriteLine("El número seleccionado es demasiado alto. Intenta de nuevo.");
    }
}