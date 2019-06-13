using System;
using System.Collections.Generic;

namespace WebEscuela.Models
{
    public class Curso: ObjetoEscuelaBase
    {
        public TiposJornada TipoJornada { get; set; }
        public List<Alumno> Alumnos { get; set; }
        public List<Asignatura> Asignaturas { get; set; }
        public string Direccion { get; set; }
    }
}