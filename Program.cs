using System;

namespace Finaltestcode
{
    public class Program
    {
        public static void Main()
        {

            Adult[] person = new Adult[] {new Adult(), new Child()};

            foreach (Adult a in person)
            {
                a.Name();
            }
        }
    }

    public class Adult
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public virtual void Name()
        {
            FirstName = "AdultFirstNAme";
            LastName = "AdultLastNAme";
            Console.WriteLine(FirstName);
            Console.WriteLine(LastName);
        }
    }

    class Child : Adult
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public override void Name()
        {
            FirstName = "ChildFirstNAme";
            LastName = "ChildLastNAme";
            Console.WriteLine(FirstName);
            Console.WriteLine(LastName);
        }
    }
}





