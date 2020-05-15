using System;
using System.Collections;
using System.Linq;
using module1.OOP;
using module1.OOP.Gear;
using module1.OOP.Gear.Interfaces;

namespace HelloApp
{

    class Program
    {
        static void Main(string[] args)
        {
            HeroArcher hero = new HeroArcher("Tom", new Bag<IItem>() { new Weapon("Stick", 22, 30), new Armor("Pants", 33) });

            foreach (var item in hero.Bag)
                System.Console.WriteLine(item.Name);
        }
    }
}