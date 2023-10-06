using System.Numerics;

Console.WriteLine("Numero Par");

int i = 0;
while (i <= 20)
{
    if (i % 2 == 0)
    {
        Console.WriteLine(i);
    }
    i++;
}

Console.WriteLine("Numero Impar");

int j = 0;
while (j <= 20)
{
    if (j % 2 != 0)
    {
        Console.WriteLine(j);
    }
    j++;
}

int k;
int l;
for (k = 0; k < 10; k++)
{
    Console.WriteLine("Tabla de multiplicar: " + k);
    for (l = 1; l <= 10; l++)
    {
        int resultado = k + l;
        Console.WriteLine(k + " * " + l + " = " + "resultado");
    }
}

char char_pyramid = '*';

Console.WriteLine("Escribe las columnas que tendrá la piramide");

int cant_filas = Convert.ToInt32(Console.ReadLine());

for (int n=1; n<=cant_filas; n++)
{
    string espacios = new String(' ', cant_filas - n);
    string caracteres = new String(char_pyramid, 2 * n - 1);
    Console.Write(espacios);
    Console.Write(caracteres);
    Console.WriteLine();
}