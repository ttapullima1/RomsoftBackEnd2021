﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Romsoft.GESTIONCLINICA.DTO.TABLAS.Prueba
{
    public class Cabecera_Prueba
    {
        public string Descripcion { get; set; }
        public int Estado { get; set; }

        public List<Detalle_Prueba> Detalle_Prueba { get; set; }
    }
}
