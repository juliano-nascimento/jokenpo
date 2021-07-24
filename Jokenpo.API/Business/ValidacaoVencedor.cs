namespace Jokenpo.API.Business
{
    public class ValidacaoVencedor
    {
        public string RetornaVencedor(int jogador1, int maquina, int resultado){
            string vencedor = string.Empty;

            if(resultado == jogador1)
               return  vencedor = "Você venceu";
            else if(resultado == maquina)
               return vencedor = "A maquina venceu";
            else
               return vencedor = "Empate";
        }
    }
}