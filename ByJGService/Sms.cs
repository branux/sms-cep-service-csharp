using System.Collections.Generic;
using ByJGService.Struct;

namespace ByJGService
{
    public class Sms : Base
    {
        private readonly string _usuario;
        private readonly string _senha;
        
        public Sms(string usuario, string senha) : base("sms")
        {
            this._usuario = usuario;
            this._senha = senha;
        }

        public string EnviarSms(string ddd, string celular, string mensagem)
        {
            var args = new Dictionary<string, string>
            {
                {"usuario", _usuario},
                {"senha", _senha},
                {"ddd", ddd},
                {"celular", celular},
                {"mensagem", mensagem}
            };

            return Get("enviarSms", args)[0];
        }
        
        public IEnumerable<Creditos> Creditos()
        {
            var args = new Dictionary<string, string>
            {
                {"usuario", _usuario},
                {"senha", _senha}
            };

            var result = Get("creditos", args);
            var resultCreditos = new List<Creditos>();
            foreach (var item in result)
            {
                var props = item.Split(',');
                resultCreditos.Add(new Creditos(props[0], props[1]));
            }

            return resultCreditos;
        }
    }
}