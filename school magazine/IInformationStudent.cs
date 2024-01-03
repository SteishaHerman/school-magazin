using SchoolMagazine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolMagazine
{
    internal interface IInformationStudent
    {
        public Student InformationAboutStudent(Student student);
        public void EditEntry();
    }
}
