using common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Question12_Extends.common
{
    public class SuperHero:Hero
    {
        public Item item { get; set; }
        public override int Attack()
        {
            return base.Attack()+item.additionalDamage;
        }

    }
}
