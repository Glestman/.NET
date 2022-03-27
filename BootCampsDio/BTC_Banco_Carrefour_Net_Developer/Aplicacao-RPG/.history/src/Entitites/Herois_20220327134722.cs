namespace Aplicacao_RPG.src.Entitites
{
    public class Herois
    {
        public Herois(string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;

        }
        public Herois()
        {

        }
        public string Name;
        public int Level;
        public string HeroType;

        public override string ToString()
        {
            return this.Name;

        }
        public string Attack(){
            return this.Name + " Atacou com sua espada ";
        }
 
    }
}