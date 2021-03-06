﻿namespace CustomerCare.Batch
{
    using System;
    using Contracts;
    using NServiceBus;

    public class CustomerMadePreferedHandler:IHandleMessages<CustomerMadePrefered>
    {
        public void Handle(CustomerMadePrefered message)
        {
            using (new ColoredConsole(ConsoleColor.Green))
            {
                Console.Out.WriteLine("Customer {0} was made prefered", message.CustomerId);
            }
        }
    }
}