using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    /// <summary>
    /// La clase conexion...
    /// </summary>
    public class Conexion
    {
        private SqlConnection conexion;
        private SqlCommand Cmd;

        public Conexion()
        {
            string connectionString = "Data Source=USUARIO-PC\\SQLEXPRESS;Initial Catalog=master;Integrated Security=True";
           conexion = new SqlConnection(connectionString);
            Cmd = new SqlCommand();
        }

        /// <summary>
        /// Ejecuar comandos contra la base de datos
        /// </summary>
        /// <param name="ComandoSql">El comando sql que se desea ejecutar</param>
        /// <returns>Verdadero o Falso dependiendo de si ejecuto correctament o no</returns>
        public bool Ejecutar(String ComandoSql)
        {
            bool retorno = false;

            try
            {
                conexion.Open();
                Cmd.Connection = conexion;
                Cmd.CommandText = ComandoSql;
                Cmd.ExecuteNonQuery();
                retorno = true;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexion.Close();
            }

            return retorno;
        }

        public DataTable ObtenerDatos(String ComandoSql)
        {

            SqlDataAdapter adapter;
            DataTable dt = new DataTable();

            try
            {
                conexion.Open();
                Cmd.Connection = conexion;
                Cmd.CommandText = ComandoSql;

                adapter = new SqlDataAdapter(Cmd);
                adapter.Fill(dt);

            }
            catch (Exception ex)
            {
                throw ex;
                //MessageBox.Show(ex.Message);
            }
            finally
            {
                conexion.Close();
            }

            return dt;
        }


        public Object ObtenerValor(String ComandoSql)
        {
            Object retorno = null;

            try
            {
                conexion.Open();
                Cmd.Connection = conexion;
                Cmd.CommandText = ComandoSql;
                retorno = Cmd.ExecuteScalar();
                retorno = true;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexion.Close();
            }

            return retorno;
        }

    }
}