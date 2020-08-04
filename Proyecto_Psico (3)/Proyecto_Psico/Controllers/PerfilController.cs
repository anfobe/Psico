using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Proyecto_Psico.Models;
using Proyecto_Psico.Models.CrudModels;
using System.Data;
using System.Data.SqlClient;

namespace WebApplication1.Controllers
{

    [Authorize]
    public class PerfilController : Controller
    {


        public static List<string> x22 = new List<string>();
        public static List<string> x221 = new List<string>();
        public static List<string> x222= new List<string>();
        public static List<string> x223= new List<string>();








        public static List<string> x23 = new List<string>();
        public static List<string> x24 = new List<string>();
        public static List<string> x25 = new List<string>();
        public static List<string> x26 = new List<string>();
        public static List<string> x27 = new List<string>();




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

        //██████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████

        public static string cadena = "Data Source=DESKTOP-4KOFJOA;Initial Catalog=Psicologia;Integrated Security=True";

        //██████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████

        // GET: Perfil
        private string conexion;

        public ActionResult Menu()
        {
            return View();
        }

        public ActionResult MenuAdmin()
        {
            return View();
        }

        public ActionResult Form1()
        {
            return View();
        }



        //CODIGO DE FORMULARIOS 1

        [HttpGet]
        public ActionResult form1()
        {
            DataSet tabla1 = new DataSet();
            SqlConnection conn1 = new SqlConnection(cadena);
            conn1.Open();
            SqlCommand coma1 = new SqlCommand("SELECT IDPREGUNTA FROM PREGUNTAS WHERE IDFORMULARIO = '1'", conn1);
            SqlDataAdapter l1 = new SqlDataAdapter(coma1);
            l1.Fill(tabla1);

            //public static List<string> x22 = new List<string>();


            for (int i = 0; i < tabla1.Tables[0].Rows.Count; i++)
            {
                x24.Add(tabla1.Tables[0].Rows[i][0].ToString());

            }

            return View();

        }



        [HttpPost]
        public ActionResult Form1(string Nombre,
         string FechaNacimiento,
         string Edad,
         string Sexo,
         string Provincia,
         string Canton,
         string Hijos,
         string CuantosH,
         string Habitantes,
         string NivelEdu,
         string EstadoCivil,
         string HorasNoAcad,
         string CuatrimestreM,
         string Trabaja,
         string HorasLaborales)
        {
            string cedulausuario = HomeController.cedulaid;

            //preguntar a la tabla de usuarios el idusario para esta cedula
            DataSet ds2 = new DataSet();
            SqlConnection con = new SqlConnection(cadena);
            con.Open();
            SqlCommand sql = new SqlCommand("SELECT Idusuario FROM USUARIOS WHERE Cedula= '" + cedulausuario + "'", con);
            SqlDataAdapter da = new SqlDataAdapter(sql);
            sql.ExecuteNonQuery();
            da.Fill(ds2);
            con.Close();
            string identificador_usuario = "";


            foreach (DataRow row in ds2.Tables[0].Rows)
            {
                identificador_usuario = ds2.Tables[0].Rows[0][0].ToString();
            }
            x22.Add(Nombre);
            x22.Add(FechaNacimiento);
            x22.Add(Edad);
            x22.Add(Sexo);
            x22.Add(Provincia);
            x22.Add(Canton);
            x22.Add(Hijos);
            x22.Add(CuantosH);
            x22.Add(Habitantes);
            x22.Add(NivelEdu);
            x22.Add(EstadoCivil);
            x22.Add(HorasNoAcad);
            x22.Add(CuatrimestreM);
            x22.Add(Trabaja);
            x22.Add(HorasLaborales);

            {
                ////queryes para llenar la tabla de respuestas
                //DataSet ds3 = new DataSet();
                //SqlConnection con1 = new SqlConnection(cadena);
                //con1.Open();
                //SqlCommand sql1 = new SqlCommand("INSERT INTO RESPUESTAS (Idpregunta, Idusuario, Respuesta) VALUES( '1', '" + identificador_usuario + "', '" + Nombre + "')", con1);
                //sql1.ExecuteNonQuery();
                //con1.Close();

                //DataSet ds4 = new DataSet();
                //SqlConnection con2 = new SqlConnection("Data Source=DESKTOP-4KOFJOA;Initial Catalog=Psicologia;Integrated Security=True");
                //con2.Open();
                //SqlCommand sql2 = new SqlCommand("INSERT INTO RESPUESTAS (Idpregunta, Idusuario, Respuesta) VALUES( '2', '" + identificador_usuario + "', '" + FechaNacimiento + "')", con2);
                //sql2.ExecuteNonQuery();
                //con2.Close();

                //DataSet ds5 = new DataSet();
                //SqlConnection con3 = new SqlConnection("Data Source=DESKTOP-4KOFJOA;Initial Catalog=Psicologia;Integrated Security=True");
                //con3.Open();
                //SqlCommand sql3 = new SqlCommand("INSERT INTO RESPUESTAS (Idpregunta, Idusuario, Respuesta) VALUES( '3', '" + identificador_usuario + "', '" + Edad + "')", con3);
                //sql3.ExecuteNonQuery();
                //con3.Close();


                //DataSet ds6 = new DataSet();
                //SqlConnection con4 = new SqlConnection("Data Source=DESKTOP-4KOFJOA;Initial Catalog=Psicologia;Integrated Security=True");
                //con4.Open();
                //SqlCommand sql4 = new SqlCommand("INSERT INTO RESPUESTAS (Idpregunta, Idusuario, Respuesta) VALUES( '4', '" + identificador_usuario + "', '" + Sexo + "')", con4);
                //sql4.ExecuteNonQuery();
                //con4.Close();


                //DataSet ds7 = new DataSet();
                //SqlConnection con5 = new SqlConnection("Data Source=DESKTOP-4KOFJOA;Initial Catalog=Psicologia;Integrated Security=True");
                //con5.Open();
                //SqlCommand sql5 = new SqlCommand("INSERT INTO RESPUESTAS (Idpregunta, Idusuario, Respuesta) VALUES( '5', '" + identificador_usuario + "', '" + Provincia + "')", con5);
                //sql5.ExecuteNonQuery();
                //con5.Close();


                //DataSet ds8 = new DataSet();
                //SqlConnection con6 = new SqlConnection("Data Source=DESKTOP-4KOFJOA;Initial Catalog=Psicologia;Integrated Security=True");
                //con6.Open();
                //SqlCommand sql6 = new SqlCommand("INSERT INTO RESPUESTAS (Idpregunta, Idusuario, Respuesta) VALUES( '6', '" + identificador_usuario + "', '" + Canton + "')", con6);
                //sql6.ExecuteNonQuery();
                //con6.Close();


                //DataSet ds9 = new DataSet();
                //SqlConnection con7 = new SqlConnection("Data Source=DESKTOP-4KOFJOA;Initial Catalog=Psicologia;Integrated Security=True");
                //con7.Open();
                //SqlCommand sql7 = new SqlCommand("INSERT INTO RESPUESTAS (Idpregunta, Idusuario, Respuesta) VALUES( '7', '" + identificador_usuario + "', '" + Hijos + "')", con7);
                //sql7.ExecuteNonQuery();
                //con7.Close();


                //DataSet ds10 = new DataSet();
                //SqlConnection con8 = new SqlConnection("Data Source=DESKTOP-4KOFJOA;Initial Catalog=Psicologia;Integrated Security=True");
                //con8.Open();
                //SqlCommand sql8 = new SqlCommand("INSERT INTO RESPUESTAS (Idpregunta, Idusuario, Respuesta) VALUES( '8', '" + identificador_usuario + "', '" + CuantosH + "')", con8);
                //sql8.ExecuteNonQuery();
                //con8.Close();


                //DataSet ds11 = new DataSet();
                //SqlConnection con9 = new SqlConnection("Data Source=DESKTOP-4KOFJOA;Initial Catalog=Psicologia;Integrated Security=True");
                //con9.Open();
                //SqlCommand sql9 = new SqlCommand("INSERT INTO RESPUESTAS (Idpregunta, Idusuario, Respuesta) VALUES( '9', '" + identificador_usuario + "', '" + Habitantes + "')", con9);
                //sql9.ExecuteNonQuery();
                //con9.Close();


                //DataSet ds12 = new DataSet();
                //SqlConnection con10 = new SqlConnection("Data Source=DESKTOP-4KOFJOA;Initial Catalog=Psicologia;Integrated Security=True");
                //con10.Open();
                //SqlCommand sql10 = new SqlCommand("INSERT INTO RESPUESTAS (Idpregunta, Idusuario, Respuesta) VALUES( '10', '" + identificador_usuario + "', '" + NivelEdu + "')", con10);
                //sql10.ExecuteNonQuery();
                //con10.Close();


                //DataSet ds13 = new DataSet();
                //SqlConnection con11 = new SqlConnection("Data Source=DESKTOP-4KOFJOA;Initial Catalog=Psicologia;Integrated Security=True");
                //con11.Open();
                //SqlCommand sql11 = new SqlCommand("INSERT INTO RESPUESTAS (Idpregunta, Idusuario, Respuesta) VALUES( '11', '" + identificador_usuario + "', '" + EstadoCivil + "')", con11);
                //sql11.ExecuteNonQuery();
                //con11.Close();


                //DataSet ds14 = new DataSet();
                //SqlConnection con12 = new SqlConnection("Data Source=DESKTOP-4KOFJOA;Initial Catalog=Psicologia;Integrated Security=True");
                //con12.Open();
                //SqlCommand sql12 = new SqlCommand("INSERT INTO RESPUESTAS (Idpregunta, Idusuario, Respuesta) VALUES( '12', '" + identificador_usuario + "', '" + HorasNoAcad + "')", con12);
                //sql12.ExecuteNonQuery();
                //con12.Close();


                //DataSet ds15 = new DataSet();
                //SqlConnection con13 = new SqlConnection("Data Source=DESKTOP-4KOFJOA;Initial Catalog=Psicologia;Integrated Security=True");
                //con13.Open();
                //SqlCommand sql13 = new SqlCommand("INSERT INTO RESPUESTAS (Idpregunta, Idusuario, Respuesta) VALUES( '13', '" + identificador_usuario + "', '" + CuatrimestreM + "')", con13);
                //sql13.ExecuteNonQuery();
                //con13.Close();


                //DataSet ds16 = new DataSet();
                //SqlConnection con14 = new SqlConnection("Data Source=DESKTOP-4KOFJOA;Initial Catalog=Psicologia;Integrated Security=True");
                //con14.Open();
                //SqlCommand sql14 = new SqlCommand("INSERT INTO RESPUESTAS (Idpregunta, Idusuario, Respuesta) VALUES( '14', '" + identificador_usuario + "', '" + Trabaja + "')", con14);
                //sql14.ExecuteNonQuery();
                //con14.Close();



                //DataSet ds18 = new DataSet();
                //SqlConnection con15 = new SqlConnection("Data Source=DESKTOP-4KOFJOA;Initial Catalog=Psicologia;Integrated Security=True");
                //con15.Open();
                //SqlCommand sql15 = new SqlCommand("INSERT INTO RESPUESTAS (Idpregunta, Idusuario, Respuesta) VALUES( '15', '" + identificador_usuario + "', '" + HorasLaborales + "')", con15);
                //sql15.ExecuteNonQuery();
                //con15.Close();
            }

            for (int i = 0; i < 15; i++)
            {
                //
                DataSet sspm1 = new DataSet();
                SqlConnection bmw1 = new SqlConnection(cadena);
                bmw1.Open();
                SqlCommand sec1 = new SqlCommand("INSERT INTO RESPUESTAS (Idpregunta, Idusuario, Respuesta) VALUES( '" + x24[i] + "', '" + identificador_usuario + "', '" + x22[i] + "')", bmw1);
                sec1.ExecuteNonQuery();
                bmw1.Close();
                //
            }

            return Redirect("form2");

        }

        //FORMULARIO 2
        [HttpGet]
        public ActionResult form2()
        {


            DataSet tabla1 = new DataSet();
            SqlConnection conn1 = new SqlConnection(cadena);
            conn1.Open();
            SqlCommand coma1 = new SqlCommand("SELECT IDPREGUNTA FROM PREGUNTAS WHERE IDFORMULARIO = '3'", conn1);
            SqlDataAdapter l1 = new SqlDataAdapter(coma1);
            l1.Fill(tabla1);

            //public static List<string> x22 = new List<string>();


            for (int i = 0; i < tabla1.Tables[0].Rows.Count; i++)
            {
                x25.Add(tabla1.Tables[0].Rows[i][0].ToString());

            }

            return View();

        }

        //FORMULARIO 2
        [HttpPost]
        public ActionResult form2(string v1,
         string v2,
         string v3,
         string v4,
         string v5,
         string v6,
         string v7,
         string v8,
         string v9,
         string v10,
         string v11,
         string v12,
         string v13,
         string v14,
         string v15,
         string v16,
         string v17,
         string v18,
         string v19,
         string v20,
         string v21,
         string v22,
         string v23,
         string v24,
         string v25,
         string v26,
         string v27,
         string v28,
         string v29,
         string v30,
         string v31,
         string v32,
         string v33,
         string v34,
         string v35,
         string v36,
         string v37,
         string v38,
         string v39,
         string v40,
         string v41,
         string v42,
         string v43,
         string v44,
         string v45,
         string v46,
         string v47,
         string v48,
         string v49,
         string v50,
         string v51,
         string v52,
         string v53,
         string v54,
         string v55,
         string v56,
         string v57,
         string v58,
         string v59,
         string v60)
        {
            string cedulausuario = HomeController.cedulaid;

            //preguntar a la tabla de usuarios el idusario para esta cedula
            DataSet ds2 = new DataSet();
            SqlConnection con = new SqlConnection(cadena);
            con.Open();
            SqlCommand sql = new SqlCommand("SELECT Idusuario FROM USUARIOS WHERE Cedula= '" + cedulausuario + "'", con);
            SqlDataAdapter da = new SqlDataAdapter(sql);
            sql.ExecuteNonQuery();
            da.Fill(ds2);
            con.Close();
            string identificador_usuario = "";


            foreach (DataRow row in ds2.Tables[0].Rows)
            {
                identificador_usuario = ds2.Tables[0].Rows[0][0].ToString();
            }



            x221.Add(v1);
            x221.Add(v2);
            x221.Add(v3);
            x221.Add(v4);
            x221.Add(v5);
            x221.Add(v6);
            x221.Add(v7);
            x221.Add(v8);
            x221.Add(v9);
            x221.Add(v10);
            x221.Add(v11);
            x221.Add(v12);
            x221.Add(v13);
            x221.Add(v14);
            x221.Add(v15);
            x221.Add(v16);
            x221.Add(v17);
            x221.Add(v18);
            x221.Add(v19);
            x221.Add(v20);
            x221.Add(v21);
            x221.Add(v22);
            x221.Add(v23);
            x221.Add(v24);
            x221.Add(v25);
            x221.Add(v26);
            x221.Add(v27);
            x221.Add(v28);
            x221.Add(v29);
            x221.Add(v30);
            x221.Add(v31);
            x221.Add(v32);
            x221.Add(v33);
            x221.Add(v34);
            x221.Add(v35);
            x221.Add(v36);
            x221.Add(v37);
            x221.Add(v38);
            x221.Add(v39);
            x221.Add(v40);
            x221.Add(v41);
            x221.Add(v42);
            x221.Add(v43);
            x221.Add(v44);
            x221.Add(v45);
            x221.Add(v46);
            x221.Add(v47);
            x221.Add(v48);
            x221.Add(v49);
            x221.Add(v50);
            x221.Add(v51);
            x221.Add(v52);
            x221.Add(v53);
            x221.Add(v54);
            x221.Add(v55);
            x221.Add(v56);
            x221.Add(v57);
            x221.Add(v58);
            x221.Add(v59);
            x221.Add(v60);

            for (int i = 0; i < 60; i++)
            {
                //
                DataSet sspm1 = new DataSet();
                SqlConnection bmw1 = new SqlConnection(cadena);
                bmw1.Open();
                SqlCommand sec1 = new SqlCommand("INSERT INTO RESPUESTAS (Idpregunta, Idusuario, Respuesta) VALUES( '" + x25[i] + "', '" + identificador_usuario + "', '" + x221[i] + "')", bmw1);
                sec1.ExecuteNonQuery();
                bmw1.Close();
                //
            }
               

            return Redirect("form3");

        }


        //FORMULARIO 3
        [HttpGet]
        public ActionResult Form3()
        {
            

            DataSet tabla2 = new DataSet();
            SqlConnection conn2 = new SqlConnection(cadena);
            conn2.Open();
            SqlCommand coma2 = new SqlCommand("SELECT IDPREGUNTA FROM PREGUNTAS WHERE IDFORMULARIO = '4'", conn2);
            SqlDataAdapter l1 = new SqlDataAdapter(coma2);
            l1.Fill(tabla2);

            //public static List<string> x22 = new List<string>();


            for (int i = 0; i < tabla2.Tables[0].Rows.Count; i++)
            {
                x26.Add(tabla2.Tables[0].Rows[i][0].ToString());

            }

            return View();

        }

        [HttpPost]
        public ActionResult Form3(string b1,
         string b2,
         string b3,
         string b4,
         string b5,
         string b6,
         string b7,
         string b8,
         string b9,
         string b10,
         string b11,
         string b12,
         string b13,
         string b14,
         string b15,
         string b16,
         string b17,
         string b18,
         string b19,
         string b20,
         string b21,
         string b22,
         string b23,
         string b24,
         string b25,
         string b26,
         string b27,
         string b28,
         string b29,
         string b30,
         string b31,
         string b32,
         string b33,
         string b34,
         string b35,
         string b36,
         string b37,
         string b38,
         string b39,
         string b40,
         string b41,
         string b42,
         string b43,
         string b44,
         string b45,
         string b46,
         string b47,
         string b48,
         string b49,
         string b50,
         string b51,
         string b52,
         string b53,
         string b54)

        {
            string cedulausuario = HomeController.cedulaid;

            //preguntar a la tabla de usuarios el idusario para esta cedula
            DataSet ds2 = new DataSet();
            SqlConnection con = new SqlConnection(cadena);
            con.Open();
            SqlCommand sql = new SqlCommand("SELECT Idusuario FROM USUARIOS WHERE Cedula= '" + cedulausuario + "'", con);
            SqlDataAdapter da = new SqlDataAdapter(sql);
            sql.ExecuteNonQuery();
            da.Fill(ds2);
            con.Close();
            string identificador_usuario = "";


            foreach (DataRow row in ds2.Tables[0].Rows)
            {
                identificador_usuario = ds2.Tables[0].Rows[0][0].ToString();
            }



            x222.Add(b1);
            x222.Add(b2);
            x222.Add(b3);
            x222.Add(b4);
            x222.Add(b5);
            x222.Add(b6);
            x222.Add(b7);
            x222.Add(b8);
            x222.Add(b9);
            x222.Add(b10);

            x222.Add(b11);
            x222.Add(b12);
            x222.Add(b13);
            x222.Add(b14);
            x222.Add(b15);
            x222.Add(b16);
            x222.Add(b17);
            x222.Add(b18);
            x222.Add(b19);
            x222.Add(b20);

            x222.Add(b21);
            x222.Add(b22);
            x222.Add(b23);
            x222.Add(b24);
            x222.Add(b25);
            x222.Add(b26);
            x222.Add(b27);
            x222.Add(b28);
            x222.Add(b29);
            x222.Add(b30);

            x222.Add(b31);
            x222.Add(b32);
            x222.Add(b33);
            x222.Add(b34);
            x222.Add(b35);
            x222.Add(b36);
            x222.Add(b37);
            x222.Add(b38);
            x222.Add(b39);
            x222.Add(b40);

            x222.Add(b41);
            x222.Add(b42);
            x222.Add(b43);
            x222.Add(b44);
            x222.Add(b45);
            x222.Add(b46);
            x222.Add(b47);
            x222.Add(b48);
            x222.Add(b49);
            x222.Add(b50);

            x222.Add(b51);
            x222.Add(b52);
            x222.Add(b53);
            x222.Add(b54);




            for (int i = 0; i < 54; i++)
            {
                //
                DataSet sspm1 = new DataSet();
                SqlConnection bmw1 = new SqlConnection(cadena);
                bmw1.Open();
                SqlCommand sec1 = new SqlCommand("INSERT INTO RESPUESTAS (Idpregunta, Idusuario, Respuesta) VALUES( '" + x26[i] + "', '" + identificador_usuario + "', '" + x222[i] + "')", bmw1);
                sec1.ExecuteNonQuery();
                bmw1.Close();
                //
            }

            return Redirect("form4");

        }


        //FORMULARIO 4
        [HttpGet]
        public ActionResult Form4()
        {


            DataSet tabla2 = new DataSet();
            SqlConnection conn2 = new SqlConnection(cadena);
            conn2.Open();
            SqlCommand coma2 = new SqlCommand("SELECT IDPREGUNTA FROM PREGUNTAS WHERE IDFORMULARIO = '2'", conn2);
            SqlDataAdapter l1 = new SqlDataAdapter(coma2);
            l1.Fill(tabla2);

            //public static List<string> x22 = new List<string>();


            for (int i = 0; i < tabla2.Tables[0].Rows.Count; i++)
            {
                x27.Add(tabla2.Tables[0].Rows[i][0].ToString());

            }

            return View();

        }

        [HttpPost]
        public ActionResult Form4( string u1, 
         string u2 ,
         string u3 ,
         string u4 ,
         string u5 ,
         string u6 ,
         string u7 ,
         string u8 ,
         string u9 ,
         string u10 ,
         string u11 ,
         string u12 ,
         string u13 ,
         string u14 ,
         string u15 ,
         string u16 ,
         string u17 ,
         string u18 ,
         string u19 ,
         string u20 ,
         string u21 ,
         string u22 ,
         string u23 ,
         string u24 ,
         string u25 ,
         string u26 ,
         string u27 ,
         string u28 ,
         string u29 ,
         string u30 )

        {
            string cedulausuario = HomeController.cedulaid;

            //preguntar a la tabla de usuarios el idusario para esta cedula
            DataSet ds2 = new DataSet();
            SqlConnection con = new SqlConnection(cadena);
            con.Open();
            SqlCommand sql = new SqlCommand("SELECT Idusuario FROM USUARIOS WHERE Cedula= '" + cedulausuario + "'", con);
            SqlDataAdapter da = new SqlDataAdapter(sql);
            sql.ExecuteNonQuery();
            da.Fill(ds2);
            con.Close();
            string identificador_usuario = "";


            foreach (DataRow row in ds2.Tables[0].Rows)
            {
                identificador_usuario = ds2.Tables[0].Rows[0][0].ToString();
            }



            x223.Add(u1);
            x223.Add(u2);
            x223.Add(u3);
            x223.Add(u4);
            x223.Add(u5);
            x223.Add(u6);
            x223.Add(u7);
            x223.Add(u8);
            x223.Add(u9);
            x223.Add(u10);

            x223.Add(u11);
            x223.Add(u12);
            x223.Add(u13);
            x223.Add(u14);
            x223.Add(u15);
            x223.Add(u16);
            x223.Add(u17);
            x223.Add(u18);
            x223.Add(u19);
            x223.Add(u20);

            x223.Add(u21);
            x223.Add(u22);
            x223.Add(u23);
            x223.Add(u24);
            x223.Add(u25);
            x223.Add(u26);
            x223.Add(u27);
            x223.Add(u28);
            x223.Add(u29);
            //x223.Add(u30);

            for (int i = 0; i < 29; i++)
            {
                //
                DataSet sspm1 = new DataSet();
                SqlConnection bmw1 = new SqlConnection(cadena);
                bmw1.Open();
                SqlCommand sec1 = new SqlCommand("INSERT INTO RESPUESTAS (Idpregunta, Idusuario, Respuesta) VALUES( '" + x27[i] + "', '" + identificador_usuario + "', '" + x223[i] + "')", bmw1);
                sec1.ExecuteNonQuery();
                bmw1.Close();
                //
            }

            return Redirect("Menu");

        }


































        //---CRUD---

        public ActionResult CRUD() //Vista a la página CRUD
        {

            return View();

        }

        public ActionResult Formulario() //Página de Formularios
        {
            List<Formulario> lista;
            using (PsicologiaEntities1 DB = new PsicologiaEntities1())
            {
                lista = (from d in DB.FORMULARIOS
                         select new Formulario
                         {
                             Idformulario = d.Idformulario,
                             Nombre = d.Nombre

                         }).ToList();
            }


            return View(lista);
        }

        public ActionResult nuevoFormulario()
        {
            return View();
        }

        [HttpPost]
        public ActionResult nuevoFormulario(TablaFormulario model)
        {

            try
            {
                if (ModelState.IsValid)
                {

                    using (PsicologiaEntities1 DB = new PsicologiaEntities1())
                    {
                        var oTabla = new FORMULARIO();
                        oTabla.Idformulario = model.Idformulario;
                        oTabla.Nombre = model.Nombre;

                        DB.FORMULARIOS.Add(oTabla);
                        DB.SaveChanges();
                    }

                    return Redirect("~/Perfil/Formulario");

                }

                return View(model);

            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }

        }

        public ActionResult EditarFormulario(int ID)
        {
            TablaFormulario model = new TablaFormulario();
            using (PsicologiaEntities1 DB = new PsicologiaEntities1())
            {
                var oTabla = DB.FORMULARIOS.Find(ID);
                model.Idformulario = oTabla.Idformulario;
                model.Nombre = oTabla.Nombre;

            }

            return View(model);
        }

        [HttpPost]
        public ActionResult EditarFormulario(TablaFormulario model)
        {

            try
            {
                if (ModelState.IsValid)
                {

                    using (PsicologiaEntities1 DB = new PsicologiaEntities1())
                    {
                        var oTabla = DB.FORMULARIOS.Find(model.Idformulario);
                        oTabla.Idformulario = model.Idformulario;
                        oTabla.Nombre = model.Nombre;

                        DB.Entry(oTabla).State = System.Data.Entity.EntityState.Modified;
                        DB.SaveChanges();
                    }

                    return Redirect("~/Perfil/Formulario");

                }

                return View(model);

            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }

        }

        [HttpGet]
        public ActionResult EliminarFormulario(int ID)
        {
            using (PsicologiaEntities1 DB = new PsicologiaEntities1())
            {
                var oTabla = DB.FORMULARIOS.Find(ID);
                DB.FORMULARIOS.Remove(oTabla);
                DB.SaveChanges();


            }

            return Redirect("~/Perfil/Formulario");
        }

        public ActionResult Preguntas() //Validación de preguntas
        {
            List<Preguntas> lista;
            using (PsicologiaEntities1 DB = new PsicologiaEntities1())
            {
                lista = (from d in DB.PREGUNTAS
                         select new Preguntas
                         {
                             Idpregunta = d.Idpregunta,
                             Idformulario = d.Idformulario,
                             Pregunta = d.Pregunta1,
                             Idrespuesta = (int)d.Idrespuesta

                         }).ToList();
            }


            return View(lista);
        }

        public ActionResult nuevoPreguntas()
        {
            return View();
        }

        [HttpPost]
        public ActionResult nuevoPreguntas(TablaPreguntas model)
        {

            try
            {
                if (ModelState.IsValid)
                {

                    using (PsicologiaEntities1 DB = new PsicologiaEntities1())
                    {
                        var oTabla = new PREGUNTA();
                        oTabla.Idpregunta = model.Idpregunta;
                        oTabla.Idformulario = model.Idformulario;
                        oTabla.Pregunta1 = model.Pregunta;
                        oTabla.Idrespuesta = model.Idrespuesta;


                        DB.PREGUNTAS.Add(oTabla);
                        DB.SaveChanges();
                    }

                    return Redirect("~/Perfil/Preguntas");

                }

                return View(model);

            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }

        }

        public ActionResult EditarPreguntas(int ID)
        {
            TablaPreguntas model = new TablaPreguntas();
            using (PsicologiaEntities1 DB = new PsicologiaEntities1())
            {
                var oTabla = DB.PREGUNTAS.Find(ID);
                oTabla.Idpregunta = model.Idpregunta;
                oTabla.Idformulario = model.Idformulario;
                oTabla.Pregunta1 = model.Pregunta;
                oTabla.Idrespuesta = model.Idrespuesta;

            }

            return View(model);
        }

        [HttpPost]
        public ActionResult EditarPreguntas(TablaPreguntas model)
        {

            try
            {
                if (ModelState.IsValid)
                {

                    using (PsicologiaEntities1 DB = new PsicologiaEntities1())
                    {
                        var oTabla = DB.PREGUNTAS.Find(model.Idpregunta);
                        oTabla.Idpregunta = model.Idpregunta;
                        oTabla.Idformulario = model.Idformulario;
                        oTabla.Pregunta1 = model.Pregunta;
                        oTabla.Idrespuesta = model.Idrespuesta;

                        DB.Entry(oTabla).State = System.Data.Entity.EntityState.Modified;
                        DB.SaveChanges();
                    }

                    return Redirect("~/Perfil/Preguntas");

                }

                return View(model);

            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }

        }

        [HttpGet]
        public ActionResult EliminarPreguntas(int ID)
        {
            using (PsicologiaEntities1 DB = new PsicologiaEntities1())
            {
                var oTabla = DB.PREGUNTAS.Find(ID);
                DB.PREGUNTAS.Remove(oTabla);
                DB.SaveChanges();


            }

            return Redirect("~/Perfil/Preguntas");
        }

        //---------------------------------------------------------------
        public ActionResult Respuestas()
        {
            List<Respuestas> lista;
            using (PsicologiaEntities1 DB = new PsicologiaEntities1())
            {
                lista = (from d in DB.RESPUESTAS
                         select new Respuestas
                         {
                             Idrespuesta = d.Idrespuesta,
                             Idusuario = d.Idusuario,
                             respuesta = d.Respuesta1

                         }).ToList();
            }


            return View(lista);
        }


        public ActionResult nuevoRespuestas()
        {
            return View();
        }

        [HttpPost]
        public ActionResult nuevoRespuestas(TablaRespuestas model)
        {

            try
            {
                if (ModelState.IsValid)
                {

                    using (PsicologiaEntities1 DB = new PsicologiaEntities1())
                    {
                        var oTabla = new RESPUESTA();
                        oTabla.Idrespuesta = model.Idrespuesta;
                        oTabla.Idusuario = model.Idusuario;
                        oTabla.Respuesta1 = model.respuesta;


                        DB.RESPUESTAS.Add(oTabla);
                        DB.SaveChanges();
                    }

                    return Redirect("~/Perfil/Respuestas");

                }

                return View(model);

            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }

        }

        public ActionResult EditarRespuestas(int ID)
        {
            TablaRespuestas model = new TablaRespuestas();
            using (PsicologiaEntities1 DB = new PsicologiaEntities1())
            {
                var oTabla = DB.RESPUESTAS.Find(ID);
                oTabla.Idrespuesta = model.Idrespuesta;
                oTabla.Idusuario = model.Idusuario;
                oTabla.Respuesta1 = model.respuesta;

            }

            return View(model);
        }

        [HttpPost]
        public ActionResult EditarRespuestas(TablaRespuestas model)
        {

            try
            {
                if (ModelState.IsValid)
                {

                    using (PsicologiaEntities1 DB = new PsicologiaEntities1())
                    {
                        var oTabla = DB.RESPUESTAS.Find(model.Idrespuesta);
                        oTabla.Idrespuesta = model.Idrespuesta;
                        oTabla.Idusuario = model.Idusuario;
                        oTabla.Respuesta1 = model.respuesta;

                        DB.Entry(oTabla).State = System.Data.Entity.EntityState.Modified;
                        DB.SaveChanges();
                    }

                    return Redirect("~/Perfil/Respuestas");

                }

                return View(model);

            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }

        }

        [HttpGet]
        public ActionResult EliminarRespuestas(int ID)
        {
            using (PsicologiaEntities1 DB = new PsicologiaEntities1())
            {
                var oTabla = DB.RESPUESTAS.Find(ID);
                DB.RESPUESTAS.Remove(oTabla);
                DB.SaveChanges();


            }

            return Redirect("~/Perfil/Respuestas");
        }

        //---------------------------------------------------------------
        public ActionResult TipoUsuario()
        {
            List<TipoUsuario> lista;
            using (PsicologiaEntities1 DB = new PsicologiaEntities1())
            {
                lista = (from d in DB.TIPOUSUARIOs
                         select new TipoUsuario
                         {
                             Idusuario = d.Idusuario,
                             Tipousuario = d.Tipousuario1,

                         }).ToList();
            }


            return View(lista);
        }

        public ActionResult nuevoTipoUsuario()
        {
            return View();
        }

        [HttpPost]
        public ActionResult nuevoTipoUsuario(TablaTipoUsuario model)
        {

            try
            {
                if (ModelState.IsValid)
                {

                    using (PsicologiaEntities1 DB = new PsicologiaEntities1())
                    {
                        var oTabla = new TIPOUSUARIO();
                        oTabla.Idusuario = model.Idusuario;
                        oTabla.Tipousuario1 = model.Tipousuario;


                        DB.TIPOUSUARIOs.Add(oTabla);
                        DB.SaveChanges();
                    }

                    return Redirect("~/Perfil/TipoUsuario");

                }

                return View(model);

            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }

        }

        public ActionResult EditarTipoUsuario(int ID)
        {
            TablaTipoUsuario model = new TablaTipoUsuario();
            using (PsicologiaEntities1 DB = new PsicologiaEntities1())
            {
                var oTabla = DB.TIPOUSUARIOs.Find(ID);
                oTabla.Idusuario = model.Idusuario;
                oTabla.Tipousuario1 = model.Tipousuario;

            }

            return View(model);
        }

        [HttpPost]
        public ActionResult EditarTipoUsuario(TablaTipoUsuario model)
        {

            try
            {
                if (ModelState.IsValid)
                {

                    using (PsicologiaEntities1 DB = new PsicologiaEntities1())
                    {
                        var oTabla = DB.TIPOUSUARIOs.Find(model.Idusuario);
                        oTabla.Idusuario = model.Idusuario;
                        oTabla.Tipousuario1 = model.Tipousuario;

                        DB.Entry(oTabla).State = System.Data.Entity.EntityState.Modified;
                        DB.SaveChanges();
                    }

                    return Redirect("~/Perfil/TipoUsuario");

                }

                return View(model);

            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }

        }

        [HttpGet]
        public ActionResult EliminarTipoUsuario(int ID)
        {
            using (PsicologiaEntities1 DB = new PsicologiaEntities1())
            {
                var oTabla = DB.TIPOUSUARIOs.Find(ID);
                DB.TIPOUSUARIOs.Remove(oTabla);
                DB.SaveChanges();
            }

            return Redirect("~/Perfil/TipoUsuario");
        }



        //---------------------------------------------------------------
        public ActionResult Usuarios()
        {
            List<Usuarios> lista;
            using (PsicologiaEntities1 DB = new PsicologiaEntities1())
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

        public ActionResult nuevoUsuario()
        {
            return View();
        }

        [HttpPost]
        public ActionResult nuevoUsuario(TablaUsuarios model)
        {

            try
            {
                if (ModelState.IsValid)
                {

                    using (PsicologiaEntities1 DB = new PsicologiaEntities1())
                    {
                        var oTabla = new USUARIO();
                        oTabla.Idusuario = model.Idusuario;
                        oTabla.Idtipousuario = model.Idtipousuario;
                        oTabla.Cedula = model.Cedula;
                        oTabla.Nombre = model.Nombre;
                        oTabla.Apellido = model.Apellido;
                        oTabla.Ultimavez = model.Ultimavez;
                        oTabla.Correo = model.Correo;


                        DB.USUARIOS.Add(oTabla);
                        DB.SaveChanges();
                    }

                    return Redirect("~/Perfil/Usuarios");

                }

                return View(model);

            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }

        }

        public ActionResult EditarUsuario(int ID)
        {
            TablaUsuarios model = new TablaUsuarios();
            using (PsicologiaEntities1 DB = new PsicologiaEntities1())
            {
                var oTabla = DB.USUARIOS.Find(ID);
                oTabla.Idusuario = model.Idusuario;
                oTabla.Idtipousuario = model.Idtipousuario;
                oTabla.Cedula = model.Cedula;
                oTabla.Nombre = model.Nombre;
                oTabla.Apellido = model.Apellido;
                oTabla.Ultimavez = model.Ultimavez;
                oTabla.Correo = model.Correo;

            }

            return View(model);
        }

        [HttpPost]
        public ActionResult EditarUsuario(TablaUsuarios model)
        {

            try
            {
                if (ModelState.IsValid)
                {

                    using (PsicologiaEntities1 DB = new PsicologiaEntities1())
                    {
                        var oTabla = DB.USUARIOS.Find(model.Idusuario);
                        oTabla.Idusuario = model.Idusuario;
                        oTabla.Idtipousuario = model.Idtipousuario;
                        oTabla.Cedula = model.Cedula;
                        oTabla.Nombre = model.Nombre;
                        oTabla.Apellido = model.Apellido;
                        oTabla.Ultimavez = model.Ultimavez;
                        oTabla.Correo = model.Correo;

                        DB.Entry(oTabla).State = System.Data.Entity.EntityState.Modified;
                        DB.SaveChanges();
                    }

                    return Redirect("~/Perfil/Usuarios");

                }

                return View(model);

            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }

        }

        [HttpGet]
        public ActionResult EliminarUsuario(int ID)
        {
            using (PsicologiaEntities1 DB = new PsicologiaEntities1())
            {
                var oTabla = DB.USUARIOS.Find(ID);
                DB.USUARIOS.Remove(oTabla);
                DB.SaveChanges();
            }

            return Redirect("~/Perfil/Usuarios");
        }










    }
}