namespace ByJGService.Struct
{
    public struct Logradouros
    {
        private string _logradouro;
        private string _bairro;
        private string _cidade;
        private string _uf;
        private string _ibge;

        public Logradouros(string logradouro, string bairro, string cidade, string uf, string ibge)
        {
            _logradouro = logradouro;
            _bairro = bairro;
            _cidade = cidade;
            _uf = uf;
            _ibge = ibge;
        }

        public string Logradouro
        {
            get => _logradouro;
            set => _logradouro = value != null ? value.Trim() : "";
        }

        public string Bairro
        {
            get => _bairro;
            set => _bairro = value != null ? value.Trim() : "";
        }

        public string Cidade
        {
            get => _cidade;
            set => _cidade = value != null ? value.Trim() : "";
        }

        public string Uf
        {
            get => _uf;
            set => _uf = value != null ? value.Trim() : "";
        }

        public string Ibge
        {
            get => _ibge;
            set => _ibge = value != null ? value.Trim() : "";
        }

        public override string ToString()
        {
            return $"{Logradouro},{Bairro},{Cidade},{Uf},{Ibge}";
        }
    }
}