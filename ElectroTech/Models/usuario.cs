using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ElectroTech.Models
{
	public class usuario
	{
        public int usuarioID { get; set; }
        public string nombre { get; set; }
        public string nomUsuario { get; set; }
        public string pass { get; set; }
        public string rol { get; set; }
        public bool estado { get; set; }

    }
}