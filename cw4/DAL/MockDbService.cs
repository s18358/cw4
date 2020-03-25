using cw4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cw4.DAL
{
    public class MockDbService : IDbService
    {
        private static IEnumerable<Student> _students;

        static MockDbService()
        {
            _students = new List<Student>
            {
                new Student { IdStudent = 1, FirstName = "Jan", LastName = "Kowalski"},
                new Student { IdStudent = 2, FirstName = "Pawel", LastName = "Opolak" },
                new Student { IdStudent = 3, FirstName = "Anna", LastName = "Nowak" }
        };
        }

        public IEnumerable<Student> GetStudents()
        {
            return _students;
        }
    }
}
