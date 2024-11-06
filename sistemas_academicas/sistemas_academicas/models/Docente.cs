using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace sistemas_academicas.models
{
    public class Docente
    {
      [Key]
      public int idDocente { get; set; }
        public string codigo { get; set; }
        public string nombre { get; set; }
        public  string direccion { get; set; }
        public string telefono { get; set; }
        public byte[] foto { get; set; }
    }
}
