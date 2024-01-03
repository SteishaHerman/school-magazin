using SchoolMagazine;
using SchoolMagazine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolMagazine
{
    internal class InformationStudent : IInformationStudent
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
        public Student InformationAboutStudent(Student student)
        {
            new Student();
            Console.Write("\tВведите данные:\n\t1)Id: ");
            student.Id = Convert.ToInt32(Console.ReadLine());

            Console.Write("\n\t2)Фамилия школьника: ");
            student.Surname = Console.ReadLine();

            Console.Write("\n\t3)Имя школьника: ");
            student.Name = Console.ReadLine();

            Console.Write("\n\t4)Отчество школьника: ");
            student.TwoName = Console.ReadLine();

            Console.Write("\n\t5)Номер класса: ");
            student.NumberClass = Convert.ToInt32(Console.ReadLine());

            Console.Write("\n\t6)Буква класса: ");
            student.LetterClass = Console.ReadLine();
            Console.WriteLine();
            return student;
        }
        public void EditEntry() => Console.WriteLine("\tВведите новые данные! ");
    }
}

