using Domain.Models;
using Service.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Classroom11Teacher.Controllers
{
    public class StudentControlller
    {
        private readonly StudentService _studentService;
        public StudentControlller()
        {
            _studentService = new StudentService();

        }


        public void GetAllStudents()
        {
            var student = _studentService.GetAllStudents();
            foreach (var item in student)
            {
                string result = $"{item.FullName} - {item.Age} - {item.Email}";
                Console.WriteLine(result);

            }

        }

        public void GetStudentById()
        {
            var result = _studentService.GetById(3);
            string reult = $"{student.FullName} - {student.Age} -{student.Email}";
            Console.WriteLine(result);



        }

        public void SumOfStudentAge() 
        {
            var resut = _studentService.GetAllStudents();
            var sumAge = students.Sum(m => m.Age);
            Console.WriteLine(sumAge);


        }

        public void SumOfStudentAge()
        {
            Console.WriteLine(_studentService.SumOfAge());

        }

        public void AverageOfStudentAge();
        var sumAge = student.Sum(m => m.Age);
        Console.Writeline(sumAge/students.Lenght);
        
    }
}
