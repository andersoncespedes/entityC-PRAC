using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities;

public class TipoCliente : BaseEntity
{
        public string ? Descripcion {get; set;}
        public ICollection<Cliente> ? Clientes {get; set;}
}
