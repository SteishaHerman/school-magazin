using school_magazine.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace school_magazine
{        
    internal class InformationStudent
    {
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
    }
}
