using System;

namespace ProgCalculadora1
{
    class Program
    {
        
        static void Main(string[] args)
        {

            Calculadora objCalculadora = new Calculadora();
            System.Console.Write("\n\n    MENU\n    01 - Realizar Adição\n    02 - Realizar Subtração\n    03 - Realizar Multiplicação\n    04 - Realizar Divisão\n    05 - Elevar ao Cubo\n    >: ");

            objCalculadora.Numero = (Convert.ToInt32(System.Console.ReadLine()));
            if (objCalculadora.Numero >= 1 && objCalculadora.Numero <= 5)
            {
                System.Console.Write("\n\n    Quantos números deseja trabalhar? Digite aqui: ");
                objCalculadora.Referencia = (Convert.ToInt32(System.Console.ReadLine()));
                System.Console.Write("\n");
                if (objCalculadora.Numero == 1)
                {
                    for (int i = 0; i < objCalculadora.Referencia; i++)
                    {
                        Console.Write("    Digite um número aqui para realizar a adição: "); objCalculadora.addNumero(Convert.ToDouble(System.Console.ReadLine()));
                    }
                    Console.Write("\n    Resultado = " + objCalculadora.Somar());
                }
                else if (objCalculadora.Numero == 2)
                {
                    for (int i = 0; i < objCalculadora.Referencia; i++)
                    {
                        Console.Write("    Digite um número aqui para realizar a subtração: ");
                        objCalculadora.addNumero(Convert.ToDouble(System.Console.ReadLine()));
                    }
                    Console.Write("\n    Resultado = " + objCalculadora.Subtrair());
                }
                else if (objCalculadora.Numero == 3)
                {
                    for (int i = 0; i < objCalculadora.Referencia; i++)
                    {
                        Console.Write("    Digite um número aqui para realizar a multiplicação: ");
                        objCalculadora.addNumero(Convert.ToDouble(System.Console.ReadLine()));
                    }
                    Console.Write("\n    Resultado = " + objCalculadora.Multiplicar());
                }
                else if (objCalculadora.Numero == 4)
                {
                    for (int i = 0; i < objCalculadora.Referencia; i++)
                    {
                        Console.Write("    Digite um número aqui para realizar a divisão: ");
                        objCalculadora.addNumero(Convert.ToDouble(System.Console.ReadLine()));
                    }
                    Console.Write("\n    Resultado = " + objCalculadora.Dividir());
                }
                else if (objCalculadora.Numero == 5)
                {
                    Console.Write("\n    Digite um número aqui para elevá-lo ao cubo: ");
                    objCalculadora.addNumero(Convert.ToDouble(System.Console.ReadLine()));
                    Console.Write("\n    Resultado = " + objCalculadora.Cubo());
                }
                System.Console.ReadKey();
            }

        }
    }
}