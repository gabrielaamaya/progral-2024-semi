using System.ComponentModel.DataAnnotations;

namespace sistemas_academicas.models
{
    public class Matricula {
        [Key]
        public int idMatricula { get; set; }
        public int IdAlumno { get; set; } //[fk_matricula_alumno]
        public DateTime fecha { get; set; }
        public string periodo { get; set; }

    }
}
