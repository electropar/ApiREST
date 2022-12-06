using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Input;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ConectarSQL
{
    public class ConectarSQL
    {
        private string strCliente;
        private string strServidor;
        private string strBaseDatos;
        private string strUsuario;
        private string strContraseña;
        private string strCadenaConeccion;

        private int intConeccionesAbiertas;
        private int intConeccionesCerradas;
        /*prueba de comentario extenso*/

        private string Base1;
        private string servidor1;
        private string usuario;
        private string pass;

        private static ConectarSQL con = null;

        private ConectarSQL() {
            this.Base1 = "ELECTROPAR";
            this.servidor1 = "NEMESIS";
            this.usuario = "sa";
            this.pass = "nem%2087z";
        }
        public SqlConnection crearconexion() {
            SqlConnection cadena = new SqlConnection();
            try
            {
                cadena.ConnectionString = "Server=" + this.servidor1 +
                                           "; Database="+this.Base1 +
                                           "; User Id="+this.usuario +
                                           "; Password="+this.pass;

            }
            catch (Exception ex) {
                cadena = null;
                throw ex;
            }
            return cadena;
        }

        public static ConectarSQL getIntancia(){
            if (con == null) {
                con = new ConectarSQL();
            }
            return con;
        }
    }

    
    
}
