using System;

public class Properties
{
    private int age;

    public int Age
    {
        get { return age; }
        set
        {
            if (value < 0 || value > 125)
            {
                throw new ArgumentOutOfRangeException("The value of the Age property must be between 0 and 125.");
            }
            else
            {
                age = value;
            }
        }
    }
    public Properties()
    {

    }
}

public class ExampleProperties
{
    public static void Main()
    {
        try
        {
            var propertiesClass = new Properties();
            Console.WriteLine("Please enter an Age");

            var valid = int.TryParse(Console.ReadLine(), out int age);
            if (valid)
            {
                propertiesClass.Age = age;
                Console.WriteLine($"The age {propertiesClass.Age} is valid");
            }
            else
            {
                throw new ArgumentException("The value of the Age property has not a valid format.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}