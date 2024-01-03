using System.Configuration;
using SchoolMagazine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolMagazine;
using School_Magazine;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace SchoolMagazine
{
    internal class StudentRepository : IStudentRepository
    {
        readonly IInformationStudent _studentInfo;
        public StudentRepository(InformationStudent studentInfo)
        {
            _studentInfo = studentInfo;
        }
        public void CreateNewEntry(Student student, ApplicationContext ap)
        {
            new Student();
            _studentInfo.InformationAboutStudent(student);
            ap.Students.Add(student);
            ap.SaveChanges();
        }
        public void DeleteEntry(Student student, ApplicationContext ap)
        {
            PrintAll(ap);
            Console.WriteLine("Введите ID,для удаления ");
            int? number = Convert.ToInt32(Console.ReadLine());
            var iteams = from p in ap.Students.ToList()
                         where p.Id == number
                        select p;
            foreach (Student iteam in iteams)
            {
                ap.Students.Remove(iteam);
                ap.SaveChanges();
            }
        }
        public void EditEntry(Student student, ApplicationContext ap)
        {
            Console.Write("Введите id, для выбора: ");
            int number = Convert.ToInt32(Console.ReadLine());
            var iteams = from p in ap.Students.ToList()
                         where p.Id == number
                         select p;
            _studentInfo.EditEntry();
            _studentInfo.InformationAboutStudent(student);
            foreach (Student iteam in iteams)
            {
                iteam.Name = student.Name;
                iteam.Surname = student.Surname;
                iteam.TwoName = student.TwoName;
                iteam.NumberClass = student.NumberClass;
                iteam.LetterClass = student.LetterClass;
                ap.Students.Update(iteam);
                ap.SaveChanges();
            }
        }
        public void PrintAll(ApplicationContext ap)
        {
            var data = ap.Students.ToList();
            foreach (Student entry in data)
                Console.WriteLine($"{entry.Id})  {entry.Name} {entry.Surname} {entry.TwoName} - {entry.NumberClass}{entry.LetterClass}");
        }
        public void PrintAllIdenticalPeople(ApplicationContext ap)
        {
            Console.WriteLine("Введите цифру: ");
            int number = Convert.ToInt32(Console.ReadLine());
            var student = ap.Students.ToList();
            var item = from p in student
                       where p.NumberClass == number
                       select p;
            foreach (Student entry in item)
                Console.WriteLine($"{entry.Id})  {entry.Name} {entry.Surname} {entry.TwoName} - {entry.NumberClass}{entry.LetterClass}");
        }
    }
}
