using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeDefinitionProject.Accessibility
{
    internal class InternalType
    {
        internal bool InternalProperty { get; set; }
        public bool PublicProperty { get; set; }
        protected bool ProtectedProperty { get; set; }
        private bool PrivateProperty { get; set; }

        private protected bool PrivateProtectedProperty { get; set; }
        protected internal bool ProtectedInternalProperty { get; set; }

        internal bool InternalMethod()
        {
            return InternalProperty = true;
        }

        public bool PublicMethod()
        {
            return PublicProperty = true;
        }

        protected bool ProtectedMethod()
        {
            return ProtectedProperty = true;
        }

        private bool PrivateMethod()
        {
            //the only part where the private property can be accessed
            return PrivateProperty = true;
        }

        private protected bool PrivateProtectedMethod()
        {
            return PrivateProtectedProperty = true;
        }

        protected internal bool ProtectedInternalMethod()
        {
            return ProtectedInternalProperty = true;
        }
    }

    internal class InternalTypeSameAssembly
    {
        public void VerifyDifferentAccesibilityLevels()
        {
            var publicClass = new PublicType();
            var canAccessToInternalFromPublicClass = publicClass.InternalProperty && publicClass.InternalMethod();

            //Compiler verifies field and method accesibility over the class accesibility
            var internalType = new InternalType();
            var canAccessToInternal = internalType.InternalProperty && internalType.InternalMethod();
            var canAccessToPublic = internalType.PublicProperty && internalType.PublicMethod();
            var canAccessToProtectedInternal = internalType.ProtectedInternalProperty && internalType.ProtectedInternalMethod();

            Console.WriteLine("Access to internal, public and protectedInternal properties and methods from different internal class into the same assembly: Valid");
            Console.WriteLine("Access to private, protected and privateProtected properties and methods from different internal class into the same assembly: Invalid");
        }

        public void VerifyInternalAccesibilityLevel()
        {
            var internalType = new InternalType();
            var canAccessToInternal = internalType.InternalProperty && internalType.InternalMethod();

            Console.WriteLine("Access to internal property and method from different class into the same assembly: Valid");
        }
    }

    internal class InternalDerivedTypeSameAssembly : InternalType
    {
        public void VerifyDifferentAccesibilityLevels()
        {
            var canAccessToPublic = PublicProperty && PublicMethod();
            var canAccessToProtected = ProtectedProperty && ProtectedMethod();
            var canAccessToInternal = InternalProperty && InternalMethod();
            var canAccessToPrivateProtected = PrivateProtectedProperty && PrivateProtectedMethod();
            var canAccessToProtectedInternal = ProtectedInternalProperty && ProtectedInternalMethod();

            Console.WriteLine("Access to internal, public, protected, privateProtected, protectedInternal properties and methods from derived internal class into the same assembly: Valid");
            Console.WriteLine("Access to private property and method from derived internal class into the same assembly: invalid");
        }

        public void VerifyInternalAccesibilityLevel()
        {
            var canAccessToInternal = InternalProperty && InternalMethod();

            Console.WriteLine("Access to internal property and method from derived class into the same assembly: Valid");
        }
    }

    internal class InternalDerivedPublicTypeSameAssembly : PublicType
    {
        public void Method()
        {
            var canAccessToInternalFromPublicClass = InternalProperty && InternalMethod();
        }
    }
}
