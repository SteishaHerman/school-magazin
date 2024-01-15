using SchoolMagazine;
using SchoolMagazine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolMagazine
{
    public class InformationStudent : IInformationStudent
    {
        public void Decoreshion()
        {
            Console.WriteLine("\t******************************************");
            Console.WriteLine("\t\tМИНСКАЯ СРЕДНЯЯ ШКОЛА\n");
            Console.Write("\t******************************************\n");
        }
        public int MenuInProgramm()
        {
            Console.WriteLine("\n\tВыберите цифру:\n\t1)Вывести список учащихся \n\t2)Добавить запись \n\t3)Удалить запись \n\t4)Редактировать запись\n\t" +
                "5)Вывести учеников с одной параллели \n\t6)Вывести возможные функции \n\t7)Выход");
            Console.Write("\n\t");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            return number;
        }
        public int MenuInFunction()
        {
            Console.WriteLine
           (
               "\n\t1) Вывести общее количество школьниов.\n\t2) Вывести имена всех пользователей начинающихся на введённую букву\n\t3) Имена всех пользователей " +
               "старше введённого класа\n\t4) Фамилии всех школьников(отсортированные)\n\t5) Учащихся с незаполненным именем.\n\t6) Вывести классы и количество учащихся в них" +
               "\n\t7) Вывести учителей и их иучащихся (учителя отсортированны по количеству учеников) \n\t8) Предмет который изучает больше всего учеников.");
            int userNumber = Convert.ToInt32(Console.ReadLine());
            return userNumber;
        }
        public Student InformationAboutStudent(Student student)
        {
            new Student();
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

        public void InformationInFunction(List<Student>people)
        {
            foreach (Student student in people)
            {
                Console.WriteLine("\t" + student.Name + " " + student.TwoName + " " + student.Surname);
            }
        }
    }
}

