using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SchoolManagement.Manager;
using SchoolManagement.Model;

namespace SchoolManagement.RestService.Controllers
{
    public class StudentController : ApiController
    {
        StudentManager manager = new StudentManager();
        public List<Student> Get()
        {
            List<Student> students = manager.GetStudents();

            return students;
        }

        [HttpPost]
        public void Post(Student student)
        {
           manager.Add(student);
         }
    }
}
