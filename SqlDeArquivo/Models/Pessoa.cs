namespace SqlDeArquivo.Models
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Profissao { get; set; }

        public override string ToString()
        {
            return $"Nome: {Nome} {Sobrenome} Profissão: {Profissao}";
        }
    }
}
