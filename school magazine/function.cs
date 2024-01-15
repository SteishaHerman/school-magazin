using Microsoft.EntityFrameworkCore;
using School_Magazine;
using School_Magazine.Migrations;
using SchoolMagazine;
using SchoolMagazine.Models;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace School_Magazine
{
    public class function
    {
        ApplicationContext apx;
        CollectionSubject oneSubject;
        public function(ApplicationContext apx)
        {
            this.apx = apx;
        }
        public void ListFunction(InformationStudent inf)
        {
            int userNumber = inf.MenuInFunction();
            switch (userNumber)
            {
                case 1:
                    PrintAllPeople();
                    break;
                case 2:
                    PrintWithIdenticalLetter(inf);
                    break;
                case 3:
                    PrintPeopleOlderThisClass();
                    break;
                case 4:
                    PrintAllSurname();
                    break;
                case 5:
                    PrintPeooleWithoutName();
                    break;
                case 6:
                    PrintClassWithPeople();
                    break;
                case 7:
                    PrintTeachersWithPeople();
                    break;
                case 8:
                    PrintMostPopularSubject();
                    break;
                case 9:
                    break;
            }
        }

        //////////////////////////////////

        void PrintAllPeople() //1
        {
            int peopleAll = (from p in apx.Students
                             select p.Id).Count();
            Console.WriteLine("Всего учеников в школе: " + peopleAll);

        }
        void PrintWithIdenticalLetter(InformationStudent inf) //2
        {
            Console.Write("Введите букву для поиска: ");
            string userLetter = Console.ReadLine();
            var people = from p in apx.Students
                         where EF.Functions.Like(p.Name, $"{userLetter}%")
                         select p;
            foreach (Student student in people)
            {
                Console.WriteLine("\t" + student.Surname + " " + student.TwoName + " " + student.Name);
            }
        }
        void PrintPeopleOlderThisClass() //3
        {
            Console.Write("Введите класс: ");
            int userNumber = Convert.ToInt32(Console.ReadLine());
            var people = from p in apx.Students
                         where p.NumberClass > userNumber
                         select p;
            foreach (Student student in people)
            {
                Console.WriteLine("\t" + student.Surname + " " + student.TwoName + " " + student.Name);
            }
        }
        void PrintAllSurname() //4
        {
            var people = (from p in apx.Students
                          orderby p.Name
                          select p).ToList();
            people.Reverse();
            foreach (Student student in people)
            {
                Console.WriteLine("\t" + student.Name);
            }
        }
        void PrintPeooleWithoutName() //5 
        {
            var people = from p in apx.Students
                         where p.Surname == ""
                         select p;
            foreach (Student student in people)
            {
                Console.WriteLine("1) " + student.Name);
            }
        }
        void PrintClassWithPeople() //6
        {
            var peopleClass = (from p in apx.Students
                               select p.NumberClass).Distinct().ToList();
            Console.WriteLine();
            for (int i = 0; i < peopleClass.Count; i++)
            {
                int numberClass = peopleClass[i];
                var personCount = (from p in apx.Students
                                   where p.NumberClass == numberClass
                                   select p).Count();
                Console.WriteLine($"Класс {peopleClass[i]} количество учеников:{personCount}");
            }
        }
        void PrintTeachersWithPeople() //7
        {
            var people = apx.Teachers
            .Include(teacher => teacher.Students)
            .ToList()
            .OrderBy(teacher => teacher.Students.Count)
            .ToList();

            for (int i = 0; i < people.Count; i++)
            {
                var person = people[i];
                Console.WriteLine($"Учитель {person.Name}, студенты: ");
                if (person.Students.Count == 0) Console.WriteLine("Студентов нет");
                for (int j = 0; j < person.Students.Count; j++)
                {
                    Console.WriteLine($"{person.Students[j].Name}");
                }
            }
        }
        void PrintMostPopularSubject() //8
        {
            var people = apx.Students.Include(p => p.Teachers).ToList();
            var subjectAll = apx.Subjects.Include(p => p.Teacher).ToList();
            List<string> subject = new List<string>();
            List<CollectionSubject> collectionSubjects = new List<CollectionSubject>();
            foreach (var person in people)
            {
                foreach (var teacher in person.Teachers)
                {
                    var id = teacher.Id;
                    foreach (var sub in teacher.Subjects)
                    {
                        if (id == Convert.ToInt32(sub.Teacher.Id))
                        {
                            subject.Add(sub.NameSubject);
                        }
                    }
                }
            }

            for (int i = 0; i < subjectAll.Count(); i++)
            {
                int count = 0;
                string sub = subjectAll[i].NameSubject;
                string nameSubject = "";
                foreach (var s in subject)
                {
                    if (s == sub)
                    {
                        count++;
                        nameSubject = s;
                    }
                }
                oneSubject = new CollectionSubject();
                oneSubject.SubjectName = nameSubject;
                oneSubject.CountSubject = count;
                collectionSubjects.Add(oneSubject);
            }
            int maxPopular = 0;
            for (int i = 0; i < collectionSubjects.Count; i++)
            {
                if (collectionSubjects[i].CountSubject > maxPopular) maxPopular = collectionSubjects[i].CountSubject;
            }
            List<string> nameMostPopularSubject = new List<string>();
            for (int i = 0; i < collectionSubjects.Count; i++)
            {
                if (maxPopular == collectionSubjects[i].CountSubject) nameMostPopularSubject.Add(collectionSubjects[i].SubjectName);
            }
            for (int i = 0; i < nameMostPopularSubject.Count; i++) Console.WriteLine(nameMostPopularSubject[i]);
        }
    }
}



