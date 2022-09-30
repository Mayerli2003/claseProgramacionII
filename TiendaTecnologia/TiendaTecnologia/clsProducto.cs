using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaTecnologia
{
    internal class clsProducto
    {
        public int idProducto { get; set; }
        public  string nomProducto { get; set; }
        public string descripcion { get; set; }
        public string categoria { get; set; }
        public int stock { get; set; }
        public double precioCompra { get; set; }
        public double precioVenta { get; set; }
    }
}
