using SqlDeArquivo.Services;
using System;

namespace SqlDeArquivo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Terminal iniciado");
            var gerenciador = new GerenciadorDeArquivos();
            
            do
            {
                Console.WriteLine("...");
                var entrada = Console.ReadLine();

                var retornoConsulta = gerenciador.Consultar();
                
                foreach (var retorno in retornoConsulta){
                    Console.WriteLine(retorno);
                }

            } while (true);

        }
    }
}
