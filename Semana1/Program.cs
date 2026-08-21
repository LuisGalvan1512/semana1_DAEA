using Semana012026B;

Console.WriteLine("Tricampeón!");

// Menú de opciones
Console.WriteLine("\n=== Cálculos Geométricos ===");
Console.WriteLine("1. Triángulo");
Console.WriteLine("2. Rectángulo");
Console.Write("Seleccione opción (1 o 2): ");
string? opcion = Console.ReadLine();

if (opcion == "1")
{
    CalcularTriangulo();
}
else if (opcion == "2")
{
    CalcularRectangulo();
}
else
{
    Console.WriteLine("Opción inválida");
}

Console.Read();

void CalcularTriangulo()
{
    Console.WriteLine("\n--- Ingresa los Puntos del Triángulo ---\n");

    var p1 = LeerPunto(1);
    var p2 = LeerPunto(2);
    var p3 = LeerPunto(3);

    var triangulo = new Triangulo(p1, p2, p3);

    Console.WriteLine($"\n{triangulo}");
    Console.WriteLine($"Perímetro: {triangulo.Perimetro():F2}");
    Console.WriteLine($"Área: {triangulo.Area():F2}");
    Console.WriteLine($"Distancia P1-P2: {triangulo.Distancia(1, 2):F2}");
    Console.WriteLine($"Distancia P2-P3: {triangulo.Distancia(2, 3):F2}");
    Console.WriteLine($"Distancia P3-P1: {triangulo.Distancia(3, 1):F2}");
}

void CalcularRectangulo()
{
    Console.WriteLine("\n--- Ingresa los Puntos del Rectángulo ---\n");

    var p1 = LeerPunto(1);
    var p2 = LeerPunto(2);
    var p3 = LeerPunto(3);
    var p4 = LeerPunto(4);

    var rectangulo = new Rectangulo(p1, p2, p3, p4);

    Console.WriteLine($"\n{rectangulo}");
    Console.WriteLine($"Perímetro: {rectangulo.Perimetro():F2}");
    Console.WriteLine($"Área: {rectangulo.Area():F2}");
    Console.WriteLine($"Distancia P1-P2: {rectangulo.Distancia(1, 2):F2}");
    Console.WriteLine($"Distancia P2-P3: {rectangulo.Distancia(2, 3):F2}");
    Console.WriteLine($"Distancia P3-P4: {rectangulo.Distancia(3, 4):F2}");
    Console.WriteLine($"Distancia P4-P1: {rectangulo.Distancia(4, 1):F2}");
}

Punto LeerPunto(int numero)
{
    Console.Write($"Punto {numero} - X: ");
    double x = double.Parse(Console.ReadLine() ?? "0");
    Console.Write($"Punto {numero} - Y: ");
    double y = double.Parse(Console.ReadLine() ?? "0");
    return new Punto(x, y);
}
