using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Proyecto_Psico.Models.CrudModels
{
    public class TablaFormulario
    {

        public int Idformulario
        {
            get; set;
        }

        [Required]
        [StringLength(50)]
        [Display(Name ="Nombre")]
        public string Nombre

        {

            get; set;

        }

    }
}