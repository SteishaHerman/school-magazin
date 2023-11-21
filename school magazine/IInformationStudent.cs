using schoolMagazine.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace schoolMagazine
{
    internal interface IInformationStudent
    {
        public Student InformationAboutStudent();
        public void NotFoundStudent();
        public void EditEntry();
        public void PrintAll(string line);
        public int EnterIdenticalPeople();
        public void PrintIdenticalPeople(string item);

    }
}
