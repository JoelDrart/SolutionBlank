using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDB;
using Entidades;

namespace CapaLogica
{
    public class Cl_Operaciones
    {
        Cl_DBOperaciones objDBOp = new Cl_DBOperaciones();
        public List<Entidades.Entidades> ObtenerDatos()
        { 
            return objDBOp.ObtenerDatos();
        }
        
        public void RecibirInsertar(Entidades.Entidades objRecibido)
        {
            objDBOp.InsertarDB(objRecibido);
        }

        public bool RecibirEliminar(int codigoEliminar)
        {
            return objDBOp.EliminarDB(codigoEliminar);
        }

        public Entidades.Entidades RecibirBuscar(int codBuscar)
        {

            return objDBOp.BuscarDB(codBuscar);

        }

    }
}
