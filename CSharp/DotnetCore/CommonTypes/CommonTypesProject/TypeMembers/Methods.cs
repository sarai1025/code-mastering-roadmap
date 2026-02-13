using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeMembers
{
    public class Methods
    {
        public static void MethodListParams(params List<string> paramList)
        {
            paramList.ForEach(param => Console.WriteLine(param + "\n"));
        }

        public static void MethodArrayParams(int num, params string[] paramArray)
        {
            if (num == 0) return;

            foreach (var item in paramArray)
            {
                Console.WriteLine(item);
            }
        }

        //public static void MethodParams(params string param)
        //{
        //This signature definition is not allowed since the multiple params requires a type of collection
        //}

        public static void Main()
        {
            MethodListParams(new List<string>() { "Hello", "This", "Is a test of", "Variable number ", "of parameters" });
            MethodArrayParams(4, new string[4] { "Hello", "This", "Is a test of", "Variable number of parameters" });
        }
    }
}
