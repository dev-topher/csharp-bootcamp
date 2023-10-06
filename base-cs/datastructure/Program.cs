Coords misCoordenadas = new Coords(3, 10);
Console.WriteLine("eje x: " + misCoordenadas.X);
Console.WriteLine("eje y: " + misCoordenadas.Y);

public struct Coords
{
    public Coords (double x, double y)
    {
        X = x;
        Y = y;
    }
    public double X { get; }
    public double Y { get; }

    public override string ToString()=> $"({X}, {Y})";
}