using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaFormativa1___DSOO
{
    public class Televisor
    {
        //ATRIBUTOS
        private String marca;
        private String modelo;
        private int cantPulgadas;
        private bool estado;
        private int numCanal;

        //CONSTRUCTOR
        public Televisor(string marca, string modelo, int cantPulgadas, bool estado, int numCanal)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.cantPulgadas = cantPulgadas;
            this.estado = estado;
            this.numCanal = numCanal;
        }

        //GET AND SET:
        //MARCA
        public String getMarca() { return marca; }
        public void setMarca(String marca) { this.marca = marca; }
        //MODELO
        public String getModelo() { return modelo; }
        public void setModelo(String modelo) { this.modelo = modelo; }
        //CANTPULGADAS
        public int getCantPulgadas() { return cantPulgadas; }
        public void setCantPulgadas(int cantPulgadas) { this.cantPulgadas = cantPulgadas; }
        //ESTADO
        public bool isEstado() { return estado; }
        public void setEstado(bool estado) { this.estado = estado; }
        //NUMCANAL
        public int getNumCanal() { return numCanal; }
        public void setNumCanal(int numCanal) { this.numCanal = numCanal; }

        //METODOS:
        //VALIDAR CANAL
        private int ValidarCanal(int numero)
        {
            if (numero < 1) { return 1; }
            else if (numero > 150) { return 150; }
            else return numero;
        }

        //OBTENER CANAL ACTUAL
        public int ObtenerCanalActual() { return numCanal; }

        //CAMBIAR CANAL AL NUMERO DIGITADO (METODO SOBRECARGADO)
        public int CambiarCanal(int numero)
        {
            if (true == VerPrendido())
            {
                numCanal = ValidarCanal(numero);
                return numCanal;
            }
            else { return numCanal; }
        }
        public int CambiarCanal()
        {
            if (true == VerPrendido())
            {
                if (numCanal < 150)
                {
                    numCanal++;
                    numCanal = ValidarCanal(numCanal);
                    return numCanal;
                }
                else { return numCanal = 1; }
            }
            else { return numCanal; }
        }

        //VER ESTADO TELEVISOR
        public bool VerPrendido() { return estado; }

        //CAMBIAR ESTADO TELEVISOR
        public bool CambiarEstado(bool accion)
        {
            if (accion == true && false == VerPrendido()) { estado = accion; }
            else if (accion == false && true == VerPrendido()) { estado = accion; }
            return estado;
        }

        //TO STRING
        public override string ToString()
        {
            return $"Marca: {marca}, Modelo: {modelo}, Pulgadas: {cantPulgadas}";
        }
    }
}