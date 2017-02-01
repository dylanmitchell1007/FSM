using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{

    public enum PlayerState
    {
        INIT,
        IDLE,
        WALK,
        RUN,
    }






    /// <summary>
    /// This is the inteface Attemp 1.
    /// Ninja vs Zombie.
    /// </summary>
public interface IDamageable
    {
        void TakeDamage()



    }
    public interface IDamage
    {
      


    }

    class Ninja : IDamageable
    {
        public Ninja(int Health, int Attack, string name)
        {
            name = null;
            Health = 100;
            Attack = 15;
        }

        public void TakeDamage()
        {
            throw new NotImplementedException();
        }
    }
   class Zombie : IDamageable
        {
            public Zombie(int Health, int Attack,string name)
            {
                name = null;
                Health = 100;
                Attack = 15;
            }



    }

    
    class Attack : IDamage
    {

        public Attack(int cost, int amount)
        {
            this.Cost = cost;
            this.Amount = amount;

        }
        public int Amount
        {
            get
            {
                   
            }
            set
            {

            }
        }
        public int Cost
        {
            get
            {

            }
            set
            {

            }


        }

    }

}
       