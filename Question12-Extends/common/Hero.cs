using common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Question12_Extends.common
{
    public class Hero: Character
    {
        public Hero(int hp=25, int power=10, int endurance=7) : base(hp, power, endurance)
        {
        }
    }
}
