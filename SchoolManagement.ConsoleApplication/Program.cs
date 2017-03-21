using SchoolManagement.Model;
using SchoolManagement.Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentManager manager = new StudentManager();
            
           Student student = manager.GetStudent(1);
            Console.WriteLine("Name:"+student.Name +"\nAddress : "+student.Address+"\nPhone : "+student.Phone);
            Console.Read();
        }
    }
}
