using System.ComponentModel;

namespace CopilotApi.Domain
{
    public enum Debuff
    {
        None,
        [Description("O próximo ataque falha / O próximo ataque que chega ignora os escudos. Fica até a próxima ação.")]
        Stun,
        [Description("A prioridade do alvo muda para o Axie afetado para a próxima rodada. (taunt). Por um tempo determinado.")]
        Aroma,
        [Description("Axie afetado não pode entrar em last stand. Por um tempo determinado.")]
        Chill,
        [Description("Axie afetado não pode atacar. Por um tempo determinado.")]
        Fear,
        [Description("O escudo recebe o dobro do dano do próximo ataque. Por um tempo determinado.")]
        Fragile,
        [Description("Axie afetado não pode realizar acertos críticos na próxima rodada. Por um tempo determinado.")]
        Jinx,
        [Description("O próximo golpe neste Axie é sempre um golpe crítico. Fica até ser atacado.")]
        Lethal,
        [Description("Até a remoção, o Axie afetado perde 3 HP para cada ação. Pode empilhar.")]
        Poison,
        [Description("O próximo ataque a este Axie ignora os escudos. Fica até o Axie tentar atacar.")]
        Sleep,
        [Description("Axie é ignorado quando há ao menos outro na equipe. Por um tempo determinado.")]
        Stench,
        [Description("Diminui a velocidade dos Axies em 20%. Por um tempo determinado. Pode empilhar.")]
        SpeedDown,
        [Description("Diminui o moral do Axies em 20%. Por um tempo determinado. Pode empilhar.")]
        MoraleDown,
        [Description("Diminui o ataque do Axie em 20%. Fica até o próximo ataque. Pode empilhar.")]
        AttackDown,
    }
}
