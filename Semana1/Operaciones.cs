namespace Semana012026B;

public static class Operaciones
{
    public static double CalcularDistancia(Punto p1, Punto p2)
    {
        double dx = p2.X - p1.X;
        double dy = p2.Y - p1.Y;
        return Math.Sqrt(dx * dx + dy * dy);
    }

    public static double CalcularPerimetro(params Punto[] puntos)
    {
        if (puntos.Length < 2)
            return 0;

        double perimetro = 0;
        for (int i = 0; i < puntos.Length; i++)
        {
            int siguiente = (i + 1) % puntos.Length;
            perimetro += CalcularDistancia(puntos[i], puntos[siguiente]);
        }
        return perimetro;
    }

    public static double CalcularArea(params Punto[] puntos)
    {
        if (puntos.Length < 3)
            return 0;

        double suma = 0;
        for (int i = 0; i < puntos.Length; i++)
        {
            int siguiente = (i + 1) % puntos.Length;
            suma += puntos[i].X * puntos[siguiente].Y;
            suma -= puntos[siguiente].X * puntos[i].Y;
        }

        return Math.Abs(suma) / 2.0;
    }
}
