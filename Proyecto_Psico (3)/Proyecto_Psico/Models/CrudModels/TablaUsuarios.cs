using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Configuration;
using System.Linq;
using System.Web;

namespace Proyecto_Psico.Models.CrudModels
{
    public class TablaUsuarios
    {

        public int Idusuario { get; set; }

        public int Idtipousuario { get; set; }

        public string Cedula { get; set; }


        [Required]
        [StringLength(50)]
        [Display(Name = "Nombre")]
        public string Nombre { get; set; }


        [Required]
        [StringLength(50)]
        [Display(Name = "Apellido")]
        public string Apellido { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Ultima vez")]
        public string Ultimavez { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "Correo")]
        public string Correo { get; set; }

    }
}