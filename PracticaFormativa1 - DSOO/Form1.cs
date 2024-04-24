using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaFormativa1___DSOO
{
    public partial class frmPracicaFormativa1 : Form
    {
        //VARIABLES DE LA CLASE:
        public Televisor tv { get; set; }
        public Domicilio ddo { get; set; }
        public Persona persona1 { get; set; }
        public Persona persona2 { get; set; }
        private int numero = 0;

        public frmPracicaFormativa1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //CONFIGURACION DE BOTONES NUM
        private void btnNUM1_Click(object sender, EventArgs e)
        {
            int n1 = 1;
            Concatenar_Numeros(n1);
        }
        private void btnNUM2_Click(object sender, EventArgs e)
        {
            int n2 = 2;
            Concatenar_Numeros(n2);
        }
        private void btnNUM3_Click(object sender, EventArgs e)
        {
            int n3 = 3;
            Concatenar_Numeros(n3);
        }
        private void btnNUM4_Click(object sender, EventArgs e)
        {
            int n4 = 4;
            Concatenar_Numeros(n4);
        }
        private void btnNUM5_Click(object sender, EventArgs e)
        {
            int n5 = 5;
            Concatenar_Numeros(n5);
        }
        private void btnNUM6_Click(object sender, EventArgs e)
        {
            int n6 = 6;
            Concatenar_Numeros(n6);
        }
        private void btnNUM7_Click(object sender, EventArgs e)
        {
            int n7 = 7;
            Concatenar_Numeros(n7);
        }
        private void btnNUM8_Click(object sender, EventArgs e)
        {
            int n8 = 8;
            Concatenar_Numeros(n8);
        }
        private void btnNUM9_Click(object sender, EventArgs e)
        {
            int n9 = 9;
            Concatenar_Numeros(n9);
        }
        private void btnNUM0_Click(object sender, EventArgs e)
        {
            int n0 = 0;
            Concatenar_Numeros(n0);
        }

        //CONFIGURACION DE BOTON OK
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (tv.VerPrendido() == true)
            {
                tv.CambiarCanal(numero);
                MessageBox.Show($"Se cambió al canal {tv.getNumCanal()}");
                numero = 0;
            }
            else { MessageBox.Show("El televisor esta apagado."); }
        }

        //CONFIGURACION DE BOTON CAMBIAR
        private void btnCAMBIAR_Click(object sender, EventArgs e)
        {
            if (tv.VerPrendido() == true)
            {
                tv.CambiarCanal();
                MessageBox.Show($"Se cambió al canal {tv.getNumCanal()}");
            }
            else { MessageBox.Show("El televisor esta apagado."); }
        }

        //CONFIGURACION DE BOTON VER CANAL
        private void btnVERCANAL_Click(object sender, EventArgs e)
        {
            if (tv.VerPrendido() == true) { MessageBox.Show($"CANAL NUMERO: {tv.ObtenerCanalActual()}"); }  
            else { MessageBox.Show("El televisor esta apagado."); }
        }

        //CONFIGURACION DE BOTON INFO
        private void btnINFO_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"INFORMACION:\n" +
                $"TELEVISOR: {tv}\n" +
                $"PROPIETARIOS: {persona1}, {persona2}\n" +
                $"DOMICILIO: {ddo}\n" +
                $"Los propietarios registrados poseen todos los permisos de uso.");
        }

        //CONFIGURACION DE BOTON ONOFF
        private void btnONOFF_Click(object sender, EventArgs e)
        {
            if (tv.VerPrendido() == false) 
            { 
                tv.CambiarEstado(true);
                MessageBox.Show("Televisor Encendido");
            }
            else 
            {
                tv.CambiarEstado(false);
                MessageBox.Show("Televisor Aapagado"); 
            }
        }

        //METODO CONCATENAR NUMEROS:
        private int Concatenar_Numeros(int n)
        {
            int resultado;
            if (numero == 0) { resultado = n; }
            else
            {
                String num1 = Convert.ToString(numero);
                String num2 = Convert.ToString(n);
                String num3 = (num1 + num2);
                resultado = int.Parse(num3);
            }
            return numero = resultado;
        }
    }
}
