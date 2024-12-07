using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_cris2
{
    public class Proveedores
    {
        public int ProveedorId { get; set; }
        public string Nombre { get; set; }
        public string Contacto { get; set; }
        public string Telefono { get; set; }
        public string Ciudad { get; set; }
        public string Pais { get; set; }

        public ICollection<Productos> Productos { get; set; }
    }
}
