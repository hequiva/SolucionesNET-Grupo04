﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioVenta
{
    public class DetalleVenta
    {
        [Key]
        public int IdDetVenta { get; set; }
        public int IdVenta { get; set; }
        public int IdProducto { get; set; }
    }
}
