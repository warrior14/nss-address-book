using System;
using System.Collections.Generic;

namespace AddressBook 
{
    public class AdressBook 
    {
        public Dictionary<string, Contact> Phonebook { get; set; }

        public AddressBook()
        {
            PhoneBook = new Dictionary<string, Contact>();
        }

        // method to add a Contact object param to the AddressBook class with the email address as the key and the value as the contact object
        public void AddContact(Contact personContact)
        {
            try 
            {
                Phonebook.Add(personContact.Email, personContact);
            }
            catch (ArgumentException)
            {
                Console.WriteLine($"You've attempted to add a duplicate contact with email: {personContact.Email}. Please try to add a new contact!");
            }
        }
        // method to receive contact by email
        public Contact GetEmail(string email)
        {
            return Phonebook[email]
        }
    }
}