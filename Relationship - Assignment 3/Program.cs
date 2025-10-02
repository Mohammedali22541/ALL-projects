using Microsoft.EntityFrameworkCore;
using Relationship___Assignment_3.DataBaseContext;
using Relationship___Assignment_3.Models;
using System;
using System.ComponentModel.DataAnnotations;
using System.Numerics;

namespace Relationship___Assignment_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
           using AirlineDbContext airlineDbContext = new AirlineDbContext();


            //airlineDbContext.Database.Migrate();

            #region Assignment 3
            #region A
            //a.Insert a new airline named "EgyptAir" with contact person "Ahmed Ali", phone "0123456789" and “0113654789”, and address "Cairo".

            var Airline1 = new Airline()
            {
                AirlineName = "EgyptAir",
                ContactPerson = "Ahmed Ali",
                AirLinePhones = new List<AirLinePhones>() { new AirLinePhones() { PhoneNumber = "0123456789" } ,
                    new() {PhoneNumber = "0113654789" }  },
                Address = "Cairo"
            };

            //airlineDbContext.Add(Airline1);
            //airlineDbContext.SaveChanges();

            #endregion
            #region B
            //b. Add a new aircraft with model "Model01", capacity 180, and airline = "EgyptAir".

            var egyptair = airlineDbContext.Set<Airline>().Where(a => a.AirlineName == Airline1.AirlineName)
                .Select(a => a.AirlineID).SingleOrDefault();

            var aircraft1 = new Aircraft()
            {
                Model = "Model01",
                Capacity = 180,
                AirlineID = egyptair
            };

            //airlineDbContext.Add(aircraft1);
            //airlineDbContext.SaveChanges();
            //var duplicate = airlineDbContext.Set<Aircraft>().Find(40);
            //if (duplicate != null)
            //{
            //    airlineDbContext.Set<Aircraft>().Remove(duplicate);
            //    airlineDbContext.SaveChanges();
            //}

            #endregion
            #region C
            //Record a new transaction of amount 50000 with description "Tickets" for "EgyptAir".

            var transaction1 = new Transaction()
            {
                TransactionAmount = 50000,
                TransactionDescription = "Ticket",
                AirlineID = egyptair,

            };

            //airlineDbContext.Add(transaction1 );
            //airlineDbContext.SaveChanges();
            #endregion
            #region D
            // d.Select all employees who work in "EgyptAir".

            //var employees =   airlineDbContext.Airlines.Where(a => a.AirlineName== "EgyptAir").Select(a => a);
            //  foreach (var employee in employees)
            //  {
            //      Console.WriteLine($"{employee.ContactPerson}");
            //  }
            #endregion
            #region E

            //e. Show all transactions (id, description, amount) recorded by "EgyptAir".

            //var AllTransaction = airlineDbContext.Transactions.Where(a => a.Airline.AirlineName == "EgyptAir")
            //    .Select(t => new
            //    {
            //        t.AirlineID,
            //        t.TransactionDate,
            //        t.TransactionAmount,
            //        t.TransactionDescription,

            //    });

            //foreach (var item in AllTransaction)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion
            #region f
            //Get the total number of employees working in each airline.

            //var TotalNumber = airlineDbContext.Employees.GroupBy(a => a.Airline).Select(a => new
            //{
            //    airline = a.Key,
            //    count = a.Count()
            //});
            //foreach (var item in TotalNumber)
            //{
            //    Console.WriteLine(item);

            //}
            #endregion
            #region G
            // Change the capacity of the “Model01”  aircraft to  200.


            //var ModelAircraft = airlineDbContext.Aircrafts.FirstOrDefault(a => a.Model == "Model01");

            //if (ModelAircraft is not null)
            //{
            //    ModelAircraft.Capacity = 200;
            //}

            //airlineDbContext.SaveChanges();

            //Console.WriteLine(ModelAircraft?.Capacity);
            #endregion
            #region H

            // h. Delete all transactions older than 2020. 

            //var transactionOlderThan2020 = airlineDbContext.Transactions.Where(t => t.TransactionDate.Year < 2020);
            //airlineDbContext.Transactions.RemoveRange(transactionOlderThan2020);
            //airlineDbContext.SaveChanges();
            #endregion
            #region I
            //Insert a new route from "Cairo" to "Dubai",classification "International", distance 2400 km.

            var route1 = new Route()
            {
                Orgin = "Cairo",
                Distination = "Dubai",
                Distance = "2400km",

            };

            //airlineDbContext.Add(route1);
            //airlineDbContext.SaveChanges();


            //var allRoutes = airlineDbContext.Routes.Select(a => a);
            //foreach (var item in allRoutes)
            //{
            //    Console.WriteLine($"{item.Orgin} , {item.Distance} , {item.Distination} ");
            //}


            #endregion
            #region J

            // Assign  “Model01”  aircraft to Route From  "Cairo"  to "Dubai".With duration 4 hours, price 3000 LE

            //var aircraft = airlineDbContext.Aircrafts.SingleOrDefault(a => a.Model == "Model01");

            //var route = airlineDbContext.Routes.FirstOrDefault(a => a.Orgin == "Cairo" && a.Distination == "Dubai");

            //var aircraftaRoute = new AircraftRoute()
            //{
            //    Aircraft_Id = aircraft?.Id ?? 0,
            //    Duration = 4,
            //    Price = 3000,
            //    RouteId = route?.RouteId ?? 0,
            //    Departure = "Evenning"


            //};

            //airlineDbContext.Add(aircraftaRoute);
            //airlineDbContext.SaveChanges();




            #endregion
            #endregion

            #region Assignment 4
            #region Section A : Loading Related Data 

            #region Q1
            // 1. Load "EgyptAir" With all its aircrafts and their routes 



            //var allData = airlineDbContext.Airlines.Where(a=>a.AirlineName == "EgyptAir").Include(a => a.Aircraft)
            //    .ThenInclude(a => a.AircraftRoutes).FirstOrDefault();

            //Console.WriteLine(allData?.AirlineName);
            //foreach (var item in allData?.Aircraft)
            //{
            //    Console.WriteLine($"{item.Id} , {item.Capacity}");

            //    foreach (var item1 in item.AircraftRoutes)
            //    {
            //        Console.WriteLine($"{item1.Aircraft_Id} , {item1.Arrival} , {item1.Duration} ");
            //    }
            //} 
            #endregion

            #region Q2
            //2. Retrieve all airlines with their employees, and for each employee load their qualifications. 

            //var AirLineEmployee = airlineDbContext.Airlines.Include(a => a.Employees)
            //    .ThenInclude(EQ => EQ.EmployeeQualifications).Select(a => a);


            //foreach (var item in AirLineEmployee)
            //{
            //    Console.WriteLine($"{item.AirlineName}");
            //    foreach (var item1 in item.Employees)
            //    {
            //    Console.WriteLine($"{item1.EmpName}");

            //        foreach (var item2 in item1.EmployeeQualifications)
            //        {
            //    Console.WriteLine($"{item2.Qualification}");

            //        }

            //    }

            //}
            #endregion

            #region Q3
            // Load all airlines with their transactions, but only include transactions where Amount > 10000

            //var TransactionBiggerThan10000 = airlineDbContext.Airlines.Include(a => a.Transactions.Where(a => a.TransactionAmount > 10000));

            //foreach (var airline in TransactionBiggerThan10000)
            //{
            //    Console.WriteLine($"Airline: {airline.AirlineName}");
            //    foreach (var trans in airline.Transactions)
            //    {
            //        Console.WriteLine($"  Transaction: {trans.TransactionId}, {trans.TransactionDescription}, {trans.TransactionAmount}");
            //    }
            //}

            #endregion

            #region Q4
            //4. Select all routes along with the model of aircrafts assigned to them 

            //var AllRoutes = airlineDbContext.Routes.Include(a => a.AircraftRoutes).ThenInclude(a=>a.Aircraft);

            //foreach (var route in AllRoutes)
            //{
            //    Console.WriteLine($"Route: {route.Orgin} TO {route.Distination}");

            //    foreach (var ar in route.AircraftRoutes)
            //    {
            //        Console.WriteLine($"  Aircraft Model: {ar.Aircraft.Model}, Duration: {ar.Duration}, Price: {ar.Price}");
            //    }
            //}


            #endregion

            #region Q5
            // Retrieve all aircrafts with their airline and the airline’s phones.

            //var allAircraftWithAirline = airlineDbContext.Aircrafts.Include(a => a.Airline).ThenInclude(a => a.AirLinePhones);

            //foreach (var ac in allAircraftWithAirline)
            //{
            //    Console.WriteLine($"Aircraft: {ac.Model}, Capacity: {ac.Capacity}");

            //    if (ac.Airline != null)
            //    {
            //        Console.WriteLine($"  Airline: {ac.Airline.AirlineName}");

            //        foreach (var phone in ac.Airline.AirLinePhones)
            //        {
            //            Console.WriteLine($"    Phone: {phone.PhoneNumber}");
            //        }
            //    }
            //}
            #endregion
            #endregion

            #region Section B : Join Operators 
            #region Q1
            // 1. List all employees with their airline name. 

            //var allEmployeeWithAirlineName = airlineDbContext.Employees.Join(airlineDbContext.Airlines, a => a.AirlineID, r => r.AirlineID, (a, r) => new
            //{
            //    EmployeeName = a.EmpName,
            //    AirlineName = r.AirlineName,

            //});



            //foreach (var item in allEmployeeWithAirlineName)
            //{
            //    Console.WriteLine($"Employee: {item.EmployeeName}, Airline: {item.AirlineName}");
            //}
            #endregion

            #region Q2 
            // مش عارف احله بصراحه بس هبحث فيه
            // 2. Show all routes with the aircraft model assigned and the airline name that owns the aircraft. 

            //var allRoutes = airlineDbContext.AircraftRoutes.Join(airlineDbContext.Routes, ar => ar.RouteId, r => r.RouteId,
            //    (ar, r) => new { ar, r }).Join(airlineDbContext.Employees , 
            //    a=>a.ar. , m=>m.AirlineID
            //    )
            #endregion

            #region Q3
            // 3. For each airline, list its aircraft models. 
            //var AircraftAirline = airlineDbContext.Airlines.Join(airlineDbContext.Aircrafts,
            //    a => a.AirlineID, ar => ar.AirlineID, (a, ar) => new
            //    {
            //        a , 
            //        ar

            //    });

            //foreach (var item in AircraftAirline)
            //{
            //    Console.WriteLine($"Airline: {item.a.AirlineName}, Aircraft Model: {item.ar.Model}");
            //}
            #endregion

            #region Q4
            //4.Show all transactions(id, amount, description) along with the airline name, but only where Amount > 20000.

            //var allTransaction = airlineDbContext.Transactions.Join(airlineDbContext.Airlines, t => t.AirlineID
            //, a => a.AirlineID, (t, a) => new
            //{
            //    t.TransactionId ,
            //    t.TransactionAmount,
            //    t.TransactionDescription,
            //    a.AirlineName,


            //}).Where(a=>a.TransactionAmount > 20000);

            //foreach (var item in allTransaction)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion
            #endregion
            #endregion










        }
    }
}
