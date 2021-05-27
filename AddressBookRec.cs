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
        }
    }
}
