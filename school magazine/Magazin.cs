using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace school_magazine
{
    internal class Magazin
    {
        public void ReadEntry() 
        {
            string line;
            StreamReader readFile = new StreamReader(@"C:\Users\Agerman\source\repos\school magazine\student.txt");
            line = readFile.ReadLine();
            Console.WriteLine("\t******************************************");
            while (line != null)
            {
                Console.WriteLine("\t" + line);
                line = readFile.ReadLine();
            }
            Console.WriteLine("\t******************************************");
            readFile.Close();
        }
        public void NewEntry() 
        {
            var student = new Student();
            StreamWriter writeFile = File.AppendText(@"C:\Users\Agerman\source\repos\school magazine\student.txt");
            writeFile.WriteLine(student.InformationAboutStudent());
            writeFile.Close();
        }
        public void EditEntry()
        {
            int index = -1;
            var student = new Student();
            var student2 = new Student();
            var allPeople = File.ReadAllLines(@"C:\Users\Agerman\source\repos\school magazine\student.txt").ToList();
            Console.WriteLine("\tВведите старые данные ученика которые хотите изменить");
            string oldInformation = student.InformationAboutStudent();
            index = allPeople.IndexOf(oldInformation);
            if (index == -1) Console.WriteLine("\tТакого учащегося нет!");
            else
            {
                Console.WriteLine("\tВведите новые данные");
                string newInformation = student2.InformationAboutStudent();
                allPeople[index]= newInformation;
                File.WriteAllLines(@"C:\Users\Agerman\source\repos\school magazine\student.txt", allPeople);
            }
        }
        public void DeleteEntry() 
        {
            int index= -1;
            var student = new Student();
            var lines = File.ReadAllLines(@"C:\Users\Agerman\source\repos\school magazine\student.txt").ToList();
            string value = student.InformationAboutStudent();
            index = lines.IndexOf(value);
            if (index == -1)
            Console.WriteLine("Такого учащегося нет! ");
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
           foreach(var item in  allPeople)
           {
                oneChild = item.Split(" ");
                if (oneChild[4] == Convert.ToString(number)) Console.WriteLine("\t"+item);
           } 
        }
    }
}
