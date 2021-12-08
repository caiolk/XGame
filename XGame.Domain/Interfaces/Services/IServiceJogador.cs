using System;
using System.Collections.Generic;
using XGame.Domain.Arguments.Jogador;
using XGame.Domain.Interfaces.Arguments.Base;
using XGame.Domain.ValueObjects;

namespace XGame.Domain.Interfaces.Services
{
    public interface IServiceJogador
    {
        AutenticarJogadorResponse AutenticarJogador(AutenticarJogadorRequest request);
        AdicionarJogadorResponse AdicionarJogador(AdicionarJogadorRequest request);
        AlterarJogadorResponse AlterarJogador(AlterarJogadorRequest request);
        IEnumerable<JogadorResponse> ListarJogador();
        ResponseBase ExcluirJogador(Guid id);
    }
}
