using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SeguridadWebv2.Models.Aplicacion
{
    [Table("Relacion")]
    public class Relacion
    {
        public Relacion()
        {
            this.IdRelacion = Guid.NewGuid().ToString();
            this.Turnos = new List<Turno>();
        }
        [Key]
        public string IdRelacion { get; set; }
        //public string IdPaciente { get; set; }
        //public string IdEspecialista { get; set; }
        public DateTime FechaRelacion { get; set; }
        public bool Estado { get; set; }
        
        public virtual Paciente Paciente { get; set; }
        public virtual Especialista Especialista { get; set; }
        public ICollection<Turno> Turnos { get; set; }
    }
}