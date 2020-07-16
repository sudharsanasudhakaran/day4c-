using codeFirstApproach.DTO;
using codeFirstApproach.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace codeFirstApproach.Repository
{
    class PersonRepository : IPersonRepository
    {
        private readonly ApplicationDbContext _db;
        public PersonRepository()
        {
            _db = new ApplicationDbContext();
        }
        public List<Person> GetAllPerson()
        {
            var persons = _db.Persons.ToList();
            return persons;
        }

        public Person GetPerson(int id)
        {
            var person = _db.Persons.Where(a => a.Id == id).FirstOrDefault();
            return person;
        }

        public List<StudentDTO> GetStudents()
        {
            var students = _db.Students.Include("Grade").Select(a => new StudentDTO()
            {
                Address = a.Address,
                Name = a.Name,
                Gradename = a.Grade.Gradename
            }).ToList();
          
            return students;
        }
    }
}
