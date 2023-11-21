using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using school_magazine.models;

 
namespace school_magazine
{
    internal interface IStudentRepository
    {
        void CreateNewEntry(Student student);
        void DeleteEntry(Student student);
        void EditEntry(Student student,InformationStudent infStudent);
    }
}
 