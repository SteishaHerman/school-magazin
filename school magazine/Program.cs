using schoolMagazine;
using schoolMagazine.models;

InformationStudent studentInfo = new InformationStudent();
StudentRepository studentRepository = new StudentRepository();

studentInfo.Decoreshion();

while (true)
{
    int number = studentInfo.Menu();
    if (number == 6) break;
    if (number == 1)
    {
        studentRepository.PrintAll(studentInfo);
        continue;
    }
    if (number == 5)
    {
        studentRepository.PrintAllIdenticalPeople(studentInfo);
        continue;
    }
    Student student;
    student = studentInfo.InformationAboutStudent();
    if (number == 2) studentRepository.CreateNewEntry(student);
    if (number == 3) studentRepository.DeleteEntry(student, studentInfo);
    if (number == 4) studentRepository.EditEntry(student, studentInfo);
}


