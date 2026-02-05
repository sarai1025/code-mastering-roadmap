using TypeDefinitionProject.Accessibility.Protected;

namespace TypeDefinitionAssembly2Project.Accessibility.Protected
{
    public class ProtectedTypeAssembly2
    {
        public void Method()
        {
            var protectedType = new ProtectedType();

            //Can not access to protected level because it is instantiated (same or different assembly), only derived (same or different assembly) or itself class can do.
            //var canAccessToProtectedLevel = protectedType.ProtectedProperty && ProtectedProperty.ProtectedMethod();
        }
    }

    public class ProtectedTypeDerivedAssembly2 : ProtectedType
    {
        public void Method()
        {
            var canAccessToProtectedLevel = ProtectedProperty && ProtectedMethod();
        }
    }
}
