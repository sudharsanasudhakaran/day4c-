using codeFirstApproach.Models;
using codeFirstApproach.Repository;
using System;
using System.Linq;
using System.Security.Cryptography;

namespace codeFirstApproach
{
    class Program
    {
        static void Main(string[] args)
        {
            IPersonRepository _repo = new PersonRepository();

            var persons = _repo.GetStudents();

            Console.WriteLine("---------------");
        }

        private static void InsertData(ApplicationDbContext _db)
        {
            Person p = new Person();
            Console.WriteLine("Enter Name");
            p.Name = Console.ReadLine();

            Console.WriteLine("Enter Location");
            p.Location = Console.ReadLine();

            Console.WriteLine("Enter Age");
            p.Age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Address");
            p.Address = Console.ReadLine();

            p.CreatedOn = DateTime.Now;
            p.Gender = "male";
            p.IsActive = true;
            p.Mobile = "12345";
            p.Status = 1;
            p.UpdatedOn = DateTime.Now;

            _db.Persons.Add(p);
            _db.SaveChanges();
        }

        static void ReadData(ApplicationDbContext _db)
        {

            var person1 = _db.Persons.ToList();
            if (person1.Any())
            {
                foreach (var item in person1)
                {
                    Console.WriteLine(item.Id + " \t" + item.Name + "\t " + item.Location);
                }
            }
            else
            {
                Console.WriteLine("no data found");
            }
        }
    }
}
