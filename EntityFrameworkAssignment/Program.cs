using EntityFrameworkAssignment.DataContext;
using EntityFrameworkAssignment.Model;
using Microsoft.EntityFrameworkCore;
using System.Numerics;

namespace EntityFrameworkAssignment
{
     class program
    {
       static void Main(string[] args)
        {
            try
            {
                using (Context context = new Context())
                {
                    // Add And Updat Remove Employee
                    Employee employee = new Employee()
                    {
                        BD_Day = "3",
                        BD_Year = "1989",
                        BD_Month = "12",
                        Gender = "F",
                        Name = "Doha",
                        postion = "Salse",
                    };
                    context.Employees.Add(employee);
                    context.SaveChanges();
                    Console.WriteLine("Done");

                    Employee employee2 = new Employee()
                    {
                        BD_Day = "4",
                        BD_Year = "1989",
                        BD_Month = "6",
                        Gender = "F",
                        Name = "Nedal",
                        postion = "Markting",

                    };
                    context.Employees.Add(employee2);
                    context.SaveChanges();
                    Console.WriteLine("Done");
                    //var employeeToUpdate = context.Employees.FirstOrDefault(e => e.Id == 3);
                    //employeeToUpdate.Gender = "M";
                    //context.Employees.Update(employeeToUpdate);
                    //var employeeRemove = context.Employees.FirstOrDefault(e => e.Id == 1);
                    //context.Employees.Remove(employeeToUpdate);
                    // Add AirLin
                    AirLine airLine = new AirLine()
                    {
                        Name = "Egypt Airline",
                        Address = "123 Main St",
                        Count_Person = 100,
                    };

                    var AirCraft = new AirCraft()
                    {
                        Capsity = 200,
                        Model = "Example Model",
                        Maj_Pailot = "Main Pilot",
                        Assistant = "Assistant Name",
                        Host_1 = "Host 1 Name",
                        Host_2 = "Host 2 Name"
                        
                    };
                    context.AirLines.Add(airLine);
                    context.SaveChanges();
                    Console.WriteLine("Succed Add AirLin");
                    context.AirCraft.Add(AirCraft);
                    context.SaveChanges();
                    Console.WriteLine("Succed Add airCrafts");


                    // var airLineInclude = context.AirLines
                    //.Include(a => a.AirCrafts)
                    //.FirstOrDefault(a => a.Id == 1);
                    // context.SaveChanges();

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                if (ex.InnerException != null)
                {
                    Console.WriteLine("Inner Exception: " + ex.InnerException.Message);
                }
            }
       }

     }

}

