using System.Runtime.Intrinsics.Arm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities;

    public class Cliente : BaseEntity
    {
        public string ? Nombre { get; set; }
        public string ? Apellido { get; set; }
        public string ? Cedula { get; set; }
        public int IdTipoClienteFk { get; set; }
        public TipoCliente ? TipoCliente { get; set; }
        public ICollection<ClienteProducto> ? ClienteProducto{get; set;} 
    }
