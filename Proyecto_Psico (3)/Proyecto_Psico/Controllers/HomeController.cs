using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using Microsoft.Ajax.Utilities;
using Proyecto_Psico.Models;
using Proyecto_Psico.Models.CrudModels;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public static string cedulaid = cedulaid = "";

        // $$$$$$\                  $$\                                     $$$$$$$\                   $$$$$$\                                                    $$\                     
        //$$  __$$\                 $$ |                                    $$  __$$\                 $$  __$$\                                                   \__|                    
        //$$ /  \__| $$$$$$\   $$$$$$$ | $$$$$$\  $$$$$$$\   $$$$$$\        $$ |  $$ | $$$$$$\        $$ /  \__| $$$$$$\  $$$$$$$\   $$$$$$\   $$$$$$$\  $$$$$$$\ $$\  $$$$$$\  $$$$$$$\  
        //$$ |       \____$$\ $$  __$$ |$$  __$$\ $$  __$$\  \____$$\       $$ |  $$ |$$  __$$\       $$ |      $$  __$$\ $$  __$$\ $$  __$$\ $$  _____|$$  _____|$$ |$$  __$$\ $$  __$$\ 
        //$$ |       $$$$$$$ |$$ /  $$ |$$$$$$$$ |$$ |  $$ | $$$$$$$ |      $$ |  $$ |$$$$$$$$ |      $$ |      $$ /  $$ |$$ |  $$ |$$$$$$$$ |$$ /      $$ /      $$ |$$ /  $$ |$$ |  $$ |
        //$$ |  $$\ $$  __$$ |$$ |  $$ |$$   ____|$$ |  $$ |$$  __$$ |      $$ |  $$ |$$   ____|      $$ |  $$\ $$ |  $$ |$$ |  $$ |$$   ____|$$ |      $$ |      $$ |$$ |  $$ |$$ |  $$ |
        //\$$$$$$  |\$$$$$$$ |\$$$$$$$ |\$$$$$$$\ $$ |  $$ |\$$$$$$$ |      $$$$$$$  |\$$$$$$$\       \$$$$$$  |\$$$$$$  |$$ |  $$ |\$$$$$$$\ \$$$$$$$\ \$$$$$$$\ $$ |\$$$$$$  |$$ |  $$ |
        // \______/  \_______| \_______| \_______|\__|  \__| \_______|      \_______/  \_______|       \______/  \______/ \__|  \__| \_______| \_______| \_______|\__| \______/ \__|  \__|


        //                                                           █                                                                                                                
        //                                                           █
        //                                                           █
        //                                                   █       █       █    
        //                                                     █           █
        //                                                      █         █
        //                                                        █     █
        //                                                          █ █



        //██████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████Ö

        public static string cadena = "Data Source=DESKTOP-4KOFJOA;Initial Catalog=Psicologia;Integrated Security=True";

        //██████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████Ö


        public ActionResult Index(string mensaje)
        {
            {
                ViewBag.Message = mensaje;
                return View();
            }
        }
        public ActionResult Menu()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        public ActionResult MenuAdmin()
        {

            return View();
        }


        [HttpGet]
        public ActionResult Form1()
        {


            return View();
        }




        [HttpPost]
        public ActionResult Index(string Cedula, string Correo, string action, string Nombre, string Apellidos, string Cedula2, string Correo2)
        {
            try
            {
                if (string.IsNullOrEmpty(Cedula) || string.IsNullOrEmpty(Correo))
                {
                    return Index("Por favor rellene todos los campos");
                }

                if (action.Equals("Sign In"))
                {

                    DataSet ds1 = new DataSet();
                    SqlConnection con = new SqlConnection(cadena);
                    con.Open();
                    SqlCommand sql = new SqlCommand("SELECT Idtipousuario, Cedula, Correo FROM USUARIOS WHERE Cedula= '" + Cedula + "'", con);
                    SqlDataAdapter da = new SqlDataAdapter(sql);
                    da.Fill(ds1);
                    int contador = ds1.Tables[0].Rows.Count;
                    string dato = "";

                    foreach (DataRow row in ds1.Tables[0].Rows)
                    {
                        dato = ds1.Tables[0].Rows[0][0].ToString();

                    }

                    if (contador > 0)
                    {
                        if (dato == "2")
                        {
                            FormsAuthentication.SetAuthCookie(Cedula, true);
                            return RedirectToAction("MenuAdmin", "Perfil");
                        }
                        else
                        {
                            FormsAuthentication.SetAuthCookie(Cedula, true);
                            return RedirectToAction("Menu", "Perfil");
                        }
                    }
                    else
                    {
                        return Index("Su cuenta no existe, por favor registrese");
                    }
                }
                else
                {

                    if (string.IsNullOrEmpty(Apellidos) || string.IsNullOrEmpty(Correo2) || string.IsNullOrEmpty(Cedula2))
                    {
                        return Index("Por favor rellene todos los campos");
                    }
                    else
                    {
                        SqlConnection con = new SqlConnection(cadena);
                        con.Open();
                        SqlCommand sql = new SqlCommand("INSERT INTO USUARIOS (Idtipousuario, Cedula, Nombre, Apellido, Correo) VALUES (" + 1 + ", '" + Cedula2 + "' , '" + Nombre + "' , '" + Apellidos + "' , '" + Correo2 + "')", con);
                        sql.ExecuteNonQuery();
                        return Index("El usuario ha sido creado con éxito");
                    }




                }
            }
            catch (Exception)
            {
                return Index("La tarea falló exitosamente 🤗 Contacte al administrador web");

            }
        }


        [Authorize]
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index");
        }






    }
}