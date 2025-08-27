namespace ConsoleSample
{
    internal class DTOSample
    {
        public int Id { get; set; }
        public int Ad { get; set; }


        //This is a method to validate how the explicit global using works
        //To achive the operation in line 16 is required the using System.Text.Json,
        //However, that using is not in this current file. 
        //
        //It works because System.Text.Json was included as a global using in .csproj file
        public static string ExplicitUsing(string text)
        {
            return JsonSerializer.Serialize(text);
        }
    }
}
