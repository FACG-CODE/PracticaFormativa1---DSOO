using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaFormativa1___DSOO
{
    internal class Test
    {
        public static void Main(String[] args)
        {
            //Instancio CLASES
            Televisor televisor1 = new Televisor("Samsung","S60004K50",50,false,1);
            Domicilio domicilio1 = new Domicilio("Jonte",5299,"Monte Castro");
            Persona persona1 = new Persona("Facundo",domicilio1);
            Persona persona2 = new Persona("Camila", domicilio1);
            //Instancio FORMULARIO y envio los objetos instanciados a variables para ser usado en FORM.
            frmPracicaFormativa1 formulario1 = new frmPracicaFormativa1();
            formulario1.tv = televisor1;
            formulario1.ddo = domicilio1;
            formulario1.persona1 = persona1;
            formulario1.persona2 = persona2;   
            //Ejecuto FORM
            Application.Run(formulario1);
        }
    }
}
