
using AbstraindoWarrior.entities;

namespace AbstraindoWizard.entities
{
       public class Wizard : warrior
       {
           public Wizard(string name, int level, string herotype)
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
                     return this.name + " lançou magia fraca";
                   }
                   else
                   {
                     return this.name + " lançou magia com super bônus de: " + Bonus;
                   }
                     
            }
       } 
    
}