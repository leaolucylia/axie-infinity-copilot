﻿using System.ComponentModel;

namespace CopilotApi.Domain
{
    public enum Buff
    {
        None,
        [Description("Aumenta a velocidade dos Axies em 20%. Por um tempo determinado.")]
        SpeedUp,
        [Description("Aumenta a moral dos Axies em 20%. Por um tempo determinado.")]
        MoraleUp, 
        [Description("Aumenta o Ataque dos Axies em 20%. Fica até o próximo ataque.")]
        AttackUp,
    }
}
