﻿namespace Telephony
{
    using System;

    public class StartUp
    {
        static void Main()
        {
            var phoneNumbers = Console.ReadLine().Split();
            var webisites = Console.ReadLine().Split();
            var phone = new Smartphone();

            foreach (var number in phoneNumbers)
            {
                try
                {
                    Console.WriteLine(phone.Call(number));
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            foreach (var site in webisites)
            {
                try
                {
                    Console.WriteLine(phone.Browse(site));
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}
