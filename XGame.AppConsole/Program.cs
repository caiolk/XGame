using System;
using System.Linq;
using XGame.Domain.Arguments.Jogador;
using XGame.Domain.Services;

namespace XGame.AppConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iniciando...");
            var service = new ServiceJogador();
            Console.WriteLine("Criei Instancia do Servico...");

            var result = service.ListarJogador();
/*
            AutenticarJogadorRequest AutenticarRequest = new AutenticarJogadorRequest();
            Console.WriteLine("Criei instancia do meu objeto Request...");
            AutenticarRequest.Email = "caio.kozano@live.com";
            AutenticarRequest.Senha = "1263456789";
            

            var Adicionarrequest = new AdicionarJogadorRequest()
            {
                Email = "caio.kozano@live.com",
                PrimeiroNome =  "Caio",
                UltimoNome = "Kozano",
                Senha = "123456"
            };
            var Adicionarresponse = service.AdicionarJogador(Adicionarrequest);
            var AutenticarResponse = service.AutenticarJogador(AutenticarRequest);

            Console.WriteLine("Serviço é valido -> " + service.IsValid());
            service.Notifications.ToList().ForEach(x => { 
                Console.WriteLine(x.Message);
            });*/


            Console.ReadKey();

        }
    }
}
