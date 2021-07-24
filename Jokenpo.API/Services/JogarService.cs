using System.Linq;
using System.Threading.Tasks;
using Jokenpo.API.Services.Interfaces;
using Jokenpo.API.Enum;
using System;
using Jokenpo.API.Business;

namespace Jokenpo.API.Services
{
    public class JogarService : IJogarService
    {
        ValidacaoJogada validacao = new ValidacaoJogada();
        ValidacaoVencedor vencedor = new ValidacaoVencedor();        

        public string NovoJogo(int escolha)
        {
            int[] opcoes = new int[] {Opcoes.pedra.GetHashCode(), Opcoes.papel.GetHashCode(), Opcoes.tesoura.GetHashCode()};
            string result = string.Empty;
            
            if(!opcoes.Contains(escolha)){
                return  result = "Opção inválida! Escolha entre Papel, Pedra ou Tesoura";                
            }
            else{
                var randon = new Random();
                var index = randon.Next(opcoes.Count());

                var resultado = validacao.CalcularVencedor(escolha, opcoes[index]);

                result = vencedor.RetornaVencedor(escolha, opcoes[index], resultado);

            }

            return result;
        }
    }
}