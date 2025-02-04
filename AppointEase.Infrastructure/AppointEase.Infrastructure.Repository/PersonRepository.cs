﻿using AppointEase.Application.AppointEase.Application.Interface;
using AppointEase.Domain.AppointEase.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppointEase.Infrastructure.AppointEase.Infrastructure.Repository
{
    public class PersonRepository : IPersonRepository
    {
        private readonly DataContext _context;

        public PersonRepository(DataContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public Person GetPerson(int personId)
        {
            return _context.Person.FirstOrDefault(p => p.PersonId == personId);
        }

        public IEnumerable<Person> GetAllPersons()
        {
            return _context.Person.ToList();
        }

        public void CreatePerson(Person person)
        {
            _context.Person.Add(person);
            _context.SaveChanges();
        }

        public void UpdatePerson(Person person)
        {
            _context.Person.Update(person);
            _context.SaveChanges();
        }

        public void DeletePerson(Person person)
        {
            _context.Person.Remove(person);
            _context.SaveChanges();
        }
    }
}
