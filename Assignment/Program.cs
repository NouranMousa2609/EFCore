using Assignment.Contexts;
using Assignment.Entities;

namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using ITIDBContext dbContext = new ITIDBContext();
            #region ADD
            //Student S01 = new Student
            //{

            //    FName = "John",
            //    LName = "Doe",
            //    Address = "123 Main St",
            //    Age = 20
            //};

            //dbContext.Add(S01);

            //Instructor instructor = new Instructor
            //{

            //    Name = " Alice Johnson",
            //    Bouns = 1500.00m,
            //    Salary = 50000.00m,
            //    Address = "456 Elm St",
            //    HourRate = 50.00m
            //};
            //dbContext.Add(instructor);

            //Course course = new Course
            //{

            //    Duration = 12,
            //    Name = "Introduction to Programming",
            //    Description = "A beginner's course in programming."
            //};
            //dbContext.Add(course);

            //Topic topic = new Topic
            //{

            //    Name = "Introduction to C#"
            //};
            //dbContext.Add(topic);

            //Department department = new Department
            //{

            //    Name = "IT"
            //};
            //dbContext.Add(department);
            #endregion

            #region Select
            //var student = (from E in dbContext.Students
            //               where E.Id == 1
            //               select E).FirstOrDefault();

            //Console.WriteLine(student?.FName ?? "NA");



            //var course = (from E in dbContext.Courses
            //               where E.Id == 1
            //               select E).FirstOrDefault();

            //Console.WriteLine(course?.Name ?? "NA");



            //var instructor = (from E in dbContext.Instructors
            //               where E.Id == 1
            //               select E).FirstOrDefault();

            //Console.WriteLine(instructor?.Name ?? "NA");



            //var department = (from E in dbContext.Departments
            //               where E.Id == 1
            //               select E).FirstOrDefault();

            //Console.WriteLine(department?.Name ?? "NA");


            //var topic = (from E in dbContext.Topics
            //                  where E.Id == 1
            //                  select E).FirstOrDefault();

            //Console.WriteLine(topic?.Name ?? "NA");

            #endregion

            #region Update
            //var student = (from E in dbContext.Students
            //                where E.Id == 1
            //                select E).FirstOrDefault();

            //if (student is not null)
            //{


            //    student.FName = "Hamada";
            //}

            //var instructor = (from E in dbContext.Instructors
            //               where E.Id == 1
            //               select E).FirstOrDefault();

            //if (instructor is not null)
            //{


            //    instructor.Name = "Hamada";
            //}

            //var topic = (from E in dbContext.Topics
            //                  where E.Id == 1
            //                  select E).FirstOrDefault();

            //if (topic is not null)
            //{


            //    topic.Name = "Hamada";
            //}

            //var department = (from E in dbContext.Departments
            //                  where E.Id == 1
            //                  select E).FirstOrDefault();

            //if (department is not null)
            //{


            //    department.Name = "Hamada";
            //}

            //var course = (from E in dbContext.Courses
            //                  where E.Id == 1
            //                  select E).FirstOrDefault();

            //if (course is not null)
            //{


            //    course.Name = "Hamada";
            //} 
            #endregion

            #region Delete
            //var student = (from E in dbContext.Students
            //               where E.Id == 1
            //               select E).FirstOrDefault();
            //if (student != null) 
            //dbContext.Remove(student);

            //var instructor = (from E in dbContext.Instructors
            //               where E.Id == 1
            //               select E).FirstOrDefault();
            //if (instructor != null)
            //    dbContext.Remove(instructor);

            //var topic = (from E in dbContext.Topics
            //               where E.Id == 1
            //               select E).FirstOrDefault();
            //if (topic != null)
            //    dbContext.Remove(topic);

            //var department = (from E in dbContext.Departments
            //               where E.Id == 1
            //               select E).FirstOrDefault();
            //if (department != null)
            //    dbContext.Remove(department);

            //var course = (from E in dbContext.Courses
            //               where E.Id == 1
            //               select E).FirstOrDefault();
            //if (course != null)
            //    dbContext.Remove(course); 
            #endregion


            dbContext.SaveChanges();
        }
    }
}
