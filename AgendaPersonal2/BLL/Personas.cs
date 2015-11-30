using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
   public class Personas: ClaseMaestra
    {
        public int PersonaId { set; get; }
        public string Nombres { set; get; }
        public string Apellidos { set; get;  }
        public int EstadoCivil { set; get; }
        
        private Conexion conexion = new Conexion();

        public List<Telefonos> Telefonos { set; get; }

        public Personas()
        {
            Telefonos = new List<Telefonos>();
        }

        public void AgregarTelefono(int TelefonoId, string Numero)
        {
            this.Telefonos.Add(new Telefonos(TelefonoId, Numero));

        }

        public override bool Insertar()
        {
            bool retorno = false;
            StringBuilder Comando = new StringBuilder();
            retorno = conexion.Ejecutar(String.Format("insert into Personas(Nombres,Apellidos,EstadoCivil) value('" + Nombres + "', " + Apellidos + "', '" + EstadoCivil + "')"));

            if (retorno)
            {
                this.PersonaId = (int)conexion.ObtenerValor("Select Max(PersonaId) from Personas");

                foreach (var tel in this.Telefonos)
                {
                    Comando.AppendLine(String.Format("insert into PersonasTelefonos(PersonaId,Numero) Values('"+this.PersonaId+"', '"+tel.Numero+"');" ));

                }

                retorno = conexion.Ejecutar(Comando.ToString());
            }

            return retorno;
        }

    

        public override bool Editar()
        {
        bool retorno = false;
        StringBuilder Comando = new StringBuilder();

        retorno = conexion.Ejecutar("update Personas set Nombres = '"+ this.Nombres + "' Apellidos = '"+Apellidos+"', EstadoCivil = '"+EstadoCivil+"");


        if (retorno)
        {
            conexion.Ejecutar("Delete From PersonasTelefonos Where PersonaId=" + this.PersonaId);

            foreach (var tel in this.Telefonos)
            {
                    Comando.AppendLine(String.Format("insert into PersonasTelefonos(PersonaId,Numero) Values('" + this.PersonaId + "', '" + tel.Numero + "');"));
            }

                retorno = conexion.Ejecutar(Comando.ToString());
        }

        return retorno;
    }

        public override bool Buscar(int IdBuscado)
        {
            DataTable dt = new DataTable();
            DataTable dtTelefonos = new DataTable();
            dt = conexion.ObtenerDatos(String.Format("select  PersonaId,Nombres,Apellidos,EstadoCivil, from Personas where PersonaId='{0}'", IdBuscado));
            if (dt.Rows.Count > 0)
            {
                this.PersonaId = (int)dt.Rows[0]["PersonaId"];
                this.Nombres = dt.Rows[0]["Nombres"].ToString();
                this.Apellidos = dt.Rows[0]["Apellidos"].ToString();
                this.EstadoCivil = (int)dt.Rows[0]["EstadoCivil"];


                dtTelefonos = conexion.ObtenerDatos("Select p.TelefonoId,a.Numero " +
                                                    "From PersonasTelefonos p " +
                                                    "Inner Join Actores a On p.TelefonoId=a.TelefonoId" +
                                                    "Where p.PersonaId=" + this.PersonaId);

                foreach (DataRow row in dtTelefonos.Rows)
                {
                    this.AgregarTelefono((int)row["TelefonoId"], row["Numero"].ToString());
                }
            }

            return dt.Rows.Count > 0;
        
    }

        public override bool Eliminar()
        {
            bool retorno = false;

            retorno = conexion.Ejecutar("delete  from Personas where PersonaId= " + this.PersonaId + "; " + "Delete From PersonasTelefonos Where PersonaId=" + this.PersonaId);

            return retorno;
        }

        public override DataTable Listado(string Campos, string Condicion, string Orden)
        {
        string ordenFinal = ""; //!orden.Equals("") ? " orden by  " + orden : "";
        if (!Orden.Equals(""))
            ordenFinal = " orden by  " + Orden;

        return conexion.ObtenerDatos(("Select " + Campos + " from Persona where " + Condicion + ordenFinal));
    }

    }
}
