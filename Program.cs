using System;

namespace ExemploInstrucaoGoto
{
    class Program
    {
        static void Main(string[] args)
        {   
            string nome;
            string continuar;

            Inicio:
            Console.WriteLine("\n#############################");
            Console.Write("Qual seu nome: ");
            nome = Console.ReadLine();

            Console.WriteLine($"Olá {nome}");
            
            Console.WriteLine("Deseja continuar: Sim[s]  Não[n]");
            continuar = Console.ReadLine();

            if(continuar == "s")
            {
                goto Inicio;
            }
            
        }
    }
}
