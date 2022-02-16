namespace DesafioPOO.src.Entities
{
    public abstract class Hero
    {
         public Hero(string Name, string HeroType, int Level, int HealthPoits, int MagicPoits)
        {
            this.Name = Name;
            this.HeroType = HeroType;
            this.Level = Level;
            this.HealthPoits = HealthPoits;
            this.MagicPoits = MagicPoits;

        }
    public Hero (){
        }


        public string Name;

        public string HeroType;

        public int Level;

        public int HealthPoits;

        public int MagicPoits;  



        public override string ToString(){
            return"Meu nome é! " + this.Name + " e eu sou... " + " " + this.HeroType +" " + " Nivel:" + " " + this.Level + " Barra de vida:" + " " + this.HealthPoits + " Nivel de Magia:" + " " + this.MagicPoits ;

        }

        public virtual string Attack(){
            return this.Name + " Atacou com sua espada.";
        }

    }
}