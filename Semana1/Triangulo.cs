namespace Semana012026B;

public class Triangulo
{
    public Punto Punto1 { get; set; }
    public Punto Punto2 { get; set; }
    public Punto Punto3 { get; set; }

    public Triangulo()
    {
        Punto1 = new Punto(0, 0);
        Punto2 = new Punto(0, 0);
        Punto3 = new Punto(0, 0);
    }

    public Triangulo(Punto p1, Punto p2, Punto p3)
    {
        Punto1 = p1;
        Punto2 = p2;
        Punto3 = p3;
    }

    public double Distancia(int indicePunto1, int indicePunto2)
    {
        Punto p1 = ObtenerPunto(indicePunto1);
        Punto p2 = ObtenerPunto(indicePunto2);
        return Operaciones.CalcularDistancia(p1, p2);
    }

    public double Perimetro()
    {
        return Operaciones.CalcularPerimetro(Punto1, Punto2, Punto3);
    }

    public double Area()
    {
        return Operaciones.CalcularArea(Punto1, Punto2, Punto3);
    }

    private Punto ObtenerPunto(int indice)
    {
        return indice switch
        {
            1 => Punto1,
            2 => Punto2,
            3 => Punto3,
            _ => throw new ArgumentException("El índice debe ser 1, 2 o 3")
        };
    }

    public override string ToString()
    {
        return $"Triángulo: P1{Punto1}, P2{Punto2}, P3{Punto3}";
    }
}
