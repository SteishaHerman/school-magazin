using schoolMagazine.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace schoolMagazine
{        
    internal class InformationStudent
    {
        public void Decoreshion()
        {
            Console.WriteLine("\t******************************************");
            Console.WriteLine("\t\tМИНСКАЯ СРЕДНЯЯ ШКОЛА\n");
            Console.Write("\t******************************************\n");
        }
        public int Menu()
        {
            Console.WriteLine("\n\tВыберите цифру:\n\t1)Вывести список учащихся \n\t2)Добавить запись \n\t3)Удалить запись \n\t4)Редактировать запись\n\t5)Вывести учеников с одной параллели \n\t6)Выход");
            Console.Write("\n\t");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            return number;
        }
        public Student InformationAboutStudent()
        {
            Student student = new Student();
            Console.Write("\tВведите данные:\n\t1)Id: ");
            student.Id = Convert.ToInt32(Console.ReadLine());
            student.StudentStr += student.Id + " ";

            Console.Write("\n\t2)Фамилия школьника: ");
            student.Surname = Console.ReadLine();
            student.StudentStr += student.Surname + " ";

            Console.Write("\n\t3)Имя школьника: ");
            student.Name = Console.ReadLine();
            student.StudentStr += student.Name + " ";

            Console.Write("\n\t4)Отчество школьника: ");
            student.TwoName = Console.ReadLine();
            student.StudentStr += student.TwoName + " ";

            Console.Write("\n\t5)Номер класса: ");
            student.NumberClass = Console.ReadLine();
            student.StudentStr += student.NumberClass + " ";

            Console.Write("\n\t6)Буква класса: ");
            student.LetterClass = Console.ReadLine();
            student.StudentStr += student.LetterClass;
            Console.WriteLine();
            return student;
        }
        public void NotFoundStudent() => Console.WriteLine("\tТакого учащегося нет! ");
        public void EditEntry() => Console.WriteLine("\tВведите новые данные! ");
        public void PrintAll(string line) => Console.WriteLine("\t" + line);
        public int EnterIdenticalPeople()
        {
            Console.Write("\tВведите класс: ");
            int number = Convert.ToInt32(Console.ReadLine());
            return number;
        }
        public void PrintIdenticalPeople(string item) => Console.WriteLine("\t"+item);
    }

}
