
namespace TypeDefinitionProject.Accessibility
{
    public class PublicType
    {
        public int PublicProperty { get; set; }
        public void PublicMethod()
        {
            PublicProperty = 1;
        }

        private bool PrivateProperty { get; set; }
        private bool PrivateMethod() { return PrivateProperty; }

        internal bool InternalProperty { get; set; }
        internal bool InternalMethod() { return InternalProperty; }
    }

    public class PublicClassSameAssembly
    { 
        public void Method()
        {
            PublicType publicType = new PublicType();
            var value = publicType.PublicProperty;
            publicType.PublicMethod();

            Console.WriteLine("Access to public property and method from different class into the same assembly: Valid");
        }
    }

    public class PublicDerivedClassSameAssembly : PublicType 
    {
        public void Method()
        {
            var value = PublicProperty;
            PublicMethod();

            Console.WriteLine("Access to public property and method from derived class into the same assembly: Valid");
        }
    }
}
