using System.Linq;
using module1.OOP.Gear;
using module1.OOP.Gear.Interfaces;

namespace module1.OOP
{
    public class HeroWarrior : Character, IWarrior
    {
        public string ClassName => "Warrior";

        public void ActivateBerserk() =>
            Attack += 20;

        public HeroWarrior()
            : base()
        { }

        public HeroWarrior(string charName, Bag<IItem>? bag = default)
            : base(charName, bag)
        { }
    }

    public class HeroArcher : Character, IArcher
    {
        public string ClassName => "Archer";

        public void ActivateWindWalk() =>
            MoveSpeed += 30;

        public HeroArcher()
            : base()
        { }

        public HeroArcher(string charName, Bag<IItem>? bag = default)
            : base(charName, bag)
        { }
    }
}