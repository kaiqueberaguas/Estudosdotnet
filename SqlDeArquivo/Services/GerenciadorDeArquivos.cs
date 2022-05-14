using SqlDeArquivo.Models;
using System.Collections.Generic;
using System.Linq;

namespace SqlDeArquivo.Services
{
    public class GerenciadorDeArquivos
    {
        private IDictionary<int, Pessoa> pessoas = new Dictionary<int, Pessoa>();

        public GerenciadorDeArquivos()
        {
            pessoas.Add(0, new Pessoa()
            {
                Nome = "Oswaldo",Sobrenome = "Martins",Profissao = "Analista do mercado imobiliario"
            });
            pessoas.Add(1, new Pessoa()
            {
                Nome = "Marcos",
                Sobrenome = "Ramagem",
                Profissao = "Pedreiro"
            }) ;
            pessoas.Add(2, new Pessoa()
            {
                Nome = "Lucas",
                Sobrenome = "Jacunda",
                Profissao = "Pescador"
            });
            pessoas.Add(3, new Pessoa()
            {
                Nome = "Jose",
                Sobrenome = "Silva",
                Profissao = "Politico Corrupto"
            });
            pessoas.Add(4, new Pessoa()
            {
                Nome = "Mirian",
                Sobrenome = "Alckimit",
                Profissao = "Comentarias de futebol"
            });
        }

        public List<string> Consultar()
        {
            var registros = new List<string>(); 
            foreach(var pessoa in pessoas)
            {
                registros.Add(pessoa.ToString());
            }
            return registros;
        }

    }
}
