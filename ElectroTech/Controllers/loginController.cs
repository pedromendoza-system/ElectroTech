﻿using ElectroTech.conexion;
using ElectroTech.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Security.Cryptography;
using System.Text;
using System.Runtime.Remoting.Messaging;


namespace ElectroTech.Controllers
{
    public class loginController : Controller
    {
        private readonly DatabaseConnection bd;
        public loginController()
        {
            bd = new DatabaseConnection(); // Se crea la conexión con la BD
        }


        // GET: login
        public ActionResult Login()
        {
            return View();
        }
        public ActionResult validarUsuario()
        {
            return View();
        }


        [HttpPost]
         public ActionResult Login(usuario datUsuario)
         {
            datUsuario.pass = encripatar(datUsuario.pass);
            Console.WriteLine(datUsuario.pass);

            using (SqlConnection con = bd.GetConnection())


            {

                SqlCommand consulta = new SqlCommand("validarUsuario", con);
                consulta.Parameters.AddWithValue("usuario", datUsuario.nomUsuario);
                consulta.Parameters.AddWithValue("pass", datUsuario.pass);
                consulta.CommandType = CommandType.StoredProcedure;



                datUsuario.usuarioID = Convert.ToInt32(consulta.ExecuteScalar().ToString());

            }

            if (datUsuario.usuarioID != 0)
            {

                Session["usuario"] = datUsuario;
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewData["Mensaje"] = "Usuario No Existe";
                return View();
            }


         }

        public static string encripatar(string texto)
        {
             StringBuilder Sb = new StringBuilder();
            using (SHA256 hash = SHA256Managed.Create())
            {
                Encoding enc = Encoding.UTF8;
                byte[] result = hash.ComputeHash(enc.GetBytes(texto));

                foreach (byte b in result)
                    Sb.Append(b.ToString("x2"));
            }

            return Sb.ToString();
        }

    }
}