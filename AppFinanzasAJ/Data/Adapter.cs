using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace AppFinanzasAJ.Data
{
    public class Adapter
    {
        //private SqlConnection sqlConnection = new SqlConnection("ConnectionString;");

        //Clave por defecto a utlizar para la cadena de conexion
        const string consKeyDefaultCnnString = "MyConnectionString";
        const string consKeyAdodbCnnString = "MyConnectionStringADODB";

        #region Propiedades
        private SqlConnection _SqlConn;
        public SqlConnection SqlConn
        {
            get { return _SqlConn; }
            set { _SqlConn = value; }
        }
        private ADODB.Connection _AdoConn;
        public ADODB.Connection AdoConn
        {
            get { return _AdoConn; }
            set { _AdoConn = value; }
        }
        #endregion

        #region Metodos
        protected void OpenConnection()
        {
            string temp = ConfigurationManager.ConnectionStrings[consKeyDefaultCnnString].ConnectionString;
            SqlConn = new SqlConnection(temp);
            SqlConn.Open();
        }
        protected void CloseConnection()
        {
            SqlConn.Close();
            SqlConn = null;
        }

        protected void OpenConnectionADODB()
        {

            AdoConn = new ADODB.Connection();
            AdoConn.Open(ConfigurationManager.ConnectionStrings[consKeyAdodbCnnString].ConnectionString);

        }
        protected void CloseConnectionADODB()
        {
            AdoConn.Close();
            AdoConn = null;
        }


        protected SqlDataReader ExecuteReader(String commandText)
        {
            throw new Exception("Metodo no implementado");
        }
        #endregion
    }
}
