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

        //public ActionResult Agregar()
        //{
          //  return View();
        //}

        //public ActionResult Agregar(int idvideo, string titulo, int reproducciones, string url)
       //{

        //return View();
        //List<SqlParameter> parametros = new List<SqlParameter>();
        //parametros.add(new SqlParameter("@idvideo", idvideo));
        //parametros.Add(new SqlParameter("@titulo", titulo));
        //parametros.Add(new SqlParameter("@reproducciones", reproducciones));
        //parametros.Add(new SqlParameter("@url", url));

         //BaseHelper EjecutarSentencia("INSERT INTO Videos" + "VALUES (@idvideo, @titulo, @reproducciones, @url)", CommandType.Text, parametros);   

            //return View("Mensaje");

        //}
          //  return View();
        //}
       
    

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
