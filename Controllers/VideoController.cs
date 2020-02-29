using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using System.Data;
using System.Data.SqlClient;
using MVCPlantilla.Utilerias;

namespace MvcPlantilla.Controllers
{
    public class VideoController : Controller
    {
        //
        // GET: /Video/

        public ActionResult Index()
        {
            ViewData["Videos"] = BaseHelper.ejecutarConsulta("Select * from Videos", CommandType.Text);

            return View();
            
      }

        /*public ActionResult Agregar()
        {
            return View();
        }*/

        public ActionResult Agregar()
        {
            
            return View();
        }

        public ActionResult InsertarRegistro()
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            int idvideo = Convert.ToInt16(Request.Form["idVideo"]);
            string titulo = Convert.ToString(Request.Form["titulo"]);
            int reproducciones = Convert.ToInt16(Request.Form["reproducciones"]); 
            string url = Convert.ToString(Request.Form["url"]); 
            
            parametros.Add(new SqlParameter("@idvideo", idvideo));
            parametros.Add(new SqlParameter("@titulo", titulo));
            parametros.Add(new SqlParameter("@reproducciones", reproducciones));
            parametros.Add(new SqlParameter("@url", url));

            int registros = BaseHelper.ejecutarAgregar("INSERT INTO Videos " + "VALUES (@idvideo, @titulo, @reproducciones, @url)", CommandType.Text, parametros);
            if(registros>0)
                Response.Write("<script LANGUAGE='JavaScript' >alert('Registro agregado')</script>");
            
           return View();
        }



        public ActionResult Actualizar()
        {
            return View();
        }

        public ActionResult Eliminar()
        {
            return View();
        }

    }
}
