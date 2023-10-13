using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Service
{
    public class StudentService
    {
        private Student[] GetAll() 
        {
            return new Student[]
            {
                new Student{ Id = 1, FullName = "Tunzale Memmedova" , Age = 24, Email = "tunzale@gmail.com"},
                new Student{ Id = 2, FullName = "Metanet Abbasova" , Age = 27, Email = "metanet@gmail.com"},
                new Student{ Id = 3, FullName = "Meryem Eliyeva" , Age = 23, Email = "meryem@gmail.com"},
                new Student{ Id = 4, FullName = "Arzu Karimova" , Age = 25, Email = "arzu@gmail.com"},
            };
        
        }

        public Student[] GetAllStudents() => GetAll();

        public string GetFullData(int id) 
        {
            var result = GetAll().FirstOrDefault(m=> m.Id==id);
            string result = $"{student.FullName} - {student.Age} - {student.Email}";
            return result;
        
        }
        public int SumOfAge() 
        {
            return GetAll().Sum(m => m.Age);
            Console.WriteLine(sumAge);

       

        }
        
            
        

        public Student[] GetById() => GetAll().FirstOrDefault(m => m.Id == id);
     

        public Student[] 

    }
}
