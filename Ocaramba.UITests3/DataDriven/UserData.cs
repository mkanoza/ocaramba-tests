using System;

namespace Ocaramba.UITests3.DataDriven
{
    class UserData
    {
        public static string fistName = "Juan";
        public static string lastName = "Pablo";
        public static string currentAccountEmail = "juanpablo@test.pl";
        public static string currentAccountPassword = "pass123";

        public static string randomEmailAddress = StringGenerator.GenerateEmailAddress();
        public static string randomPassword = StringGenerator.GenerateAlphanumericString(new Random().Next(5, 32), false);
    }
}
