﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Krapula
{
    public class Character
    {
        public string Name { get; set; }
        public int Gold { get; set; }
        public int Health { get; set; }
        public int MaxHealth { get; set; }
        public Weapon WeaponEquipped { get; set; }
        public Armor ClothesEquipped { get; set; }
        public int Exp { get; set; }

        public Character()
        {
            Random rand = new Random(DateTime.Now.Millisecond);
            Name = Utilities.NameGenerator("adjectives", "professions", "names");
            Gold = rand.Next(100);
            MaxHealth = rand.Next(30);
            Health = MaxHealth;
            WeaponEquipped = new Weapon();
            ClothesEquipped = new Armor();
            Exp = rand.Next(100);
        }
    }
}
