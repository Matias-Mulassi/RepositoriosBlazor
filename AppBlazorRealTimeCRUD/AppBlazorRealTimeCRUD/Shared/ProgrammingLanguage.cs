using System;
using System.Collections.Generic;
using System.Text;

namespace AppBlazorRealTimeCRUD.Shared
{
    public class ProgrammingLanguage //Clase del crud. Insertar, actualizar, eliminar de la db
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string WebSite { get; set; }

        public string Extensions { get; set; }

    }
}
