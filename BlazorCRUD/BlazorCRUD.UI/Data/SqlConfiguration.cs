using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorCRUD.UI.Data
{
    public class SqlConfiguration //Utilizamos esta clase para traer el connectionString del appsetting.json a nuestro servicio
    {

        public SqlConfiguration(string connectionString) => ConnectionString = connectionString;
        
        public string ConnectionString { get; }

    }
}
