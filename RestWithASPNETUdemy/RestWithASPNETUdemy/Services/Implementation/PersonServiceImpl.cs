using System;
using System.Collections.Generic;
using RestWithASPNETUdemy.Model;

namespace RestWithASPNETUdemy.Services.Implementation
{
    public class PersonServiceImpl : IPersonService
    {
        public Person Create(Person person)
        {
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
