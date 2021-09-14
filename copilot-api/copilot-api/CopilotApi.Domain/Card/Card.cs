namespace CopilotApi.Domain
{
    public class Card
    {
        public int Id { get; }
        public string Name { get; }
        public string AbilityName { get; }
        public string Effect { get; }
        public AxieType AxieType { get; }
        public BodyPart BodyPart { get; }
        public int EnergyCost { get; }
        public int Damage { get; }
        public int Shield { get; }
        public Buff Buff { get; }
        public Debuff Debuff { get; }

        public Card(
            int id,
            string name,
            string abilityName,
            string effect,
            AxieType axieType,
            BodyPart bodyPart,
            int energyCost,
            int damage,
            int shield,
            Buff buff,
            Debuff debuff)
        {
            Id = id;
            Name = name;
            AbilityName = abilityName;
            Effect = effect;
            AxieType = axieType;
            BodyPart = bodyPart;
            EnergyCost = energyCost;
            Damage = damage;
            Shield = shield;
            Buff = buff;
            Debuff = debuff;
        }
    }
}
