namespace Aplicacao_RPG.src.Entitites
{
    public class Wizard : Herois
    {
        public Wizard(string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }
        public override string Attack()
        {
            return this.Name + " Lançou mágia ";
        }
        public string Attack(int Bonus)
        {
            if (Bonus > 6)
            {
                return this.Name + " Lançou mágia super efetiva com bonus de " + Bonus;
            }
            else
            {
                return this.Name + " Lançou mágia com pouca efetividade " + Bonus;
            }

        }
    }
}