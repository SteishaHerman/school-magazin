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
        public IInformationStudent _studentInfo;
        public StudentRepository(IInformationStudent studentInfo) 
        {
            _studentInfo = studentInfo;
        }
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
            if (index == -1) _studentInfo.NotFoundStudent();
            else
            {
                lines.RemoveAt(index);
                File.WriteAllLines(@"C:\Users\Agerman\source\repos\school magazine\student.txt", lines);
            }
        }

        public void EditEntry(Student student)
        {
            int index = -1;
            var allPeople = File.ReadAllLines(@"C:\Users\Agerman\source\repos\school magazine\student.txt").ToList();
            string oldInformation = student.Id + " " + student.Surname + " " + student.Name + " " + student.TwoName + " " + student.NumberClass + " " + student.LetterClass;
            index = allPeople.IndexOf(oldInformation);
            if (index == -1) _studentInfo.NotFoundStudent();
            else
            {
                _studentInfo.EditEntry();
                student = _studentInfo.InformationAboutStudent();
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
                while (line != null)
                {
                    _studentInfo.PrintAll(line);
                    line = readFile.ReadLine();
                }
            }
        }
        public void PrintAllIdenticalPeople()
        {
            int number = _studentInfo.EnterIdenticalPeople();
            var allPeople = File.ReadAllLines(@"C:\Users\Agerman\source\repos\school magazine\student.txt").ToList();
            string[] oneChild;
            foreach (var item in allPeople)
            {
                oneChild = item.Split(" ");
                if (oneChild[4] == Convert.ToString(number)) _studentInfo.PrintIdenticalPeople(item);
            }
        }
    }
}
