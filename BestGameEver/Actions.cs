using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestGameEver
{
    internal class Actions
    {
        public static void Attack(Player player, Enemy enemy)
        {
            int enemyDamageTaken = player.ShootEnemy(enemy);
            enemy.ReduceEnemyHP(enemy, enemyDamageTaken);
            Console.WriteLine($"The enemy has {enemy.Health} HP left.");
        }

        public static void EnemyAttack(Player playerOne, Enemy enemy)
        {
            int playerDamageTaken = enemy.ShootPlayer(playerOne);
            playerOne.ReduceHP(playerOne, playerDamageTaken);
            Console.WriteLine($"You have {playerOne.Health} HP left.");
            Console.WriteLine();
        }

        public static void DrinkPotion(Player player)
        {
            player.IncreaseHP(player.HP_Potion.Potency);
        }

        public static void GetPotion(Player player)
        {
            HP_Potion potion = new HP_Potion(1, "Health Potion", 50, 1, 1);
            player.AddPotionToPlayer(potion);
        }

        public static void Menu(Player playerOne, Enemy enemy)
        {
            Console.WriteLine("Your turn. What do you do?!\n" +
            "1. Shoot him!\n" +
            "2. Drink potion!\n" +
            "3. Change weapon.\n" +
            "4. Aquire a new potion.\n" +
            "5. Look at your current weapon");

            string choice = Console.ReadLine();

            if (choice == "1") // Shoot him!
            {
                Actions.Attack(playerOne, enemy);
            }
            else if (choice == "2" && playerOne.HP_Potion != null) // Drink potion!
            {
                DrinkPotion(playerOne);
            }
            else if (choice == "3") // Change weapon!
            {
                playerOne.ChangeWeapon();
            }
            else if(choice == "4")
            {
                Actions.GetPotion(playerOne);
            }
            else if (choice == "5")
            {
                Console.WriteLine(playerOne.CurrentWeapon.WeaponName);
            }

            Console.WriteLine();
        }
    }
}
