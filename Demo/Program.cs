using Demo.Contexts;
using Demo.Entities;
using Microsoft.EntityFrameworkCore;

namespace Demo
{
    internal class Program
    {
        static void Main()
        {
            using CompanyDbContext dbContext = new CompanyDbContext();

            #region CRUD operations
            //CRUD operations
            //dbContext.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.TrackAll;

            #region Insert
            // Employee E01 = new Employee() { Name = "Ahmed", Age = 22, Salary = 8_000, Email = "Ahmed@Gmail.com" };
            // Employee E02= new Employee() {Name="Nadia",Age=23,Salary=5_000,Email="Nadia@Gmail.com" };


            //Console.WriteLine(dbContext.Entry(E01).State);

            //dbContext.Employees.Add(E01);
            //dbContext.Employees.Add(E02);
            //Console.WriteLine(dbContext.Entry(E01).State);
            ////dbContext.Set<Employee>().Add(E01);
            ////dbContext.Add(E01);
            ////dbContext.Entry(E01).State = EntityState.Added;

            //dbContext.SaveChanges();
            //Console.WriteLine(dbContext.Entry(E01).State);

            //Console.WriteLine($"EmployeeId={E02.Id}"); 
            #endregion

            #region Select
            //var employee = (from E in dbContext.Employees
            //                where E.Id == 1
            //                select E).AsNoTracking().FirstOrDefault();

            //Console.WriteLine(employee?.Name ?? "NA");
            //Console.WriteLine(dbContext.Entry(employee).State); 
            #endregion

            #region Update
            //var employee = (from E in dbContext.Employees
            //                where E.Id == 1
            //                select E).FirstOrDefault();

            //if (employee is not null)
            //{
            //    Console.WriteLine(dbContext.Entry(employee).State);//unchanges

            //    employee.Name = "Hamada";

            //    Console.WriteLine(dbContext.Entry(employee).State);//Modified 



            //}

            //dbContext.SaveChanges();
            //Console.WriteLine(dbContext.Entry(employee).State); //Unchanged 
            #endregion

            #region Delete
            //var employee = (from E in dbContext.Employees
            //                where E.Id == 1
            //                select E).FirstOrDefault();

            //if (employee is not null)
            //{
            //    Console.WriteLine(dbContext.Entry(employee).State);//unchanges

            //    dbContext.Remove(employee);

            //    Console.WriteLine(dbContext.Entry(employee).State);//Modified 



            //} 
            #endregion

            ///{
            ///    //Crud operations
            ///}
            ///finally
            ///{
            ///    dbContext.Dispose();//Dispose |release|close database connction
            ///}

            #endregion
        
            using InheritanceDBContext dBContext= new InheritanceDBContext();

            FullTimeEmployee fullTime =new FullTimeEmployee() { FullName="Ahmed",Salary=6_000,HiringDate=DateOnly.FromDateTime(DateTime.Now)};
            PartTimeEmployee partTime = new PartTimeEmployee() { FullName = "Aliaa", HourRate = 300, CountOfHours = 39 };

            dBContext.Persons.Add(fullTime);
            dBContext.Persons.Add(partTime);

            dbContext.SaveChanges();

            var fullTimeEmployee=from F in dBContext.Persons.OfType<FullTimeEmployee>()
                                 select F;
             var partTimeEmployee=from P in dBContext.Persons.OfType<PartTimeEmployee>()
                                 select P;

            foreach (var f in fullTimeEmployee)
                Console.WriteLine($"{f.Id}::{f.FullName}::{f.Salary}");
            
            foreach (var f in partTimeEmployee)
                Console.WriteLine($"{f.Id}::{f.FullName}::{f.HourRate}");
        }
    }
}
