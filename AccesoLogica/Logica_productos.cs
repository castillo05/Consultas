using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Datos;
using System.Data;

namespace AccesoLogica
{
   public class Logica_productos
   {
       #region obtener productos
       public static DataTable obtenerprod()
       {

           return Datos__productos.obtenerproductos();
       }


       //buscar producto
      public static DataTable buscar(string nombre)
       {
          
              return Datos__productos.filtro(nombre);

           

       }

      public static DataTable buscar1(string nombre)
      {

          return Datos__productos.filtro1(nombre);



      }


       #endregion

       #region insertar productos
       public static bool insertarproducto(string codigo, string nombre_pro, string unidad_medida, Double precio_compra, Double precio_venta, Double cantidad,string categoria)
       {
           try
           {
               if (Datos__productos.insertarproductos(codigo, nombre_pro, unidad_medida, precio_compra, precio_venta, cantidad,categoria) != 0)
               {
                   return true;
               }
               else
               {
                   return false;
               }
           }
           catch (Exception)
           {

               return false;
           }

       }
       #endregion

       #region Actualizar productos
       public static bool actualizarproducto(Double cantidad, string unidad_medida, string codigo, string nombre_pro, Double precio_venta,string cod)
       {
           try
           {
               if (Datos__productos.actualizarproductos(cantidad,unidad_medida,codigo,nombre_pro,precio_venta,cod) != 0)
               {
                   return true;
               }
               else
               {
                   return false;
               }
           }
           catch (Exception)
           {

               return false;
           }
       }
       #endregion

           #region Eliminar Productos
            public static bool eliminarproducto(string codigo)
       {
           try
           {
               if (Datos__productos.eliminarproductos(codigo) != 0)
               {
                   return true;
               }
               else
               {
                   return false;
               }
           }
           catch (Exception)
           {

               return false;
           }
           #endregion
       }
   
   }
}

