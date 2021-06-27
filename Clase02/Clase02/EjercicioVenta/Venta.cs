using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioVenta
{
    public class Venta
    {
        [Key]
        public int IdVenta { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int IdCliente { get; set; }

    }
}
