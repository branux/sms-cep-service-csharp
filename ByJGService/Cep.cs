using System.Collections.Generic;
using System.Linq;
using ByJGService.Struct;

namespace ByJGService
{
    public class Cep : Base
    {
        private readonly string _usuario;
        private readonly string _senha;
        
        public Cep(string usuario, string senha) : base("cep")
        {
            _usuario = usuario;
            _senha = senha;
        }

        public Logradouros ObterLogradouro(string cep)
        {
            var args = new Dictionary<string, string>
            {
                {"usuario", _usuario},
                {"senha", _senha},
                {"cep", cep}
            };

            var result = Get("obterLogradouroAuth", args)[0].Split(',');

            var logradouro = new Logradouros
            {
                Logradouro = result.ElementAtOrDefault(0),
                Bairro = result.ElementAtOrDefault(1),
                Cidade = result.ElementAtOrDefault(2),
                Uf = result.ElementAtOrDefault(3),
                Ibge = result.ElementAtOrDefault(4)
            };

            return logradouro;
        }
        
        public IEnumerable<Logradouros> ObterCep(string logradouro, string localidade, string uf)
        {
            var args = new Dictionary<string, string>
            {
                {"usuario", _usuario},
                {"senha", _senha},
                {"logradouro", logradouro},
                {"localidade", localidade},
                {"UF", uf}
            };
            
            var result = Get("obterCepAuth", args);
            var logradouros = new List<Logradouros>();

            foreach (var item in result)
            {
                var logradouroSplit = item.Split(',');
                var element = new Logradouros
                {
                    Logradouro = logradouroSplit.ElementAtOrDefault(0),
                    Bairro = logradouroSplit.ElementAtOrDefault(1),
                    Cidade = logradouroSplit.ElementAtOrDefault(2),
                    Uf = logradouroSplit.ElementAtOrDefault(3),
                    Ibge = logradouroSplit.ElementAtOrDefault(4)
                };
                
                logradouros.Add(element);
            }

            return logradouros;
        }
    }
}