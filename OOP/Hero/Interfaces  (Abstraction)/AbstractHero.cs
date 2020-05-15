using System;

using module1.OOP.Gear;
using module1.OOP.Gear.Interfaces;

namespace module1.OOP
{
    public abstract class Character : ICharacter, IComparable
    {
        readonly string _charName;

        Bag<IItem> _bag;
        CharState _state;

        public CharState State
        {
            get => _state;

            set
            {
                if (value == CharState.Dead)
                    _state = value;
            }
        }

        public string Name => _charName;
        public Bag<IItem> Bag => _bag ??= new Bag<IItem>();

        public int Lvl { get; set; } = default;
        public int Health { get; set; } = 300;
        public double Attack { get; set; } = 10;
        public double MoveSpeed { get; set; } = 10;

        public Character() =>
            _state = CharState.Alive;

        public Character(string charName, Bag<IItem>? bag = default)
        {
            _charName = charName ??
                throw new ArgumentNullException(nameof(_charName), "Char name can`t be null");

            _bag = bag;

            _state = CharState.Alive;
        }

        public int CompareTo(object obj)
        {
            if (obj is Character c)
            {
                return obj is null
                        ? 1
                        : c.Lvl > Lvl
                            ? -1
                            : c.Lvl < Lvl
                                ? 1
                                : 0;
            }

            throw new ArgumentException(nameof(obj), $"Value hasn`t any relation with {nameof(Char)}");
        }
    }
}