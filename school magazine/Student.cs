using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace school_magazine
{
    internal class Student
    {
        string id;
        string name;
        string surname;
        string twoName;
        string numberClass;
        string letterClass;
        string student="";
        public string InformationAboutStudent()
        {
            string readInf;
            Console.Write("\tВведите данные:\n\t1)Id: ");
            id = Console.ReadLine();
            student += id+" ";

            Console.Write("\n\t2)Фамилия школьника: ");
            surname = Console.ReadLine();
            student += surname+" ";

            Console.Write("\n\t3)Имя школьника: ");
            name = Console.ReadLine();
            student += name+" ";

            Console.Write("\n\t4)Отчество школьника: ");
            twoName = Console.ReadLine();
            student += twoName + " ";

            Console.Write("\n\t5)Номер класса: ");
            numberClass = Console.ReadLine();
            student += numberClass+ " ";

            Console.Write("\n\t6)Буква класса: ");
            letterClass = Console.ReadLine();
            student += letterClass;
            Console.WriteLine();
            return student;
        }
    }
}
