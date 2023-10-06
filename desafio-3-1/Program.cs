class Program
{
    static void Main()
    {
        Console.WriteLine("Ingresa el salario actual:");
        int salario_actual = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ingresa el incremento mínimo establecido:");
        int incremento_salarial = Convert.ToInt32(Console.ReadLine());

        int salario_actualizado = CalculadoraIncrementoSalarial(salario_actual, incremento_salarial);

        Console.WriteLine("El nuevo salario es: " + salario_actualizado);

    }

    static int CalculadoraIncrementoSalarial(int salario, int incremento)
    {
        int salario_actualizado = salario + (salario * (incremento / 100));

        return salario_actualizado;
    }
}
