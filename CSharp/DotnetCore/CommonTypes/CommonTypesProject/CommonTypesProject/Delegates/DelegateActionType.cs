namespace CommonTypesProject.Delegates
{
    public static class DelegateActionType
    {
        //Declare a delegate with 0 to 16 parameters and void return:
        public delegate void DelegateActionHandle(string value);
       
        //Is the same as declare an action:
        public static Action<string> ActionHandler;

        public static void Execute()
        {
            Func<string, string> PrintRequestHandler = PrintRequest;
            var value = PrintRequestHandler("Write a word to reverse it:");

            while (string.IsNullOrWhiteSpace(value))
            {
                value = PrintRequestHandler("Write a valid word to reverse it: ");
            }

            ActionHandler = ReverseString;
            ActionHandler(value);
        }

        public static string PrintRequest(string msg)
        {
            Console.WriteLine(msg);
            return Console.ReadLine();
        }

        public static void ReverseString(string value)
        {
            Console.WriteLine(string.Join("", value.Reverse().ToArray()));
        }

    }
}
