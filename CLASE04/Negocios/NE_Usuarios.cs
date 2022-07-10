using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CLASE04.Clases;
using System.Data;

namespace CLASE04.Negocios
{
    class NE_Usuarios
    {
        public enum Validacion {correcta, incorrecta } 

        BE_Acceso_Datos _BD = new BE_Acceso_Datos();

        public Validacion Validar (string nombre, string password)
        {
            string sql = @"SELECT * FROM Usuarios
                         WHERE n_usuario = '" + nombre +"'"
                         + " AND password = " + password;

            DataTable tabla = new DataTable(); 
            tabla =  _BD.EjecutarSelect(sql);

            if (tabla.Rows.Count == 1)
            {
                return Validacion.correcta;
            }
            else
            {
                return Validacion.incorrecta;
            }
        }
        public int RecuperarId (string nombre, string password)
        {
            string sql = @"SELECT id_usuario FROM Usuarios
                         WHERE n_usuario = '" + nombre + "'"
                        + " AND password = " + password;

            DataTable tabla = new DataTable();
            tabla = _BD.EjecutarSelect(sql);

            if (tabla.Rows.Count == 1)
                return int.Parse(tabla.Rows[0][0].ToString());
            else
                return 0;
        }
        public DataTable BuscarUsuario (string patron, string columna)
        {
            string sql = @"SELECT id_usuario, n_usuario, apellido, nombres 
                          FROM usuarios WHERE " + columna + " like '%" + patron + "%'";

            return _BD.EjecutarSelect(sql);
        }
        public DataTable BuscarUsuario(string id_usuario)
        {
            string sql = @"SELECT id_usuario, n_usuario, apellido, nombres 
                          FROM usuarios WHERE id_usuario = " + id_usuario;

            return _BD.EjecutarSelect(sql);
        }
    }
}
