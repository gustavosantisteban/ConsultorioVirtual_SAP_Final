using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SeguridadWebv2.Models.Aplicacion
{
    public class File
    {
        public File()
        {
            this.IdFile = Guid.NewGuid().ToString();
        }

        [Key]
        public string IdFile { get; set; }
        public string Descripcion { get; set; }
        public DateTime Fecha { get; set; }
    }
}