using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace Demos.HackerU.HomeWorks
{
    public class HW1
    {
        public static void Run()
        {
            #region Targil 1
            string str1 = "AbgC";
            string str2 = "abc";
            bool IsEquals = CheckLowerUpperEquals(str1, str2);
            Console.WriteLine(IsEquals);
            Console.WriteLine("--------------------");
            #endregion
            #region Targil 2
            Console.WriteLine("Enter User name:");
            string UserName = Console.ReadLine();
            Console.WriteLine("Enter Email type");
            string EmailType = Console.ReadLine();
            string Email = ToEmail(UserName, EmailType);
            Console.WriteLine(Email);
            #endregion
        }

        private static string ToEmail(string userName, string emailType)
        {
            string Alarm = "";
            bool Valid = true;
            if (userName == "" || emailType == "")
            {
                Valid = false;
                Alarm += "one of parameters are empty.";
            }
            if (userName.Length > 10)
            {
                if (!Valid)
                {
                    Alarm += " * ";
                }
                Alarm += "User name must not pass 10 charecters.";
                Valid = false;
            }
            if (userName.Contains(".") || userName.Contains("_"))
            {
                if (!Valid)
                {
                    Alarm += " * ";
                }
                Alarm += ". or _ are not allowed for username.";
                Valid = false;
            }
            if (!Valid)
            {
                return Alarm;
            }
            else
            {
                string Email = $"{userName}@{emailType}.com";
                return Email;
            }



        }

        private static bool CheckLowerUpperEquals(string str1, string str2)
        {
            bool IsEquals = false;
            string str1Lower = str1.ToLower();
            string str2Lower = str2.ToLower();
            if (str1Lower == str2Lower)
            {
                IsEquals = true;
            }
            return IsEquals;
        }
    }
}