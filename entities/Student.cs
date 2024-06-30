using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandCShap.entities
{
    public class Student : ClassRoom // Inheritance (Derived and Base Class)
    {
        private int id;
        private string fullname;
        private int age;

        public Student(int id, string fullname, int age)
        {
            this.id = id;
            this.fullname = fullname;
            this.age = age;
        }

        // *** getter / setter in c# we call properties
        public int Id // So went you access it's smart As, student.Id = 1 or log(student.Id)
        {
            get => id;
            set => id = value;
        }

        public string Fullname
        {
            get => fullname;
            set => fullname = value ?? throw new ArgumentNullException(nameof(value));
        }

        public int Age
        {
            get => age;
            set => age = value;
        }

        public override string ToString()
        {
            // use $ "<now you can read prop by {}>"
            return $"Student = [ Id : {Id} , fullname : {Fullname} , age : {Age} ]";
        }
    }
}
