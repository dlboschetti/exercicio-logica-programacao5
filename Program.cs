using System;

namespace exercicio_logica_programacao5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Somar os dígitos de um número inteiro:

            //Faça um programa para somar os dígitos de um inteiro que será informado pelo usuário, 
            //e sem utilizar recursos de string, ou seja, trabalhe apenas com tipos numéricos.

            //Por exemplo, imagine que o usuário informou o número 2015.Devemos então somar seus dígitos:

            //2 + 0 + 1 + 5

            //O resultado esperado para o número acima seria 8.

            Console.WriteLine("Favor informar valor:");
            int valor = Convert.ToInt32(Console.ReadLine());
            int somaDig = 0;
            int resto = 0;

            while (valor > 0)
            {
                resto = valor % 10;
                valor = (valor - resto) / 10;
                somaDig = somaDig + resto;
            }

            Console.WriteLine($"A soma dos digitos é igual a : {somaDig} .");


        }
    }
}
