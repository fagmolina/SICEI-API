﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ponal.Dinae.Estic.Sicei.Entities.DTO
{
    public class UsuarioDTO
    {

        public decimal ID_USUARIO { get; set; }

        public decimal ID_TIPO_DOCUMENTO { get; set; }

        public string DOCUMENTO { get; set; }
        public string NOMBRES { get; set; }
        public string APELLIDOS { get; set; }

        public decimal ID_GRADO { get; set; }
        public decimal ID_UNIDAD { get; set; }
        public string EMAIL { get; set; }
        public string CONTRASENA { get; set; }

        public decimal ADMINISTRADOR { get; set; }

    }
}