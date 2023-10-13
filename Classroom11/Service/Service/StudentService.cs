using Domain.Models;
using System;
using System.Linq;

namespace Service.Service
{
    public class StudentService
    {
        public Student[] GetAll()
        {
            Student stu1 = new()
            {
                Id = 1,
                Name = "Javad",
                Surname = "Bakirli",
                Age = 32,
                Email = "javad@gmail.com"
            };

            Student stu2 = new()
            {
                Id = 2,
                Name = "Elshan",
                Surname = "Ahmadov",
                Age = 25,
                Email = "elshan@gmail.com"
            };

            Student stu3 = new()
            {
                Id = 3,
                Name = "Togrul",
                Surname = "Mammadov",
                Age = 30,
                Email = "togrul@gmail.com"
            };

            return new Student[] { stu1, stu2, stu3 };
        }

        public Student GetByIdStudent(int id)
        {
            Student[] students = GetAll();
            Student student = students.FirstOrDefault(x => x.Id == id);
            return student;
        }

        public Student[] GetAllStudentName() => GetAll();

        public Student[] GetStudentByAgeAscending() 
        {
            var sortStudent = GetAll().OrderByDescending(x => x.Age);
            return sortStudent.ToArray();

        }

       
    }
}
