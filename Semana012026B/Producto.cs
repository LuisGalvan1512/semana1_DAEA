using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana012026B
{
    public class Producto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string nombreCorto { get; set; }

        public int Precio { get; set; }

        public double calcularPrecioFinal()
        {
            double precioFinal = Precio * 1.18;
            return precioFinal;
        }

        public void asignarNombreCorto()
        {
            if (Nombre.Length > 4)
            {
                nombreCorto = Nombre.Substring(0, 4);
            }
            else
            {
                nombreCorto = Nombre;
            }

        }
    }
}
