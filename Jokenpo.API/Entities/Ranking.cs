using Jokenpo.API.Entities.Base;

namespace Jokenpo.API.Entities
{
    public class Ranking : Entity
    {
        public string Vencedor { get; set; }
        public int EscolhaJogador { get; set; }
        public string DscEscolhaJogador { get; set; }
        public int EscolhaMaquina { get; set; }
        public string DscEscolhaMaquina { get; set; }
    }
}