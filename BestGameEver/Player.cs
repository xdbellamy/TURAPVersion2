using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestGameEver
{
    internal class Player : Character
    {
        public HP_Potion? HP_Potion { get; private set;}

        public Player(int playerID, string name, int health, int level, Weapon currentWeapon, HP_Potion hP_Potion)
        {
            ID = playerID;
            Name = name;
            Health = health;
            Level = level;
            CurrentWeapon = currentWeapon;
            HP_Potion = hP_Potion;
        }

        public Player(int playerID, string name, int health, int level, Weapon currentWeapon)
        {
            ID = playerID;
            Name = name;
            Health = health;
            Level = level;
            CurrentWeapon = currentWeapon;
            HP_Potion = null;
        }

        public int ShootEnemy(Enemy enemy)
        {
            Random rng = new Random();
            int chanceOfHitting = rng.Next(1, 100);

            if (chanceOfHitting < CurrentWeapon.Accuracy)
            {
                Console.WriteLine($"You shot at {enemy.Name} and you got him!");
                Weapon.PlayerWeaponDurabilityLoss(CurrentWeapon); //Takes the current weapon and decreasing it by 10
                return CurrentWeapon.Damage;
            }
            else
            {
                Console.WriteLine($"DAMN... you missed!");
                Weapon.PlayerWeaponDurabilityLoss(CurrentWeapon); //Takes the current weapon and decreasing it by 10
                return 0;
            }
        }

        public void ReduceHP(Player playerOne, int playerDamageTaken)
        {
            playerOne.Health -= playerDamageTaken;
        }

        public void IncreaseHP(int potency)
        {
            Health += potency;
        }

        public void ChangeWeapon()
        {
            var Weapon1 = new Weapon(101, "AK47", "Machine Gun", 40, 95, 100);
            var Weapon2 = new Weapon(102, "Desert Eagle", "Hand Gun", 50, 80, 100);
            Console.WriteLine($"Which weapon would you like to change to?" +
                $"\n press 1 for {Weapon1.WeaponName} or 2 for {Weapon2.WeaponName}");

            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                CurrentWeapon = Weapon1;
            }
            else if (choice == 2)
            {
                CurrentWeapon = Weapon2;
            }
            else
            {
                Console.WriteLine("You did not press 1 or 2, and will therefore not change weapon");
            }
        }

        public void AddPotionToPlayer(HP_Potion potion)
        {
            if (HP_Potion == null)
            {
                HP_Potion = potion;
            }
            else
            {
                Console.WriteLine("You can only carry one potion at a time");
            }
        }
    }
}
