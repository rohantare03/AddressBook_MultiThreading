using NUnit.Framework;
using AddressBook_MultiThreading;
using System.Collections.Generic;
using System;

namespace AddressBookTest
{
    public class Tests
    {
        List<AddressBook> AddressList;
        AddressBookOperations addressBookOperations;
        [SetUp]

        public void Setup()
        {
            AddressList = new List<AddressBook>();
            addressBookOperations = new AddressBookOperations();
        }

        [Test]
        public void CheckingTime_For_Inserting_Details()
        {
            AddressList.Add(new AddressBook(Firstname: "Rohan", Lastname: "Tare", Address: "Virar", City: "Mumbai", State: "MH", Zip: 401305, PhoneNumber: 9458437543, Email: "rohan@gmail.com"));
            AddressList.Add(new AddressBook(Firstname: "Kylie", Lastname: "Jenner", Address: "MainStreet001", City: "Dublin", State: "NY", Zip: 401222, PhoneNumber: 9458452343, Email: "kylie@gmail.com"));
            AddressList.Add(new AddressBook(Firstname: "Kenny", Lastname: "Jenner", Address: "BeverlyHills", City: "Sanfransico", State: "WC", Zip: 401303, PhoneNumber: 9354466543, Email: "kenny@gmail.com"));

            DateTime StartDateTime = DateTime.Now;
            addressBookOperations.AddContacts(AddressList);
            DateTime StopDateTimes = DateTime.Now;
            Console.WriteLine("Duration without threads: " + (StopDateTimes - StartDateTime));
        }
    }
}