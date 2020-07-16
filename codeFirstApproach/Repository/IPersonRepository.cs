using codeFirstApproach.DTO;
using codeFirstApproach.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace codeFirstApproach.Repository
{
    interface IPersonRepository
    {
        List<Person> GetAllPerson();

        Person GetPerson(int id);

        List<StudentDTO> GetStudents();
    }
}
