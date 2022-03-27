namespace Aplicacao_RPG.src.Entitites
{
    public class Herois
    {
        public Herois(string Name,int Level,string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            
        }
        public string Name;
        public int Level;
        public string HeroType;

    }
}