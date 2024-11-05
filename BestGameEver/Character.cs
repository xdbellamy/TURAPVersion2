using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestGameEver
{
    internal abstract class Character
    {
        public int ID { get; protected set; }

        public string? Name { get; protected set; }

        public int Health { get; protected set; }

        public int Level { get; protected set; }

        public Weapon CurrentWeapon { get; protected set; }

    }

}
