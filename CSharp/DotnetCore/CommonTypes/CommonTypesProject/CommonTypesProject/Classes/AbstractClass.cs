using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonTypesProject.Classes
{
    public abstract class AbstractClass1
    {
        public abstract void Method1(); //abstracts methods should be declare within abstract class
                                        //Methods not implemented must have declared as abstract, extern or partial

        public string Method2() { return string.Empty; }
    }

    public abstract class AbstractClass2 { }



    public class ConcretClass1 : AbstractClass1 //, AbstractClass2 (error)
    {
        public override void Method1() //abstract methods must be override 
        {
            throw new NotImplementedException();
        }
    }

    public class ConcretClass2
    {
        public void Method()
        {
            //var abstractClass1 = new AbstractClass1(); //Error: cannot create an instance of an abstract class
            var concretClass1 = new ConcretClass1();
            concretClass1.Method1();
            concretClass1.Method2();
        }
    }
}
