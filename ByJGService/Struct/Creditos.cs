namespace ByJGService.Struct
{
    public struct Creditos
    {
        public Creditos(string disponivel, string validade)
        {
            Disponivel = disponivel;
            Validade = validade;
        }

        public string Disponivel { get; set; }

        public string Validade { get; set; }
    }
}