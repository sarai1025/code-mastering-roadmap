namespace CommonTypesProject.Enumerations
{
    enum Days
    {
        Monday = 1,
        Tuesday = 2,
        Wednesday = 3,
        Thursday = 4,
        Friday = 5,
        Saturday = 6,
        Sunday = 7
    }


    public class EnumsExample()
    {
        public static void AccessToEnum()
        {
            Console.WriteLine($"Today is {(Days)DateTime.Now.DayOfWeek}");
            Console.WriteLine($"Weeks starts on {Days.Monday}, that means this day is the number {(int)Days.Monday} in the week.");
            Console.ReadKey();
        }
    }
}
