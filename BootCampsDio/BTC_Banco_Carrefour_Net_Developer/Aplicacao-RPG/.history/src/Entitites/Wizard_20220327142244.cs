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
        public  string Attack(int Bonus)
        {
            return this.Name + " Lançou mágia " + Bonus;
        }
    }
}