namespace CommonTypesProject.Classes
{
    public interface BaseInterface1
    {
        public int IntProperty { get; set; }

        public int MethodBaseInterface1();
    }

    public interface BaseInterface2
    {
        public int MethodBaseInterface2();
    }

    public class BaseClass1ForInheritsExample : BaseInterface1, BaseInterface2 // A class can implement many interfaces
    {
        public int IntProperty { get; set; }

        public BaseClass1ForInheritsExample()
        {
            
        }

        //All interface's methods must be explicitly implemented
        public int MethodBaseInterface1()
        {
            return 1;
        }

        public int MethodBaseInterface2()
        {
            return 2;
        }
    }

    public class BaseClass2ForInheritsExample { }
    public class BaseClass3ForInheritsExample : BaseClass1ForInheritsExample //, BaseClass2ForInheritsExample (error) --> A class can inherits only one class, unless they are nested
    {
        //BaseClass1ForInheritsExample method's are implicit inherited
    }

    public class BaseClass4ForInheritsExample 
    {
        public void Execute()
        {
            var baseClass3 = new BaseClass3ForInheritsExample();    
            var temp = baseClass3.MethodBaseInterface2(); 
        }
    }
}
