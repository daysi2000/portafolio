using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace CLASE04.Clases
{
    class BE_Acceso_Datos
    {
        SqlConnection Conexion = new SqlConnection();
        SqlCommand Cmd = new SqlCommand();

        string cadena_conexion = "Data Source=DESKTOP-V2CUC0T\\SQLEXPRESS;Initial Catalog=TRATAMIENTO_ERRORES;Integrated Security=True";
        //string cadena_conexion = "Data Source = 200.69.137.167,11333; Initial Catalog = BD3K7G15_2021; User ID = BD3K7G15_2021; Password=BDG15_3922";
        private void Conectar()
        {
            Conexion.ConnectionString = cadena_conexion;
            Conexion.Open();
            Cmd.Connection = Conexion;
            Cmd.CommandType = System.Data.CommandType.Text;
        }
        private void Cerrar()
        {
            Conexion.Close();
        }
        public DataTable EjecutarSelect (string sql)
        {
            Conectar();
            Cmd.CommandText = sql;
            DataTable tabla = new DataTable();
            tabla.Load(Cmd.ExecuteReader());
            Cerrar();
            return tabla;
        }
    }
}
