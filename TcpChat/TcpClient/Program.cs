using System;
using System.Net.Sockets;
using System.Text;

namespace ClientTcp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iniciando Client!");

            var client = new TcpClient();

            try
            {
                Console.WriteLine("Iniciando conexão");
                client.Connect("127.0.0.1", 8080);
                Console.WriteLine("Conectado");
                client.Client.Send(Encoding.UTF8.GetBytes("Conexão iniciada, mensagem vinda do client"));
                
                var mensagem = "";
                do
                {
                    Console.WriteLine("Digite a proxima mensagem");
                    mensagem = Console.ReadLine();
                    client.Client.Send(Encoding.UTF8.GetBytes(mensagem));
                    var mensagemByteArray = new byte[1024];
                    client.Client.Receive(mensagemByteArray);
                    Console.WriteLine("Mensagem recebida:" + Encoding.UTF8.GetString(mensagemByteArray));

                } while (mensagem != "0");
                
            }
            catch(Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            finally
            {
                client.Close();
            }

            Console.WriteLine("Fim");
        }
    }
}
