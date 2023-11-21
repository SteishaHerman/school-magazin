using school_magazine.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace school_magazine
{
    internal class StudentRepository : IStudentRepository
    {
        public StudentRepository() { }
        public void CreateNewEntry(Student student)
        {
            using (StreamWriter writeFile = File.AppendText(@"C:\Users\Agerman\source\repos\school magazine\student.txt"))
            {
                writeFile.Write(student.Id+" ");
                writeFile.Write(student.Surname+ " ");
                writeFile.Write(student.Name + " ");
                writeFile.Write(student.TwoName + " ");
                writeFile.Write(student.NumberClass + " ");
                writeFile.WriteLine(student.LetterClass);
            }
        }

        public void DeleteEntry(Student student)
        {
            int index = -1;
            var lines = File.ReadAllLines(@"C:\Users\Agerman\source\repos\school magazine\student.txt").ToList();
            string value = student.Id+" "+student.Surname+" "+student.Name+" "+student.TwoName+" "+student.NumberClass+" "+student.LetterClass;
            index = lines.IndexOf(value);
            if (index == -1)
                Console.WriteLine("Такого учащегося нет!");
            else
            {
                lines.RemoveAt(index);
                File.WriteAllLines(@"C:\Users\Agerman\source\repos\school magazine\student.txt", lines);
            }
        }

        public void EditEntry(Student student, InformationStudent studentInfo)
        {
            int index = -1;
            var allPeople = File.ReadAllLines(@"C:\Users\Agerman\source\repos\school magazine\student.txt").ToList();
            string oldInformation = student.Id + " " + student.Surname + " " + student.Name + " " + student.TwoName + " " + student.NumberClass + " " + student.LetterClass;
            index = allPeople.IndexOf(oldInformation);
            if (index == -1) Console.WriteLine("\tТакого учащегося нет!");
            else
            {
                Console.WriteLine("\tВведите новые данные");
                student = studentInfo.InformationAboutStudent();
                string newInformation = student.Id + " " + student.Surname + " " + student.Name + " " + student.TwoName + " " + student.NumberClass + " " + student.LetterClass;
                allPeople[index] = newInformation;
                File.WriteAllLines(@"C:\Users\Agerman\source\repos\school magazine\student.txt", allPeople);
            }
        }
        public void PrintAll()
        {
            string line;
            using (StreamReader readFile = new StreamReader(@"C:\Users\Agerman\source\repos\school magazine\student.txt"))
            {
                line = readFile.ReadLine();
                Console.WriteLine("\t******************************************");
                while (line != null)
                {
                    Console.WriteLine("\t" + line);
                    line = readFile.ReadLine();
                }
                Console.WriteLine("\t******************************************");
            }
        }
        public void PrintAllIdenticalPeople()
        {
            Console.Write("\tВведите класс: ");
            int number = Convert.ToInt32(Console.ReadLine());
            var allPeople = File.ReadAllLines(@"C:\Users\Agerman\source\repos\school magazine\student.txt").ToList();
            string[] oneChild;
            foreach (var item in allPeople)
            {
                oneChild = item.Split(" ");
                if (oneChild[4] == Convert.ToString(number)) Console.WriteLine("\t" + item);
            }
        }
    }
}








/*

 public void PrintEntry()
        {
            string line;
            using (StreamReader readFile = new StreamReader(@"C:\Users\Agerman\source\repos\school magazine\student.txt"))
            {
                line = readFile.ReadLine();
                Console.WriteLine("\t******************************************");
                while (line != null)
                {
                    Console.WriteLine("\t" + line);
                    line = readFile.ReadLine();
                }
                Console.WriteLine("\t******************************************");
            }
        }

        public void NewEntry(InformationStudent student)
        {
            student = new InformationStudent();
            using (StreamWriter writeFile = File.AppendText(@"C:\Users\Agerman\source\repos\school magazine\student.txt"))
            {
                writeFile.WriteLine(student.InformationAboutStudent());
            }
        }
        public void EditEntry(InformationStudent student)
        {
            int index = -1;
            var allPeople = File.ReadAllLines(@"C:\Users\Agerman\source\repos\school magazine\student.txt").ToList();
            Console.WriteLine("\tВведите старые данные ученика которые хотите изменить");
            string oldInformation = student.InformationAboutStudent();
            index = allPeople.IndexOf(oldInformation);
            if (index == -1) Console.WriteLine("\tТакого учащегося нет!");
            else
            {
                Console.WriteLine("\tВведите новые данные");
                string newInformation = student.InformationAboutStudent();
                allPeople[index] = newInformation;
                File.WriteAllLines(@"C:\Users\Agerman\source\repos\school magazine\student.txt", allPeople);
            }
        }
        public void DeleteEntry(InformationStudent student)
        {
            int index = -1;
            var lines = File.ReadAllLines(@"C:\Users\Agerman\source\repos\school magazine\student.txt").ToList();
            string value = student.InformationAboutStudent();
            index = lines.IndexOf(value);
            if (index == -1)
                Console.WriteLine("Такого учащегося нет!");
            else
            {
                lines.RemoveAt(index);
                File.WriteAllLines(@"C:\Users\Agerman\source\repos\school magazine\student.txt", lines);
            }
        }
        public void PrintPeople()
        {
            string[] oneChild;
            Console.Write("\tВведите класс: ");
            int number = Convert.ToInt32(Console.ReadLine());
            var allPeople = File.ReadAllLines(@"C:\Users\Agerman\source\repos\school magazine\student.txt").ToList();
            foreach (var item in allPeople)
            {
                oneChild = item.Split(" ");
                if (oneChild[4] == Convert.ToString(number)) Console.WriteLine("\t" + item);
            }
        }*/