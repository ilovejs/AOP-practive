﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using d2;
/*
 * Remember that property getters and setters are turned into methods 
 * when your code is compiled which makes them eligible for receiving the aspect. 
 * The .cctor entry is the static constructor and .ctor is the instance constructor.
 * 
 * Output:
    .cctor Started 
    InitializeData Started 
    set__contactStore Started 
    set__contactStore Finished 
    get__contactStore Started 
    get__contactStore Finished 
    get__contactStore Started 
    get__contactStore Finished 
    get__contactStore Started 
    get__contactStore Finished 
    get__contactStore Started 
    get__contactStore Finished 
    get__contactStore Started 
    get__contactStore Finished 
    get__contactStore Started 
    get__contactStore Finished 
    InitializeData Finished 
    .cctor Finished 
    .ctor Started 
    .ctor Finished 
    GetAll Started 
    get__contactStore Started 
    get__contactStore Finished 
    GetAll Finished 
 */
namespace d2
{
    //Class Level Declaration
    [MethodTraceAspect]
    internal class InMemoryDataStore : d2.IContactRepository
    {
        private static List<Contact> _contactStore { get; set; }

        static InMemoryDataStore()
        {
            InitializeData();
        }

        private static void InitializeData()
        {
            _contactStore = new List<Contact>();
            _contactStore.Add(new Contact() { ID = 1, FirstName = "John", LastName = "Smith", EmailAddress = "john@smith.com" });
            _contactStore.Add(new Contact() { ID = 2, FirstName = "James", LastName = "Smith", EmailAddress = "james@smith.com" });
            _contactStore.Add(new Contact() { ID = 3, FirstName = "Jane", LastName = "Smith", EmailAddress = "jane@smith.com" });
            _contactStore.Add(new Contact() { ID = 4, FirstName = "Mary", LastName = "Clark", EmailAddress = "mary@clark.com" });
            _contactStore.Add(new Contact() { ID = 5, FirstName = "Lucy", LastName = "Doe", EmailAddress = "lucy@doe.com" });
            _contactStore.Add(new Contact() { ID = 6, FirstName = "John", LastName = "Doe", EmailAddress = "john@doe.com" });

        }

        public void Insert(Contact contact)
        {
            contact.ID = _contactStore.Max(c => c.ID) + 1;
            _contactStore.Add(contact);
            System.Threading.Thread.Sleep(3000);
        }

        public void Update(Contact contact)
        {
            var itm = _contactStore.FirstOrDefault(c => c.ID.Equals(contact.ID));

            if (itm == null)
            {
                throw new InvalidOperationException("Contact item is invalid or was not found");
            }

            itm = contact;
        }

        public void Delete(Contact contact)
        {
            _contactStore.RemoveAll(c => c.ID.Equals(contact.ID));
        }

        public IQueryable<Contact> GetAll()
        {
            return _contactStore.AsQueryable();
        }

        public IQueryable<Contact> GetByID(int id)
        {
            return _contactStore.Where(c => c.ID.Equals(id)).AsQueryable();
        }

        [DatabaseExceptionWrapper]
        [MethodTraceAspect]
        public IQueryable<Contact> GetByName(string value)
        {
            var res = _contactStore.Where(c => c.FirstName.Contains(value) || c.LastName.Contains(value));

            if (res.Count() < 1)
            {
                ThrowNoResultsException();
            }

            Thread.Sleep(3000);
            return res.AsQueryable();
        }

        private void ThrowNoResultsException()
        {
            string msg = string.Format("Invalid Operation. \n {0}.InMemoryDataStore 1.0", System.Windows.Forms.SystemInformation.ComputerName);

            throw new InvalidOperationException(msg);
        }
    }

   
}
