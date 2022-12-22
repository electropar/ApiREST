using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace Webapi.Models
{
    public class ABM
    {
        private string cadena = "data source=NEMESIS;Database=ELECTROPAR;integrated security = false; persist security info= false; user id = 'sa'; Password = 'nem%2087z'";
        public SqlConnection cn;
        private SqlCommandBuilder cmb;
        public DataSet ds = new DataSet();
        public SqlDataAdapter da;
        public SqlCommand comando;

        private void conectar()
        {
            cn = new SqlConnection(cadena);

        }

        public ABM()
        {
            conectar();
        }

        /*consultar*/
        public void consultar(string sql, string tabla)
        {
            ds.Tables.Clear();
            da = new SqlDataAdapter(sql, cn);
            cmb = new SqlCommandBuilder(da);
            da.Fill(ds, tabla);
        }

        //eliminar
        public bool eliminar(string tabla, string condicion)
        {
            cn.Open();
            string sql = "delete from " + tabla + " where " + condicion;
            comando = new SqlCommand(sql, cn);
            int i = comando.ExecuteNonQuery();
            cn.Close();
            if (i > 0)
            {
                return true;
            }
            else {
                return false;
            }
        }

        /// actualizar
        public bool actualizar(string tabla, string campos, string condicion)
        {
            cn.Open();
            string sql = "update " + tabla + " set " + campos + "where " + condicion;
            comando = new SqlCommand(sql, cn);
            int i = comando.ExecuteNonQuery();
            cn.Close();
            if (i > 0)
            {
                return true;

            }
            else {
                return false;
            }

        }

        public DataTable consultar2(string sql)
        {
            da = new SqlDataAdapter(sql, cn);            
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public bool insertar(string sql)
        {
            cn.Open();
            comando = new SqlCommand(sql, cn);
            int i = comando.ExecuteNonQuery();
            cn.Close();
            if (i > 0)
            {
                return true;
            }
            else {
                return false;
            }
        }

        public string DataTableToJSONWithStringBuilder(DataTable table)
        {
            var JSONString = new StringBuilder();
            if (table.Rows.Count > 0)
            {
                JSONString.Append("[");
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    JSONString.Append("{");
                    for (int j = 0; j < table.Columns.Count; j++)
                    {
                        if (j < table.Columns.Count - 1)
                        {
                            JSONString.Append("\"" + table.Columns[j].ColumnName.ToString() + "\":" + "\"" + table.Rows[i][j].ToString() + "\",");
                        }
                        else if (j == table.Columns.Count - 1)
                        {
                            JSONString.Append("\"" + table.Columns[j].ColumnName.ToString() + "\":" + "\"" + table.Rows[i][j].ToString() + "\"");
                        }
                    }
                    if (i == table.Rows.Count - 1)
                    {
                        JSONString.Append("}");
                    }
                    else
                    {
                        JSONString.Append("},");
                    }
                }
                JSONString.Append("]");
            }
            return JSONString.ToString();
        }

    }
}