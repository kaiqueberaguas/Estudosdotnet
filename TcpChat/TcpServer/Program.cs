using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace TcpServer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var ipAdress = IPAddress.Parse("127.0.0.1");
            var server = new TcpListener(ipAdress, 8080);
            try
            {
                server.Start();
   
                    Console.WriteLine("Esperando conexão");
                    
                    var client = server.AcceptTcpClient();
                while (true)
                {
                    var mensagem = new byte[1024];
                    client.Client.Receive(mensagem);
                    Console.WriteLine(Encoding.UTF8.GetString(mensagem));
                    client.Client.Send(Encoding.UTF8.GetBytes("Mensagem recebida com sucesso"));
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            finally
            {
                server.Stop();
            }
            Console.WriteLine("Fim");
        }
    }
}
