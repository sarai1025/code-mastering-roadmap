using System.Runtime.InteropServices;

namespace CommonTypesProject.Structures
{
    public struct StructClassTest //Struct can not inherint from any class
    {
        public int Number { get; set; }

        public StructClassTest(int number)
        {
            this.Number = number;
        }
    }

    public class ClassForStructTest //: StructTest (Error) structures can not be inherited as they are implicitly sealed
    {
        public int Number { get; set; }

        public ClassForStructTest(int number)
        {
            this.Number = number;
        }
    }

    public static class StructTest
    {
        public static void Compare()
        {
            Console.WriteLine("/////////////////////////////////////////////////////");
            Console.WriteLine("                     Struct");
            Console.WriteLine("/////////////////////////////////////////////////////");
            CompareStructSameInstance();
            CompareStructDifferentInstances();



            Console.WriteLine("/////////////////////////////////////////////////////");
            Console.WriteLine("                      Class");
            Console.WriteLine("/////////////////////////////////////////////////////");
            CompareClassSameInstance();
            CompareClassDifferentInstances();
        }

        public static void CompareStructSameInstance()
        {
            var structClassTest = new StructClassTest(1);
            var structClassTest2 = structClassTest;

            structClassTest2.Number = 2;
            var areSameReferences = structClassTest.Equals(structClassTest2);

            #region PrintingProcess
            Console.WriteLine("Example changing the value property for same instance (variableB = variableA)");
            Console.WriteLine(PrintAddress(structClassTest) + ": " + structClassTest.Number);
            Console.WriteLine(PrintAddress(structClassTest2) + ": " + structClassTest2.Number);
            Console.WriteLine("The References are equals?: " + areSameReferences);
            Console.WriteLine("Explanation: Despite both variables point to the same instance, the struct creates a copy when value was changed from 1 to 2");
            Console.WriteLine();
            #endregion
        }

        private static void CompareStructDifferentInstances()
        {
            var structClassObjectTest = new StructClassTest(1);
            var structClassObjectTest2 = new StructClassTest(1);

            var areSameObjects = structClassObjectTest.Equals(structClassObjectTest2);

            #region PrintingProcess
            Console.WriteLine("Example creating two objects (new) with same value property");
            Console.WriteLine(PrintAddress(structClassObjectTest) + ": " + structClassObjectTest.Number);
            Console.WriteLine(PrintAddress(structClassObjectTest2) + ": " + structClassObjectTest2.Number);
            Console.WriteLine("The Objects are equals?: " + areSameObjects);
            Console.WriteLine("Explanation: Both variables point to different instances but the system only compares values not references for Structs ");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            #endregion
        }

        public static void CompareClassSameInstance()
        {
            var classTest = new ClassForStructTest(1);
            var classTest2 = classTest;

            classTest2.Number = 2;
            var areSameReferences = classTest.Equals(classTest2);

            #region PrintingProcess
            Console.WriteLine("Example changing the value property for same instance (variableB = variableA)");
            Console.WriteLine(PrintAddress(classTest) + ": " + classTest.Number);
            Console.WriteLine(PrintAddress(classTest2) + ": " + classTest2.Number);
            Console.WriteLine("The References are equals?: " + areSameReferences);
            Console.WriteLine("Explanation: Despite both variables point to the same instance, the class creates a new referece when value was changed from 1 to 2");
            Console.WriteLine();
            #endregion
        }

        private static void CompareClassDifferentInstances()
        {
            var classObjectTest = new ClassForStructTest(1);
            var classObjectTest2 = new ClassForStructTest(1);

            var areSameObjects = classObjectTest.Equals(classObjectTest2);

            #region PrintingProcess
            Console.WriteLine("Example creating two objects (new) with same value property");
            Console.WriteLine(PrintAddress(classObjectTest) + ": " + classObjectTest.Number);
            Console.WriteLine(PrintAddress(classObjectTest2) + ": " + classObjectTest2.Number);
            Console.WriteLine("The Objects are equals?: " + areSameObjects);
            Console.WriteLine("Explanation: Both variables point to different instances but in this case the system compares references not values ");
            Console.ReadKey();
            #endregion
        }

        public static unsafe string PrintAddress(object objectToPrintAddress)
        {
            GCHandle handle = GCHandle.Alloc(objectToPrintAddress, GCHandleType.Pinned);
            var address = handle.AddrOfPinnedObject();
            return address.ToString("x");
        }
    }
}
