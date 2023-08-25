using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities;

    public class ClienteProducto
    {
        public int IdProductoFk { get; set; }
        public Producto ? Producto { get; set; }
        public int IdClienteFk { get; set; }
        public Cliente ? Cliente { get; set; }
    }
