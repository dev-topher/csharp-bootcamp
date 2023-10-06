var opciones_de_juego = new List<string> { "Piedra", "Papel", "Tijeras" }; // Opciones de juego

Console.WriteLine("------------Menu------------");
Console.WriteLine("¿Piedra, papel o tijeras?");
Console.WriteLine("Ingresa la opción por teclado que prefiera");

string opcion_de_jugador = Console.ReadLine();

if (opciones_de_juego.Contains(opcion_de_jugador))
{
    Random aleatorio = new Random();
    int opcion_maquina = aleatorio.Next(3);

    Console.WriteLine("Jugador: " + opcion_de_jugador);
    Console.WriteLine("Maquina: " + opciones_de_juego[opcion_maquina]);

    if (opcion_de_jugador == opciones_de_juego[opcion_maquina])
    {
        Console.WriteLine("***** Empate *****");
    }

    else if ((opcion_de_jugador == opciones_de_juego[0] && opciones_de_juego[opcion_maquina] == opciones_de_juego[2]) || 
        (opcion_de_jugador == opciones_de_juego[1] && opciones_de_juego[opcion_maquina] == opciones_de_juego[0]) || 
        (opcion_de_jugador == opciones_de_juego[2] && opciones_de_juego[opcion_maquina] == opciones_de_juego[1]))
    {
        Console.WriteLine("***** Felicidades, ¡Ganaste! *****");
    }
    else
    {
        Console.WriteLine("***** Perdiste :( *****");
    }
}
else
{
    Console.WriteLine("Argumento invalido: Debe ser Piedra, Papel o Tijera.");
}