namespace AbstraindoWarrior.entities
{
    public class warrior
    {
        public string name;
        public int level;
        public string herotype;

        public warrior(string name, int level, string herotype)
        {
        this.name = name;
        this.level = level;
        this.herotype = herotype;    
        }
        public warrior()
        {
           
        }

        public override string ToString()
        {
            return this.name + " " + this.level + " " + this.herotype;  
        }

        public string Attack(int Bonus)
            {
                   Bonus = Bonus++;
                   if (Bonus < 6)
                   {
                     return this.name + " atacou fraco com a sua espada";
                   }
                   else
                   {
                     return this.name + " super atacou com a sua espada com bônus de: " + Bonus;
                   }
                     
            }

    }
}