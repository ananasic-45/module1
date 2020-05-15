using System;

namespace module1.OOP.Gear.Interfaces
{
    public abstract class IItem : IComparable
    {
        public abstract int Weight { get; }
        public abstract string Name { get; }

        public int CompareTo(object obj)
        {
            if (obj is IItem c)
            {
                return obj is null
                    ? 1
                    : c.Weight > Weight
                        ? -1
                        : c.Weight < Weight
                            ? 1
                            : 0;
            }

            throw new ArgumentException(nameof(obj), $"Value hasn`t any relation with {nameof(Char)}");
        }
    }
}