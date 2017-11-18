using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Data.SqlClient;
using System.Data.OleDb;

namespace Datos
{
    public class Datos__productos

    {

        //Obtener productos
        public static DataTable obtenerproductos()
        {
            OleDbCommand _comando = Metodo_Dato.CrearComando();
            _comando.CommandText = "select * from precio_prod";
            return Metodo_Dato.EjecutarComandoSelect(_comando);

        }

        public static int  buscarprod(string nombre)
        {
            OleDbCommand _comando = Metodo_Dato.CrearComando();
            _comando.CommandText = "SELECT * FROM precio_prod where descripcion=@nombre";
            _comando.Parameters.AddWithValue("@nombre",nombre);
            return Metodo_Dato.ejecutarcomando(_comando);

        }

        public static DataTable filtro(string buscar)
        {
            OleDbCommand _comando = Metodo_Dato.CrearComando();
            _comando.CommandText = "SELECT Id,Cantidad,unidad,codigo,descripcion,precio_venta FROM precio_prod where descripcion like '%"+buscar+"%'";

            return Metodo_Dato.EjecutarComandoSelect(_comando);
        }

        public static DataTable filtro1(string buscar)
        {
            OleDbCommand _comando = Metodo_Dato.CrearComando();
            _comando.CommandText = "SELECT Id,Cantidad,unidad,codigo,descripcion,precio_venta FROM precio_prod where codigo like '%" + buscar + "%'";

            return Metodo_Dato.EjecutarComandoSelect(_comando);
        }

        
        //insertar productos
        public static int insertarproductos(string codigo, string nombre_pro, string unidad_medida, Double precio_compra, Double precio_venta, Double cantidad,string categoria)
        {
            OleDbCommand _comando2 = Metodo_Dato.CrearComando();
            _comando2.CommandText = ("INSERT INTO `productos`(`codigo`, `nombre_prod`, `unidad_medida`, `precio_compra`, `precio_venta`, `cantidad`,`categoria`) VALUES (@codigo,@nombre_prod,@unidad_medida,@precio_compra,@precio_venta,@cantidad,@categoria)");
            _comando2.Parameters.AddWithValue("@codigo", codigo);
            _comando2.Parameters.AddWithValue("@nombre_prod", nombre_pro);
            _comando2.Parameters.AddWithValue("@unidad_medida", unidad_medida);
            _comando2.Parameters.AddWithValue("@precio_compra", precio_compra);
            _comando2.Parameters.AddWithValue("@precio_venta", precio_venta);
            _comando2.Parameters.AddWithValue("@cantidad", cantidad);
            _comando2.Parameters.AddWithValue("@categoria",categoria);
           // _comando2.Parameters.AddWithValue("@categoria_id", categoria_id);
            return Datos.Metodo_Dato.ejecutarcomando(_comando2);
        }
        //Actualizar productos
        public static int actualizarproductos( Double cantidad,string unidad_medida,string codigo, string nombre_pro,Double precio_venta,string cod)
        {
            OleDbCommand _comando2 = Metodo_Dato.CrearComando();
            _comando2.CommandText = ("UPDATE precio_prod SET Cantidad = @cantidad,unidad = @unidad,codigo=@codigo,descripcion = @desc,precio_venta = @precio WHERE Id = @cod");
            _comando2.Parameters.AddWithValue("@cantidad", cantidad);
            _comando2.Parameters.AddWithValue("@unidad", unidad_medida);
            _comando2.Parameters.AddWithValue("@codigo", codigo);
            _comando2.Parameters.AddWithValue("@desc", nombre_pro);
           _comando2.Parameters.AddWithValue("@precio", precio_venta);
           _comando2.Parameters.AddWithValue("@cod", cod);
            return Datos.Metodo_Dato.ejecutarcomando(_comando2);
        }

        //Eliminar Productos
        public static int eliminarproductos(string codigo)
        {
            OleDbCommand _comando2 = Metodo_Dato.CrearComando();
            _comando2.CommandText = ("DELETE FROM `productos` WHERE `codigo`=@codigo");
            _comando2.Parameters.AddWithValue("@codigo", codigo);
           
            return Datos.Metodo_Dato.ejecutarcomando(_comando2);
        }
    }
}
