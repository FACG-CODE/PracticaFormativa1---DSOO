using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaFormativa1___DSOO
{
    public class Domicilio
    {
        //ATRIBUTOS:
        private String calle;
        private int numero;
        private String barrio;
        //CONSTRUCTOR:
        public Domicilio (String calle, int numero, String barrio)
        {
            this.calle = calle;
            this.numero = numero;
            this.barrio = barrio;
        }
        //GET AND SET:
        //CALLE
        public String getCalle () { return calle; }
        public void setCalle (String calle) {  this.calle = calle; }
        //NUMERO
        public int getNumero () { return numero; }
        public void setNumero (int numero) { this.numero = numero; }
        //BARRIO
        public String getBarrio () { return barrio;}
        public void setBarrio (String barrio) {  this.barrio = barrio; }

        //TO STRING
        public override string ToString()
        {
            return $"Calle: {calle}, Numero: {numero}, Barrio: {barrio}"; 
        }
    }
}
