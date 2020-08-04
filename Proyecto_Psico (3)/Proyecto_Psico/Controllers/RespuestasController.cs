using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Proyecto_Psico.Models.CrudModels;
using Proyecto_Psico.Models.Entities;
using Proyecto_Psico.Models.FormulariosModels;

namespace Proyecto_Psico.Controllers
{
    public class RespuestasController : Controller
    {
        // GET: Respuestas
        public ActionResult Respuestas()
        {
            return View();
        }



        public ActionResult Usuarios_respuestas(int ID)
        {
            Resultados model = new Resultados();
            using (PsicologiaEntities2 DB = new PsicologiaEntities2())
            {
                var oTabla = DB.RESPUESTAS.Find(ID);
                oTabla.Idusuario = model.Idusuario;
                oTabla.Respuesta = model.respuesta;


            }

            return View(model);

            
        }




        public ActionResult Usuarios()
        {

            List<Usuarios> lista;
            using (PsicologiaEntities2 DB = new PsicologiaEntities2())
            {
                lista = (from d in DB.USUARIOS
                         select new Usuarios
                         {
                             Idusuario = d.Idusuario,
                             Idtipousuario = d.Idtipousuario,
                             Cedula = d.Cedula,
                             Nombre = d.Nombre,
                             Apellido = d.Apellido,
                             Ultimavez = d.Ultimavez,
                             Correo = d.Correo

                         }).ToList();
            }


            return View(lista);

            
        }




    }
}