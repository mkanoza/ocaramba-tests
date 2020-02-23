using System;

namespace Ocaramba.UITests3.DataDriven
{
    class UserData
    {
        public static string fistName = "Juan";
        public static string lastName = "Pablo";
        public static string currentAccountEmail = "juanpablo@test.pl";
        public static string currentAccountPassword = "pass123";
        public static string companyAddress = "Random company";
        public static string addressLine1Address = "Random street";
        public static string addressLine2Address = "21/37";
        public static string cityAddress = "Random town";
        public static string zipcodeAddress = "00000";
        public static string additionalInfoAddress = "Random additional information";
        public static string homePhoneAddress = "123123123";
        public static string mobilePhoneAddress = "456456456";
        public static string aliasAddress = "Random address";

        public static string randomEmailAddress = StringGenerator.GenerateEmailAddress();
        public static string randomPassword = StringGenerator.GenerateAlphanumericString(new Random().Next(5, 32), false);
    }
}
