﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioVenta
{
    public class Producto
    {
        [Key]
        public int IdProducto { get; set; }
        public string NombreProducto { get; set; }
    }
}
