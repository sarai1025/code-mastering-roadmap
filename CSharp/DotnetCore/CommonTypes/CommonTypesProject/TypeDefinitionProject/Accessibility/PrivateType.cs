using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeDefinitionProject.Accessibility
{
    //classes can not be declared as private
    //private class PrivateType
    //{
    //}

    //This class TestingPrivateProperties can not be declared as public and inherit from an internal class (internalType) because the internal
    //is less accesible than public class so it can 
    //lead to expose information from one project to other through the public one.
    internal class TestingPrivateProperties : InternalType
    {
        public void Method()
        {
            var internalClass = new InternalType();
            //var canAccessToPrivateLevel = internalClass.PrivateProperty && internalClass.PrivateMethod() && PrivateProperty && PrivateMethod();
        }
    }
}
