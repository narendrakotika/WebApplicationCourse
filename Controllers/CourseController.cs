using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Web;
using System.Web.Mvc;
using WebApplicationCourse.Models;

namespace WebApplicationCourse.Controllers
{
    public class CourseController : Controller
    {
        // GET: Course
        static List<Course> listCourses = new List<Course>()
        {
        new Course(){CId=1, CName="Narendra",CFee=5000,Technology="Dotnet",CStartDate= new DateTime(day: 23, month:1, year: 2023),CEndDate= new DateTime(day:23, month:5,year:2023) },
          new Course(){CId=2, CName="Sai",CFee=10000,Technology="DataScience",CStartDate= new DateTime(day: 20, month:2, year: 2022),CEndDate= new DateTime(day:20, month:7,year:2022) },
            new Course(){CId=3, CName="Suresh",CFee=11000,Technology="Full Stack",CStartDate= new DateTime(day: 12, month:3, year: 2021),CEndDate= new DateTime(day:12, month:9,year:2021) },
              new Course(){CId=4, CName="Satish",CFee=7000,Technology="Devops",CStartDate= new DateTime(day: 14, month:4, year: 2019),CEndDate= new DateTime(day:15, month:10,year:2019) },
                new Course(){CId=5, CName="Dinesh",CFee=8000,Technology="Cloud",CStartDate= new DateTime(day: 17, month:5, year: 2020),CEndDate= new DateTime(day:20, month:11,year:2020) }
       };
        public ActionResult Index()
        {
            return View(listCourses);
        }
    }
}