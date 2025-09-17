namespace CommonTypesProject.Interfaces
{
    interface InterfaceExample
    {
        public string property { get; set; }

        //public string Name; // (error) fields are not allowed in interfaces
        //public InterfaceExample() { } //(error) constructors are not allowed in interfaces

        void Method();

        event EventHandler EventH;
    }

    public interface  Interface2
    {
        //private string property { get; set; } //An interface can not be private or protected, neither its declaratios nor its members
        void Method2() { }
        void Method3();
    }

    public class ConcretClass : InterfaceExample, Interface2
    {
        public string property { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public event EventHandler EventH;

        public void Method()
        {
            throw new NotImplementedException();
        }

        public void Method3()
        {
            throw new NotImplementedException();
        }
    }
}
