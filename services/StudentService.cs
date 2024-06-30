using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnderstandCShap.entities;

namespace UnderstandCShap.services
{
    public class StudentService
    {
        public Student getStudent()
        {
            return new Student(1, "alex slider", 33);
        }

        public List<Student> getStudents()
        {
            List<Student> students = new List<Student>();
            students.Add(new Student(1, "alex slider", 33));
            students.Add(new Student(2, "mark ryder", 23));
            students.Add(new Student(3, "json rider", 29));
            return students;
        }

    }
}
