namespace Jokenpo.API.Business
{
    public class ValidacaoJogada
    {
        public int CalcularVencedor(int jodador1, int maquina){
            
            if(jodador1 % 3 + 1 == maquina)
                return maquina;
            else if(maquina % 3 +1 == jodador1)
                return jodador1;
            else
                return 0;
        }
    }
}