namespace DesafioPOO.src.Entities
{
    public class BlackWizard : Hero
    {
        public BlackWizard(string Name, string HeroType, int Level,int HealthPoits,int MagicPoits)
        {
            this.Name = Name;
            this.HeroType = HeroType;
            this.Level = Level;
            this.HealthPoits = HealthPoits;
            this.MagicPoits = MagicPoits;

        }
        public override string Attack(){
            return this.Name + " Evocou os zumbis de seus túmulos para atacar o Boss.";
        }

        public string Attack(int Bonus){

            if (Bonus > 6){
                return this.Name + " Lançou magia super efetiva com bonus de" + Bonus;
            }else{
                return this.Name + " Lançou magia com força fraca com bonus de" + Bonus;
            }
        }

    }
}