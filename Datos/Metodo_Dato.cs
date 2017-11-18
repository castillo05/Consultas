using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;
//using MySql.Data.MySqlClient;
using Datos;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Datos
{
    class Metodo_Dato
    {
        public static OleDbCommand CrearComando()
            {
                string _cadenaConexion = Datos.Datos_Clases.CadenaConexion;
                OleDbConnection _conexion = new OleDbConnection();
                _conexion.ConnectionString = _cadenaConexion;
                OleDbCommand _comando = new OleDbCommand();
                _comando = _conexion.CreateCommand();
                _comando.CommandType = CommandType.Text;
                return _comando;
            }
         //ejecutar comando con procedimientos almacenado
        public static OleDbCommand crearcomandoproc(string proc)
         {
             string _cadenaConexion = Datos.Datos_Clases.CadenaConexion;
             OleDbConnection _conexion = new OleDbConnection();
             _conexion.ConnectionString = _cadenaConexion;
             OleDbCommand _comando = new OleDbCommand(proc, _conexion);
             _comando.CommandType = CommandType.StoredProcedure;
             return _comando;
         }


        //ejecutar comandos
        public static int ejecutarcomando(OleDbCommand comando)
         {
            try
            {
                comando.Connection.Open();
                return comando.ExecuteNonQuery();
            }
            catch
            {
                throw;
            }
            finally
            {
                comando.Connection.Dispose();
                comando.Connection.Close();
            }

         }
      



        //Ejecutar comando Select
        public static DataTable EjecutarComandoSelect(OleDbCommand comando)
         {
             DataTable _tabla = new DataTable();
             try
             {
                 comando.Connection.Open();
                 OleDbDataAdapter adaptador = new OleDbDataAdapter();
                 adaptador.SelectCommand = comando;
                 adaptador.Fill(_tabla);
             }
             catch (Exception ex)
             { MessageBox.Show(ex.Message); }
             finally
             { comando.Connection.Close(); }
             return _tabla;
         }
    }
}
