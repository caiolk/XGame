using System;
using System.Collections.Generic;
using System.Linq;
using XGame.Domain.Entities;
using XGame.Domain.Interfaces.Repositories;
using XGame.Infra.Persistence.Repositories.Base;

namespace XGame.Infra.Persistence.Repositories
{
    public class RepositoryJogador : RepositoryBase<Jogador, Guid>, IRepositoryJogador
    {
        protected readonly XGameContext _context;

        public RepositoryJogador(XGameContext context) : base(context)
        {
            _context = context;
        }

/*
        public Jogador AutenticarJogador(string email, string senha)
        {
            throw new NotImplementedException();
        }
        public void ALterarJogador(Jogador jogador)
        {
            throw new NotImplementedException();
        }
        public IEnumerable<Jogador> ListarJogador()
        {
            return _context.Jogadores.ToList();
        }

        public Jogador ObterJogadorPorId(Guid id)
        {
            return (Jogador)_context.Jogadores.Where(x => x.Id == id);
        }*/

       /* public int CalculaJogadores()
        {
            string nome = "Caio";
            string ultimoNome = "Kozano";
            string sexo = string.Empty;
            
            IQueryable<Jogador> jogadores = _context.Jogadores.AsNoTracking().AsQueryable();

            if (!string.IsNullOrEmpty(nome))
            {
                jogadores = jogadores.Where(x => x.Nome.PrimeiroNome.StartsWith(nome));
            }

            if (!string.IsNullOrEmpty(ultimoNome))
            {
                jogadores = jogadores.Where(x => x.Nome.UltimoNome.StartsWith(ultimoNome));
            }

          *//*  if (!string.IsNullOrEmpty(sexo))
            {
                jogadores = jogadores.Where(x => x.Nome.sexo.StartsWith(sexo));
            }*//*
            return jogadores.AsParallel().ToList().Count();

        */}
    }
}
