using module1.OOP.Gear.Interfaces;

namespace module1.OOP.Gear
{
    public class Weapon : IItem
    {
        readonly int _weight, _damage;
        readonly string _name;

        public override int Weight => _weight;
        public override string Name => _name;
        public int Damage => _damage;

        public Weapon(string name, int weight, int damage)
        {
            _name = name ?? "[No name]";
            _weight = weight;
            _damage = damage;
        }
    }
}