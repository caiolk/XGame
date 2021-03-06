using prmToolkit.NotificationPattern;
using prmToolkit.NotificationPattern.Extensions;
using XGame.Domain.Resources;

namespace XGame.Domain.ValueObjects
{
    public class Nome : Notifiable
    {
        public Nome(string primeiroNome, string ultimoNome)
        {
            PrimeiroNome = primeiroNome;
            UltimoNome = ultimoNome;

            new AddNotifications<Nome>(this)
                .IfNullOrInvalidLength(x => x.PrimeiroNome, 3,50, Message.X0_E_OBRIGATORIO_E_DEVE_CONTER_X1_CARACTERES.ToFormat("Primeiro nome","3","50"))
                .IfNullOrInvalidLength(x => x.UltimoNome, 3, 50, Message.X0_E_OBRIGATORIO_E_DEVE_CONTER_X1_CARACTERES.ToFormat("Ultimo nome", "3", "50"));
        }

        public string PrimeiroNome { get; private set; }
        public string UltimoNome { get; private set; }
    }
}
