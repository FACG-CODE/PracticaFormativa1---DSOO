using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaFormativa1___DSOO
{
    public class Persona
    {
        //ATRIBUTOS:
        private String nombre;
        private Domicilio domicilio;

        //CONSTRUCTOR:
        public Persona(String nombre, Domicilio domicilio) 
        {
            this.nombre = nombre;
            this.domicilio = domicilio;
        }

        //GET AND SET:
        //NOMBRE
        public String getNombre() {  return nombre; }
        public void setNombre(String nombre) { this.nombre = nombre; }
        //DOMICILIO
        public Domicilio getDomicilio() {  return domicilio; }
        public void setDomicilio(Domicilio domicilio) { this.domicilio = domicilio; }

        //TO STRING
        public override String ToString() 
        {
            return $"Nombre: {nombre}";
        }
    }
}
