using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto105
{
    class Dado
    {
        private int valor;
        public int Valor
        {
            get
            {
                return valor;
            }
            private set
            {
                valor = value;
            }
        }
        private static Random aleatorio;
        public Dado()
        {
            aleatorio = new Random();
        }
        public void Tirar()
        {
            valor = aleatorio.Next(1, 7);
        }
        public void Imprimir()
        {
            Console.WriteLine("El valor del dado: " + valor);
        }

    }
    class JuegoDeDados
    {
        private Dado dado1, dado2, dado3;
        public JuegoDeDados()
        {
            dado1 = new Dado();
            dado2 = new Dado();
            dado3 = new Dado();
        }
        public void Jugar()
        {
            dado1.Tirar();
            dado2.Tirar();
            dado3.Tirar();
            dado1.Imprimir();
            dado2.Imprimir();
            dado3.Imprimir();
            if (dado1.Valor==dado2.Valor&&dado1.Valor==dado3.Valor)
            {
                Console.WriteLine("GANO");
            }
            else
            {
                Console.WriteLine("PERDIO");
            }
        }
        static void Main(string[] args)
        {
            JuegoDeDados juego1 = new JuegoDeDados();
            juego1.Jugar();
            Console.ReadKey();
        }
    }
}
