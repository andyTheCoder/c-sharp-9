namespace c_sharp_9
{
    class Program
    {
        // ref:
        // https://channel9.msdn.com/Shows/On-NET/C-9-Language-Features?ocid=player
        // https://devblogs.microsoft.com/dotnet/c-9-0-on-the-record/

        static void Main(string[] args)
        {
            var p1 = new Person("fred", "smith");
            var fn = p1.FirstName;
            //p1.FirstName = "andy"; // --> error, readonly init

            // Can create a new object setting some props: 'with' keyword
            var p1new = p1 with { FirstName = "andy" };


            var p2 = new Person2 { FirstName = "fred", LastName = "smith" };
            //p2.FirstName = "dd";// --> error, readonly init


            var p3 = new Person3 { FirstName = "fred", LastName = "smith" };
            p3.FirstName = "andy";
        }

        // immutable: has constructor & readonly props
        public record Person(string FirstName, string LastName);

        // immutable: props are readonly & settable using object initializers
        public record Person2
        {
            public string FirstName { get; init; }
            public string LastName { get; init; }
        }

        // just like a class: mutable
        public record Person3
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
        }

    }

}