using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using School_Magazine;
using SchoolMagazine.Models;

 
namespace SchoolMagazine
{
    internal interface IStudentRepository
    {
        void CreateNewEntry(Student student, ApplicationContext ap);
        void DeleteEntry(Student student, ApplicationContext ap);
        void EditEntry(Student student, ApplicationContext ap);
    }
}
 
