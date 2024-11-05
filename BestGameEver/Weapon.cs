using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestGameEver
{
    internal class Weapon
    {
        public int WeaponID { get; private set; }

        public string WeaponName { get; private set; }

        public string WeaponType { get; private set; }

        public int Damage { get; private set; }

        public int Accuracy { get; private set; }

        public int Durability { get; private set; }

        public Weapon(int weaponID, string weaponName, string weaponType, int damage, int accuracy, int durability)
        {
            WeaponID = weaponID;
            WeaponName = weaponName;
            WeaponType = weaponType;
            Damage = damage;
            Accuracy = accuracy;
            Durability = durability;

        }
        public Weapon()
        {

        }

        public static void PlayerWeaponDurabilityLoss(Weapon player)
        {
            player.Durability -= 10;
        }

        public static void EnemyWeaponDurabilityLoss(Weapon enemy) 
        {
            enemy.Durability -= 10;
        }
    }
}
