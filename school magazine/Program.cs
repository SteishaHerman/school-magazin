using SchoolMagazine;
using SchoolMagazine.Models;
using Microsoft.Extensions.Configuration;
using System.Configuration;
using School_Magazine;

InformationStudent studentInfo = new InformationStudent(); 
StudentRepository studentRepository = new StudentRepository(studentInfo);

IConfiguration Configuration = new ConfigurationBuilder()
   .AddJsonFile("config.json", optional: true, reloadOnChange: true)
   .AddEnvironmentVariables()
   .AddCommandLine(args)
   .Build();
 
string section = Configuration["ConnectionStrings:KeyOne"];
ApplicationContext ap = new ApplicationContext(section);

studentInfo.Decoreshion();

while (true)
{
    int number = studentInfo.Menu();
    if (number == 6) break;
    if (number == 1)
    {
        studentRepository.PrintAll(ap);
        continue;
    }
    if (number == 5)
    {
        studentRepository.PrintAllIdenticalPeople(ap);
        continue;
    }
    Student student = new Student();
    if (number == 2) studentRepository.CreateNewEntry(student, ap);
    try
    {
        if (number == 3) studentRepository.DeleteEntry(student, ap);
   }
    catch (Exception) { Console.WriteLine("\tТакого школьника нет!"); }
    if (number == 4)
    {
        try
        {
            studentRepository.EditEntry(student, ap);
        }
        catch(Exception e) { Console.WriteLine("\tТакого школьника нет"); }
    }
}
