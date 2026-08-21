namespace Semana012026B;

public struct Punto
{
    public double X { get; set; }
    public double Y { get; set; }

    public Punto(double x, double y)
    {
        X = x;
        Y = y;
    }

    public double DistanciaHacia(Punto otro)
    {
        double dx = otro.X - X;
        double dy = otro.Y - Y;
        return Math.Sqrt(dx * dx + dy * dy);
    }

    public override string ToString()
    {
        return $"({X}, {Y})";
    }
}
