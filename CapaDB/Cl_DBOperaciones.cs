using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Data.SqlClient;

namespace CapaDB
{
    public class Cl_DBOperaciones
    {
        Cl_DBConexion conexionDB = new Cl_DBConexion();
        

        
        public Cl_DBOperaciones()
        {

        }

        public List<Entidades.Entidades> ObtenerDatos() //Devuelve una lista con todos los registros en la DB
        {
            List<Entidades.Entidades> datos = null;
            try
            {
                conexionDB.AbrirConexion(); //Abrimos conexion

                datos = new List<Entidades.Entidades>();

                SqlCommand sqlC = new SqlCommand("Select * FROM Estudiante",conexionDB.conectar); //Hago la consulta
                SqlDataReader reader = sqlC.ExecuteReader();

                while (reader.Read())
                {
                    Entidades.Entidades entidades = new Entidades.Entidades()
                    {
                        Codigo = Convert.ToInt16(reader["codigo"]),
                        Nombre = Convert.ToString(reader["nombre"]),
                        Nivel = Convert.ToInt16(reader["nivel"])

                    };

                    datos.Add(entidades);
                }

                reader.Close();
                Console.WriteLine("*****DBOPERACIONES***** DATOS OBTENIDOS EXITOSAMENTE :D");

            }
            catch (Exception e)
            {
                conexionDB.CerrarConexion();
                Console.WriteLine("--------DBOPERACIONES------"+e.Message);
            }
            finally
            {
                conexionDB.CerrarConexion();
            }

            return datos;
        }

        public Entidades.Entidades BuscarDB(int codBuscar)
        {
            Entidades.Entidades datoBuscado = null;
            try
            {
                conexionDB.AbrirConexion(); //Abrimos conexion

                string cadenaBuscar = $"SELECT * FROM Estudiante where codigo= {codBuscar}";

                SqlCommand comando = new SqlCommand(cadenaBuscar, conexionDB.conectar);

                // SqlDataAdapter adaptador = new SqlDataAdapter(

                SqlDataReader dataReader = comando.ExecuteReader();

                if (dataReader.Read())
                {

                    Entidades.Entidades objE = new Entidades.Entidades
                    {

                        Codigo = Convert.ToInt32(dataReader["codigo"]),

                        Nombre = Convert.ToString(dataReader["nombre"]),

                        Nivel = Convert.ToInt32(dataReader["nivel"])
                    };

                    datoBuscado = objE;

                    dataReader.Close();
                    Console.WriteLine("*****DBOPERACIONES***** DATO ENCONTRADO");

                }
                else
                {

                    Console.WriteLine("--------DBOPERACIONES------ NO SE ENCONTRO DATO");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("--------DBOPERACIONES------" + e.Message);
            }
            finally
            {
                conexionDB.CerrarConexion();
            }

            return datoBuscado;
             
        }

        public void InsertarDB(Entidades.Entidades objDatos)
        {
            try
            {
                conexionDB.AbrirConexion();
                string sqlInsertInto = $"INSERT INTO Estudiante (nombre,nivel) VALUES ('{objDatos.Nombre}',{objDatos.Nivel})";

                SqlCommand sqlCommand = new SqlCommand(sqlInsertInto, conexionDB.conectar);
                sqlCommand.ExecuteNonQuery();

                Console.WriteLine("*********DBOPERACIONES********* DATOS INSERTADOS");
            }
            catch (Exception e)
            {
                Console.WriteLine("--------DBOPERACIONES----------" + e.Message);

            }
            finally
            {
                conexionDB.CerrarConexion();
            }
        }

        public bool EliminarDB(int codEliminar)
        {
            bool bandera = false;
            try
            {
                conexionDB.AbrirConexion();
                string sqlDelete = $"DELETE FROM Estudiante WHERE codigo = {codEliminar}";

                SqlCommand sqlCommand = new SqlCommand(sqlDelete, conexionDB.conectar);
                int filasAfectadas = sqlCommand.ExecuteNonQuery();

                if (filasAfectadas >= 1)
                {
                    Console.WriteLine("*********DBOPERACIONES********* DATO ELIMINADO");
                    bandera = true;
                }
                else
                {
                    Console.WriteLine($"--------DBOPERACIONES---------- Codigo {codEliminar} no encontrado en la DB.");
                }
                
            }
            catch (Exception e)
            {
                Console.WriteLine("--------DBOPERACIONES----------" + e.Message);

            }
            finally
            {
                conexionDB.CerrarConexion();
            }
            return bandera;
        }
    }
}
