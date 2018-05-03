using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo_con_Crystal_Reports
{
    public class DetalleEntity
    {
        public DetalleEntity(string cantidad, string descripcion, string precio)
        {
            this.cantidad = cantidad;
            this.descripcion = descripcion;
            this.precio = precio;
        }

        public string cantidad { get; set; }
        public string descripcion { get; set; }
        public string precio { get; set; }

    }
}
