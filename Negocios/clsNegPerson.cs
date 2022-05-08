using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace Negocios
{
    public class clsNegPerson
    {
        clsDAOPerson daoPerson = new clsDAOPerson();
        public DataTable GetAll()
        {
            return daoPerson.GetAll();
        }
        public DataTable BuscarNombre(string data)
        {
            return daoPerson.BuscarNombre(data);
        }
    }
}
