using schoolMagazine.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace schoolMagazine
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

        public void DeleteEntry(Student student,InformationStudent studentInfo)
        {
            int index = -1;
            var lines = File.ReadAllLines(@"C:\Users\Agerman\source\repos\school magazine\student.txt").ToList();
            string value = student.Id+" "+student.Surname+" "+student.Name+" "+student.TwoName+" "+student.NumberClass+" "+student.LetterClass;
            index = lines.IndexOf(value);
            if (index == -1) studentInfo.NotFoundStudent();
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
            if (index == -1) studentInfo.NotFoundStudent();
            else
            {
                studentInfo.EditEntry();
                student = studentInfo.InformationAboutStudent();
                string newInformation = student.Id + " " + student.Surname + " " + student.Name + " " + student.TwoName + " " + student.NumberClass + " " + student.LetterClass;
                allPeople[index] = newInformation;
                File.WriteAllLines(@"C:\Users\Agerman\source\repos\school magazine\student.txt", allPeople);
            }
        }

        public void PrintAll(InformationStudent studentInfo)
        {
            string line;
            using (StreamReader readFile = new StreamReader(@"C:\Users\Agerman\source\repos\school magazine\student.txt"))
            {
                line = readFile.ReadLine();
                while (line != null)
                {
                    studentInfo.PrintAll(line);
                    line = readFile.ReadLine();
                }
            }
        }
        public void PrintAllIdenticalPeople(InformationStudent studentInfo)
        {
            int number = studentInfo.EnterIdenticalPeople();
            var allPeople = File.ReadAllLines(@"C:\Users\Agerman\source\repos\school magazine\student.txt").ToList();
            string[] oneChild;
            foreach (var item in allPeople)
            {
                oneChild = item.Split(" ");
                if (oneChild[4] == Convert.ToString(number)) studentInfo.PrintIdenticalPeople(item);
            }
        }
    }
}
