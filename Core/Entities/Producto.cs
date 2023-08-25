using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities;

public class Producto
{
    public string ? CodeProducto { get; set; }
    public double ? Precio { get; set; }
    public int ? Cantidad {get; set; }
    public string ? Nombre { get; set; }
    public ICollection<ClienteProducto> ClienteProducto{get; set;} 

}
