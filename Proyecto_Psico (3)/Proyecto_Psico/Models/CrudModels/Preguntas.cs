using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto_Psico.Models.CrudModels
{
    public class Preguntas
    {

        public int Idpregunta { get; set; }

        public int Idformulario { get; set; }

        public string Pregunta { get; set; }

        public int Idrespuesta
        {
            get;set;
        }


    }
}