﻿using sistema_academico.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace sistemas_academicas.models
{
    public class Matricula {
        [Key]
        public int idMatricula { get; set; }
        public int IdAlumno { get; set; } //[fk_matricula_alumno]
        public DateTime fecha { get; set; }
        public string periodo { get; set; }
        //relacionar con la tabla alunos
        [ForeignKey("idAlumno")]
        public Alumno? Alumno { get; set; }
    }
}
