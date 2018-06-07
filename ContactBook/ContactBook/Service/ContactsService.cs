using ContactBook.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ContactBook.Service
{
    public class ContactsService
    {
        public List<Contact> GetContacts(string searchText = null)
        {
            var contacts = new List<Contact>
            {
                new Contact { FName="Raushan", LName="Sinha", Cell="111-222-333", Department="IT", DeptNo="D1", Email="hr.raushan@gmail.com"},
                new Contact { FName="Prakash", LName="Singh", Cell="111-222-333", Department="MEDIA", DeptNo="D2", Email="hr.raushan@gmail.com"},
                new Contact { FName="Santosh", LName="Kumar", Cell="111-222-333", Department="ATOMIC", DeptNo="D3", Email="hr.raushan@gmail.com"},
                new Contact { FName="Reyansh", LName="Sinha", Cell="111-222-333", Department="Student", DeptNo="D4", Email="hr.raushan@gmail.com"},
                new Contact { FName="Rajat", LName="Kumar", Cell="111-222-333", Department="IT", DeptNo="D1", Email="hr.raushan@gmail.com"},
                new Contact { FName="Anita", LName="Rai", Cell="111-222-333", Department="IT", DeptNo="D1", Email="hr.raushan@gmail.com"},
                new Contact { FName="RK", LName="Deepak", Cell="111-222-333", Department="IT", DeptNo="D1", Email="hr.raushan@gmail.com"},
                new Contact { FName="Ranjeet", LName="Kumar", Cell="111-222-333", Department="IT", DeptNo="D1", Email="hr.raushan@gmail.com"},
            };

            if (String.IsNullOrWhiteSpace(searchText))
                return null;


            return contacts.FindAll(c => c.FName.ToLower().StartsWith(searchText.ToLower()) || c.LName.ToLower().StartsWith(searchText.ToLower()));
        }
    }
}
