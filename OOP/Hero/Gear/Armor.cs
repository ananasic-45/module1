using module1.OOP.Gear.Interfaces;

namespace module1.OOP.Gear
{
    public class Armor : IItem
    {
        readonly int _weight;
        readonly string _name;

        public override int Weight => _weight;
        public override string Name => _name;

        public Armor(string name, int weight)
        {
            _name = name ?? "No name";
            _weight = weight;
        }
    }
}