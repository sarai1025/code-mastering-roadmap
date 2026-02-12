using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeMembers
{
    public class Fields
    {
        public const double Pi = 3.1416;
        public readonly string Name;
        private bool Available;

        public Fields(string name)
        {
            Name = name;
            Available = true;
        }

    }

    public class  FieldsExample
    {
        public static void Main()
        {
            Fields FieldClass = new("Radius");

            Console.WriteLine(Fields.Pi);
            Console.WriteLine(FieldClass.Name);
        }
    }
}
