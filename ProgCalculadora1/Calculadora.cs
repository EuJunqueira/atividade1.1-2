using System;
using System.Collections.Generic;
using System.Text;

namespace ProgCalculadora1
{
    class Calculadora
    {
        public double Numero;
        public int Referencia;

        private List<double> listNumero = new List<double>();
        public void addNumero(double Numero)
        {
            this.listNumero.Add(Numero);
        }
        public double Somar()
        {
            double Resultado = 0;
            foreach (double Numero in this.listNumero)
            {
                Resultado += Numero;
            }
            this.listNumero.Clear();
            return Resultado;
        }
        public double Subtrair()
        {
            double Resultado = this.listNumero[0];
            this.listNumero.RemoveAt(0);
            foreach (double Numero in this.listNumero)
            {
                Resultado -= Numero;
            }
            this.listNumero.Clear();
            return Resultado;
        }
        public double Multiplicar()
        {
            double Resultado = 1;
            foreach (double Numero in this.listNumero)
            {
                Resultado *= Numero;
            }
            this.listNumero.Clear();
            return Resultado;
        }
        public double Dividir()
        {
            double Resultado = 0;
            foreach (double Numero in this.listNumero)
            {
                Resultado /= Numero;
            }
            this.listNumero.Clear();
            return Resultado;
        }
        public double Cubo()
        {
            double Resultado = 1;
            foreach (double Numero in this.listNumero)
            {
                Resultado = Numero * Numero * Numero;
            }
            this.listNumero.Clear();
            return Resultado;
        }
    }
}
