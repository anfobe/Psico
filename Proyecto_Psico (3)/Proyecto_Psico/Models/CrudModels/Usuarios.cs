using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto_Psico.Models.CrudModels
{
    public class Usuarios
    {

        public int Idusuario { get; set; }

        public int Idtipousuario { get; set; }

        public string Cedula { get; set; }

        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public string Ultimavez { get; set; }

        public string Correo { get; set; }


    }
}