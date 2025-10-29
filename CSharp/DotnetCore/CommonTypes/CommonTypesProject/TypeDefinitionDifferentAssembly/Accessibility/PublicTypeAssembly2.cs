using TypeDefinitionProject.Accessibility;

namespace TypeDefinitionAssembly2Project.Accessibility
{
    public class PublicClassDifferentAssembly
    {
        public void Method()
        {
            PublicType publicType = new PublicType();
            var value = publicType.PublicProperty;
            publicType.PublicMethod();
            
            Console.WriteLine("Access to public property and method from different class and different assembly: Valid");
        }
    }

    public class PublicDerivedClassDifferentAssembly : PublicType
    {
        public void Method()
        {
            var value = PublicProperty;
            PublicMethod();

            Console.WriteLine("Access to public property and method from a derived class of a different assembly: Valid");
        }
    }
}
