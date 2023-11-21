using school_magazine;
using school_magazine.models;

Console.WriteLine("\t******************************************");
Console.WriteLine("\t\tМИНСКАЯ СРЕДНЯЯ ШКОЛА\n");
Console.Write("\t******************************************\n");
while (true)
{
    Console.WriteLine("\n\tВыберите цифру:\n\t1)Вывести список учащихся \n\t2)Добавить запись \n\t3)Удалить запись \n\t4)Редактировать запись\n\t5)Вывести учеников с одной параллели \n\t6)Выход");
    Console.Write("\n\t");
    int number = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();
    StudentRepository studentRepository = new StudentRepository();
    if (number == 6) break;
    if (number == 1)
    {
        studentRepository.PrintAll();
        continue;
    }
    if (number == 5)
    {
        studentRepository.PrintAllIdenticalPeople();
        continue;
    }
    Student student;
    InformationStudent studentInfo = new InformationStudent();
    student = studentInfo.InformationAboutStudent();
    if (number == 2) studentRepository.CreateNewEntry(student);
    if (number == 3) studentRepository.DeleteEntry(student);
    if (number == 4) studentRepository.EditEntry(student, studentInfo);
}

