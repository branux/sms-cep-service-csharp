using System;
using ByJGService;

namespace Example
{
    internal static class Program
    {
        private const string Usuario = "seuusario";
        private const string Senha = "suasenha";
        
        public static void Main(string[] args)
        {
            var sms = new Sms(Usuario, Senha);

            var resultCreditos = sms.Creditos();

            Console.WriteLine("Creditos: ");
            Console.WriteLine("---------------------------------------");
            foreach (var credito in resultCreditos)
            {
                Console.WriteLine("Disponivel: " + credito.Disponivel);
                Console.WriteLine("Validade: " + credito.Validade);
            }
            Console.WriteLine();

            var resultSms = sms.EnviarSms("21", "123456789", "Essa é a mensagem");
            Console.WriteLine("Result SMS: ");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine(resultSms);
            Console.WriteLine();

            
            var cep = new Cep(Usuario, Senha);
            
            var resultCep = cep.ObterLogradouro("20090-000");
            Console.WriteLine("Result Obter Logradouro: ");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine(string.Join(",", resultCep.ToString()));
            Console.WriteLine();

            var resultLogradouro = cep.ObterCep("Rio Branco", "Rio de Janeiro", "RJ");
            Console.WriteLine("Result Obter Logradouro: ");
            Console.WriteLine("---------------------------------------");
            foreach (var logradouros in resultLogradouro)
            {
                Console.WriteLine(logradouros.ToString());
            }
            Console.WriteLine();

        }
    }
}