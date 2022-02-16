namespace DesafioPOO.src.Entities
{
    public class Knight : Hero
    {
          public Knight(string Name, string HeroType, int Level,int HealthPoits,int MagicPoits)
        {
            this.Name = Name;
            this.HeroType = HeroType;
            this.Level = Level;
            this.HealthPoits = HealthPoits;
            this.MagicPoits = MagicPoits;

        }
    }
}