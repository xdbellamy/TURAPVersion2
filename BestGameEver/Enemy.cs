using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestGameEver
{
    internal class Enemy : Character
    {
        public int XPOnDrop { get; private set; }

        public Enemy(int iD, string name, int health, int level, Weapon currentWeapon, int xPOnDrop)
        {
            ID = iD;
            Name = name;
            Health = health;
            Level = level;
            CurrentWeapon = currentWeapon;
            XPOnDrop = xPOnDrop;
        }

        public int ShootPlayer(Player playerOne)
        {
            Random rng = new Random();
            int chanceOfHitting = rng.Next(1, 100);

            if (chanceOfHitting > CurrentWeapon.Accuracy)
            {
                Console.WriteLine("The enemy missed!");
                Weapon.EnemyWeaponDurabilityLoss(CurrentWeapon); //Takes the current weapon and decreasing it by 10
                return 0;
            }
            else
            {
                Console.WriteLine($"The enemy shot at you! Lost {CurrentWeapon.Damage} HP!");
                Weapon.EnemyWeaponDurabilityLoss(CurrentWeapon); //Takes the current weapon and decreasing it by 10
                return CurrentWeapon.Damage;
            }
        }

        public void ReduceEnemyHP(Enemy enemy, int enemyDamageTaken)
        {
            enemy.Health -= enemyDamageTaken;
        }
    }
}
