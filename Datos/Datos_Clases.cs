using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Datos
{
    public class Datos_Clases
    {
        static string cadenaConexion = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Consultas\Datos\ferreteria.accdb";
        public static string CadenaConexion
        {
            get { return cadenaConexion; }

        }
    }
}
