using AbstraindoWarrior.entities;

namespace AbstraindoKnight.entities
{
   
        public class Knight : warrior
       {
           public Knight(string name, int level, string herotype)
           {
            this.name = name;
            this.level = level;
            this.herotype = herotype; 
           }
           
          public string Attack(int Bonus)
            {
                   Bonus = Bonus++;
                   if (Bonus < 6)
                   {
                     return this.name + " atacou fraco com arco e flecha";
                   }
                   else
                   {
                     return this.name + " super atacou com arco e fecha com bônus de: " + Bonus;
                   }
                     
            }
            
       } 
    
}