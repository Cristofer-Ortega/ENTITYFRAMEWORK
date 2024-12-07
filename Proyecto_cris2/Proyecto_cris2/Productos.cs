using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_cris2
{
    public class Productos
    {
        public int ProductoId { get; set; }
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public int ProveedorId { get; set; }

        public Proveedores Proveedor { get; set; }
    }
}
