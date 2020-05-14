namespace module1.Proporty
{
    public class ClassWithProporty
    {
        int _someInt;
        string _someStr;

        //classic prop
        public int SomeInt { get; set; } = default;

        // full prop
        public int SomeInt1
        {
            get
            {
                return _someInt;
            }
            set
            {
                if (_someInt != default(int))
                    _someInt = value;
            }
        }


        // #1 Shorthand
        public int SomeInt2 { get; set; }

        // #2 Shorthand

        public int SomeInt3
        {
            get => _someInt;
            set => _someInt = value;
        }


        // readonly prop
        public string SomeOnlyReadonlyStr { get; }
    }
}