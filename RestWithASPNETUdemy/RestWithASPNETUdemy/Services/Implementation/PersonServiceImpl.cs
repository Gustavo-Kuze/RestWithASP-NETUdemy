using System;
using System.Collections.Generic;
using RestWithASPNETUdemy.Model;
using RestWithASPNETUdemy.Model.Context;

namespace RestWithASPNETUdemy.Services.Implementation
{
    public class PersonServiceImpl : IPersonService
    {
        private MySQLContext _context;

        public PersonServiceImpl(MySQLContext context)
        {
            _context = context;
        }

        public Person Create(Person person)
        {
            try
            {
                _context.Add(person);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return person;
        }

        public void Delete(long id)
        {
           
        }

        public List<Person> FindAll()
        {
            return new List<Person>();

        }

        public Person FindById(long id)
        {
            return new Person() {
                Id = 1,
                Name = "Leandro",
                LastName = "Costa",
                Address = "Uberlândia",
                Gender = "Male"

            };
        }

        public Person Update(Person person)
        {
            throw new NotImplementedException();
        }
    }
}
