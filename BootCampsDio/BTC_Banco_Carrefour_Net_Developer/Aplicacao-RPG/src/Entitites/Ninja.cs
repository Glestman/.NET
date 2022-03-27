namespace Aplicacao_RPG.src.Entitites
{
    public class Ninja : Herois
    {
        public Ninja(string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }
         public override string Attack()
        {
            return this.Name + " Atacou com sua adaga ";
        }
    }
}