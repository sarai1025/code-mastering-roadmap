using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CommonTypesProject.Delegates
{
    public static class DelegatePredicateType
    {
        //Instead of do this:
        //public delegate bool PredicateTypeExample(string criteriaToValidate);
        //To declare a predicate is the same as:
        //public static Predicate<string> PredicateTypeExample2;
        public static void ExecutePredicate()
        {
            var emails = new List<string>()
           {
                "test@gmail.com",
                "test@gmail",
                "2gmail.com",
                "test@hotmail.com"
            };

            Predicate<string> predicate = new(EmailIsValid);

            var validEmails = emails.FindAll(predicate);
            //or it is the same as: 
            //var validEmails = emails.FindAll(EmailIsValid);
            //or the same as:
            //var validEmails = emails.FindAll(r => Regex.IsMatch(r, @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$"));

            foreach (var email in validEmails)
            {
                Console.WriteLine(email);
            }
        }
        public static bool EmailIsValid(string email)
        {
            string pattern = @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
            return Regex.IsMatch(email, pattern);
        }
    }
}
