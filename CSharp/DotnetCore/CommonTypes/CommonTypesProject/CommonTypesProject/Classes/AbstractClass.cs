
namespace CommonTypesProject.Classes
{
    public abstract class AbstractClass1
    {
        
        //Abstract class indicate missing components and incomplete implementation that avoid its intstantiation (+ secure)
        
        
        public abstract int AbstractProperty { get; set; } // obligatoriness to clasess that implement this abstract class
        protected AbstractClass1()
        {

        }

        private static void Method() { }
        public abstract void Method1(); //abstracts methods should be declare within abstract class
                                        //Methods not implemented must be declared as abstract, extern or partial

        public string Method2() { return string.Empty; }
    }

    public abstract class AbstractClass2 : AbstractClass1 { } //In this case do not need to implement abstract methods since it also is abstract



    public class ConcretClass1 : AbstractClass1 //, AbstractClass2 (error) only can inherit one class.
    {
        public override int AbstractProperty { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

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

    public class ConcretClass3 : ConcretClass2, Interface { }

    public interface Interface { }
}
