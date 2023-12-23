using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;

namespace CapaDB
{
    public class Cl_DBConexion
    {
        //public string cadena = "data source = localhost; initial catalog = BD_Estudiantes_VS; user id = sa; password = sqlserver";
        public SqlConnection conectar = new SqlConnection();

        public Cl_DBConexion()
        {
            //conectar.ConnectionString = cadena;
            conectar.ConnectionString = new SqlConnectionStringBuilder()
                                            {
                                                DataSource = "DESKTOP-VVTBV21\\SQLEXPRESS",
                                                InitialCatalog= "BD_Estudiantes_VS",
                                                UserID="sa",
                                                Password= "sqlserver"
                                            }.ConnectionString;
        }

        public void AbrirConexion()
        {
            try
            {
                conectar.Open(); 
                Console.WriteLine("*******DBCONEXION*******Conexión exitosa ;D");
            }
            catch (Exception e)
            {
                Console.WriteLine("------DBCONEXION----Hubo un ERROR"+ e.Message);
                
            }
        }
        public void CerrarConexion()
        {
            conectar.Close();
        }        
    }
}
