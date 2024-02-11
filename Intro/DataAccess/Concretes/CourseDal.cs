using Intro.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro.DataAccess.Concretes;

public class CourseDal
{
    List<Course> courses;
    public CourseDal()
    {
        Course course1 = new Course();
        course1.Id = 1;
        course1.Name = "C#";
        course1.Description = ".NET 8 vs...";
        course1.Price = 0;

        Course course2 = new Course();
        course2.Id = 2;
        course2.Name = "JAVA";
        course2.Description = "Java 17 ....";
        course2.Price = 10;

        Course course3 = new Course();
        course3.Id = 3;
        course3.Name = "Python";
        course3.Description = "Python 3.12...";
        course3.Price = 20;

        courses = new List<Course> { course1, course2, course3 };
    }
    public List<Course> GetAll()
    {
        //sql öğren :)
        //burada db işlemleri yapılır

        return courses;
    }

    public void Add(Course course)
    {
        courses.Add(course);
    }
}
