class Program
{
    static void Main()
    {

        Console.WriteLine("Calculadora de IMC");
        Console.WriteLine("Ingrese su peso en Kgs:");
        float peso = Convert.ToSingle(Console.ReadLine());


        Console.WriteLine("Ingrese su altura en mts: ");
        float altura = Convert.ToSingle(Console.ReadLine());

        float imc = CalcularImc(peso, altura);
        
        string clasificacion = ClasificarObesidad(imc);

        Console.WriteLine("Su indice de masa corporal es de: " + imc + " Y su clasificacíón es: " + clasificacion);
    }

    static float CalcularImc(float peso, float altura)
    {
        float imc = peso / ( altura * altura );

        return imc;
    }
    static string ClasificarObesidad(float imc)
    {
        if (imc < 18.5)
        {
            return "Bajo peso";
        }
        else if (imc < 25)
        {
            return "Normal";
        }
        else if (imc < 30)
        {
            return "Sobrepeso";
        }
        else if (imc < 35)
        {
            return "Obesidad grado I - Moderado";
        }
        else if (imc < 40)
        {
            return "Obesidad grado II - Severo";
        }
        else
        {
            return "Obesidad grado III - Muy severo";
        }
    }
}
