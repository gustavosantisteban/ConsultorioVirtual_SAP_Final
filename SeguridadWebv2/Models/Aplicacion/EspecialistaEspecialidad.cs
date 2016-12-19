using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SeguridadWebv2.Models.Aplicacion
{
    public class EspecialistaEspecialidad
    {
        [Key, Column(Order = 0)]
        public string EspecialidadId { get; set; }
        [Key, Column(Order = 1)]
        public string Id { get; set; }

        public virtual Especialidad Especialidad { get; set; }
        public virtual Especialista Especialista { get; set; }

    }
}