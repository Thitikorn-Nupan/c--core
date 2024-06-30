using System;
using MySql.Data.MySqlClient;
using UnderstandCShap.configuration;
using UnderstandCShap.entities;
using UnderstandCShap.services; // using System means that we can use classes from the System namespace.
namespace UnderstandCShap
{
    /*
     public is visible from wherever.
     internal is visible only within an assembly. 
    */
    internal class Program
    {
        private MyMath myMath;
        private StudentService studentService;
        private GadgetService gadgetService;

        public Program()
        {
            // myMath = new MyMath();
            gadgetService = new GadgetService();

        }

        private void displayMyMath()
        {
            // Console.WriteLine("5 x 5 = "+myMath.multiple(5,5));
            // Console.WriteLine(myMath.multiplyTable(5));
            // Console.WriteLine(myMath.factorial(5));
            // Console.WriteLine("90 x 5 = " + myMath.multiple(y : 5, x: 90)); // can set name args 
        }

        private void displayStudent()
        {
            // student.Fullname = "";
            // Console.WriteLine(_studentService.getStudent().ToString());
            // List collection use the same java
            // List<Student> students = studentService.getStudents();
            // string room = "9901";
            // foreach (Student student in students)
            // {
            //     student.Room = room;
            //     Console.WriteLine(student+" stays on class "+student.Room);
                /*
                 Student = [Id : 1, fullname : alex slider, age : 33]
                 Student = [Id : 2, fullname : mark ryder, age : 23]
                 Student = [Id : 3, fullname : json rider, age : 29]
                */
            // }
        }


        private void displayGadgetService()
        {
            // **** Reads ****
            /*List<Gadget> gadgets = gadgetService.getAllGadgets();
            foreach (Gadget gadget in gadgets)
            {
                Console.WriteLine(gadget);
            }*/


            // **** Read *****
            /*Gadget gadget = gadgetService.getGadgetById("G003");
            Console.WriteLine(gadget);*/



            // **** Create ****
            /*Gadget gadget = new Gadget("G031", "OMEN 24(Monitor)", "ASUS", 3500.01F, 100);
            Console.WriteLine(gadgetService.saveGadget(gadget));*/


            // **** Update ****
            /*Gadget gadget = new Gadget("", "OMEN 24(Monitor)", "ASUS", 3500.01F, 110);
            string gid = "G031";
            Console.WriteLine(gadgetService.editGadget(gadget, gid));*/



            // **** Delete ****
            /*string gid = "G031";
            Console.WriteLine(gadgetService.removeGadgetById(gid));*/
        }

        private static void Main(string[] args)  {
            new Program().displayGadgetService();
        }
            


    }
}