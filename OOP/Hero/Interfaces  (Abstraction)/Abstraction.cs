using System;

namespace module1.OOP
{
    public enum CharState { Alive, Dead }

    internal interface IClass
    {
        string ClassName { get; }
    }

    internal interface ICharacter
    {
        string Name { get; }

        int Lvl { get; set; }
        int Health { get; set; }
        double Attack { get; set; }
        double MoveSpeed { get; set; }
    }

    internal interface IArcher : IClass
    {
        void ActivateWindWalk();
    }

    internal interface IWarrior : IClass
    {
        void ActivateBerserk();
    }
}