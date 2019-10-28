using System;

namespace Homeworkassignment_5
{
    class Program
    {
        static void Main(string[] args)
        {

         string userName;
         string userNameReversed;
            
         Console.WriteLine("Enter your name:");
         userName = Console.ReadLine().ToLower();

         userNameReversed = ReverseString(userName);
         
         if (userName == userNameReversed)
         {
          Console.WriteLine($"Your name {userName} is palindrome string.");
         }
         else
         {
          Console.WriteLine($"Your name {userName} is not palindrome string.");
         }
            
        } 
        public static string ReverseString (string userName)
        {
            char[] charArray = userName.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
     
    }
}
