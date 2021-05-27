﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookLINQ
{
    class AddressBookRec
    {
        DataTable table = new DataTable("AddressBookSystem"); // UC 1 Create a new DataTable

        // UC2: Ability to create a Address Book Table with first and last names, address, city, state, zip, phone number and email as its attributes
        public AddressBookRec()
        {
            table.Columns.Add("FirstName", typeof(string));
            table.Columns.Add("LastName", typeof(string));
            table.Columns.Add("Address", typeof(string));
            table.Columns.Add("City", typeof(string));
            table.Columns.Add("State", typeof(string));
            table.Columns.Add("Zip", typeof(string));
            table.Columns.Add("PhoneNumber", typeof(string));
            table.Columns.Add("Email", typeof(string));

            //UC3:-Ability to insert new Contacts to Address Book 
            table.Rows.Add("Ekta", "Kumbhare", "Bajaj Nagr", "Nagpur", "Maharashtra", "412105", "8788566219", "ekkum@gmail.com");
            table.Rows.Add("Pallavi", "Kumbhare", "Aund", "Pune", "Maharashtra", "125121", "8570934858", "pallu@gmail.com");
            table.Rows.Add("Abhishek", "Singh", "Mumbai", "Mumbai", "Maharashtra", "442206", "7894561230", "abhi@gmail.com.a");

        }

        public void GetAllContacts()
        {
            try
            {

                Console.WriteLine("\n");
                foreach (DataRow dr in table.AsEnumerable())
                {
                    Console.WriteLine("\n");
                    Console.WriteLine("FirstName:- " + dr.Field<string>("firstName"));
                    Console.WriteLine("LastName:- " + dr.Field<string>("lastName"));
                    Console.WriteLine("Address:- " + dr.Field<string>("address"));
                    Console.WriteLine("City:- " + dr.Field<string>("city"));
                    Console.WriteLine("State:- " + dr.Field<string>("state"));
                    Console.WriteLine("Zip:- " + dr.Field<string>("zip"));
                    Console.WriteLine("PhoneNumber:- " + dr.Field<string>("phoneNumber"));
                    Console.WriteLine("Email:- " + dr.Field<string>("eMail"));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.HelpLink);
            }

        }
        //UC4: Ability to edit existing contact person using their name
         
        public void EditExistingContact(string firstName, string lastName, string column, string newValue)
        {
            DataRow contact = table.Select("FirstName = '" + firstName + "' and LastName = '" + lastName + "'").FirstOrDefault();
            contact[column] = newValue;
            Console.WriteLine("Record successfully Edit");
            GetAllContacts();

        }
    }
}
