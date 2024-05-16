using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public static class UserCache
    {
        public static int IdUser { get; set; }
        public static string nombres { get; set; } // nom, ape,fhN,tel,direccion, correo, user, pass
        public static string apellidos { get; set; }//
        public static int idpuesto { get; set; }
        public static DateTime fhNacido { get; set; }//
        public static DateTime fhContratado { get; set; }
        public static string direccion { get; set; }//
        public static string telefono { get; set; }//
        public static string correo { get; set; }//
        public static int idturno { get; set; }
        public static string usuario { get; set; }//
        public static string contraseña { get; set; }//
        //
        public static string Cargousuario { get; set; }
        public static decimal sueldo { get; set; }
    }
}
