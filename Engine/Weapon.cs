﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
   public class Weapon : Item
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string NamePlural { get; set; }
        public int MinimumDamage { get; set; }
        public int MaximumDamage { get; set; }

        public Weapon(int id, string name, string plural, int minimumDamage, int maximumDamage) : base(id, name, plural)
        {
            MinimumDamage = minimumDamage;
            MaximumDamage = maximumDamage;
        }
        

    }
}
