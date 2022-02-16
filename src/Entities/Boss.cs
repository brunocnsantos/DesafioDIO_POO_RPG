namespace DesafioPOO.src.Entities
{
    public class Boss : Hero
    {
          public Boss(string Name, string HeroType, int Level,int HealthPoits,int MagicPoits)
        {
            this.Name = Name;
            this.HeroType = HeroType;
            this.Level = Level;
            this.HealthPoits = HealthPoits;
            this.MagicPoits = MagicPoits;

        }
    }
}