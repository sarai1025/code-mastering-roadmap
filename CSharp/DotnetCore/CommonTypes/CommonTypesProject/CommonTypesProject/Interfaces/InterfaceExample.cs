namespace CommonTypesProject.Interfaces
{
    interface Interface1
    {
        public string property { get; set; }

        //public string Name; // (error) fields are not allowed in interfaces
        //public Interface1() { } //(error) constructors are not allowed in interfaces

        void Method();

        event EventHandler EventH;
    }

    public interface  Interface2
    {
        //private string property { get; set; } //An interface can not be private or protected, neither its declaratios nor its members
        void Method2() { }
        void Method3();
    }

    public class ConcretClass : Interface1, Interface2
    {
        public string property { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public event EventHandler EventH;

        public void Method()
        {
            //var instanceInterfacesAreNotAllowed = new InterfaceExample();
            Interface1 method = new ConcretClass();
        }

        public void Method3()
        {
            throw new NotImplementedException();
        }
    }
}
