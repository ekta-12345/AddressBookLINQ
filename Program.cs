﻿using System;

namespace AddressBookLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Address Book Data LINQ!");
            // UC 1 Create a new table
            AddressBookRec addressBookTable = new AddressBookRec();
            //addressBookTable.GetAllContacts();
            addressBookTable.EditExistingContact("Ekta", "Kumbhare", "PhoneNumber", "9921670015");

            Console.ReadLine();
        }
    }
}
