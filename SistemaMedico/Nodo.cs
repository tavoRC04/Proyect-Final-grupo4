using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaMedico
{
    public class Nodo
    {
        public string Pregunta { get; set; }
        public Nodo NodoSi { get; set; }
        public Nodo NodoNo { get; set; }
        public string Diagnostico { get; set; }
        public string Tratamiento { get; set; }

        public Nodo(string pregunta)
        {
            Pregunta = pregunta;
        }
    }
}
