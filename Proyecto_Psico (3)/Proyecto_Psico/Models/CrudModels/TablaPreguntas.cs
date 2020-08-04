using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Proyecto_Psico.Models.CrudModels
{
    public class TablaPreguntas
    {

        public int Idpregunta { get; set; }

        public int Idformulario { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Pregunta")]
        public string Pregunta { get; set; }

        public int Idrespuesta
        {
            get; set;
        }

    }
}