using System;
using Domain.Models;
using Service.Service;

namespace App.Controller
{
    public class StudentController
    {
        private StudentService _studentService;

        public StudentController()
        {
            _studentService = new StudentService();
        }

        public void GetByIdStudent()
        {
            int Id = 2;
            var result = _studentService.GetByIdStudent(Id);
            Console.WriteLine(result.Name + " " + result.Surname + " " + result.Email);
        }

        public void GetAllStudentName()
        {
            var students = _studentService.GetAllStudentName();
            foreach (var student in students)
            {
                string result = $"{student.Name} - {student.Surname}";
                Console.WriteLine(result);
            }
        }

        public void AverageOfStudentAge()
        {
            var students = _studentService.GetAllStudentName();
            int sumAge = students.Sum(m => m.Age ?? 0);
            double averageAge = (double)sumAge / students.Length;
            Console.WriteLine($"Telebelerin orta yashi: {averageAge} yash");
        }

        public void GetStudentByAgeAscending() 
        {
            var students = _studentService.GetStudentByAgeAscending();
            foreach (var student in students) 
            {
                Console.WriteLine($"{student.Name} {student.Surname} {student.Age}");


            }


        }


    }
}
