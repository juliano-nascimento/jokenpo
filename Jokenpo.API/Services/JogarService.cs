using System.Linq;
using System.Threading.Tasks;
using Jokenpo.API.Services.Interfaces;
using Jokenpo.API.Enum;
using System;
using Jokenpo.API.Business;
using Jokenpo.API.Repositories.Interfaces;
using Jokenpo.API.Entities;

namespace Jokenpo.API.Services
{
    public class JogarService : IJogarService
    {
        private readonly IJokenpoRepository<Ranking> _repository;
        private readonly ValidacaoJogada _validacao;
         private readonly ValidacaoVencedor _vencedor;

        public JogarService(IJokenpoRepository<Ranking> repository)
        {
            _repository = repository;
            _validacao = new ValidacaoJogada();
            _vencedor = new ValidacaoVencedor();   
        }      
              
        public string NovoJogo(int escolha)
        {
            int[] opcoes = new int[] {OpcoesEscolha.pedra.GetHashCode(), OpcoesEscolha.papel.GetHashCode(), OpcoesEscolha.tesoura.GetHashCode()};
            string result = string.Empty;
            
            if(!opcoes.Contains(escolha)){
                return  result = "Opção inválida! Escolha entre Papel, Pedra ou Tesoura";                
            }
            else{
                var randon = new Random();
                var index = randon.Next(opcoes.Count());

                var resultado = _validacao.CalcularVencedor(escolha, opcoes[index]);

                result = _vencedor.RetornaVencedor(escolha, opcoes[index], resultado);

                    var ranking = new Ranking(){
                        Vencedor = result,
                        EscolhaJogador = escolha,
                        DscEscolhaJogador = ((OpcoesEscolha)escolha).ToString(),
                        EscolhaMaquina = opcoes[index],
                        DscEscolhaMaquina = ((OpcoesEscolha)opcoes[index]).ToString()
                    };

                _repository.Inserir(ranking);

            }

            return result;
        }
    }
}