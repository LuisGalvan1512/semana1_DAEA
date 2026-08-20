// See https://aka.ms/new-console-template for more information

using Semana012026B;

//for (int i = 0; i < 20; i++)
//{
//	if (i%2==0)
//	{
//        Console.WriteLine("¡Universitario Campeón!");
//    }
//    else
//    {
//        Console.WriteLine("¡Alianza en Segunda!");
//    }


//}


Producto producto = new Producto();
producto.Nombre = "Laptop";
producto.Precio = 5000;


Producto producto1 = new Producto{
    Nombre = "Celular",
    Precio = 2000
};

Console.WriteLine(producto.calcularPrecioFinal());
Console.WriteLine(producto1.calcularPrecioFinal());

producto.asignarNombreCorto();
producto1.asignarNombreCorto();

Console.WriteLine(producto.nombreCorto);
Console.WriteLine(producto1.nombreCorto);



Console.WriteLine("Tricampeón!");
Console.Read();
