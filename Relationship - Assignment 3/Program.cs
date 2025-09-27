using Microsoft.EntityFrameworkCore;
using Relationship___Assignment_3.DataBaseContext;
using Relationship___Assignment_3.Models;
using System;
using System.Numerics;

namespace Relationship___Assignment_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
           using AirlineDbContext airlineDbContext = new AirlineDbContext();


            //airlineDbContext.Database.Migrate();

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

            var egyptair  = airlineDbContext.Set<Airline>().Where(a=>a.AirlineName == Airline1.AirlineName)
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

            var aircraft = airlineDbContext.Aircrafts.SingleOrDefault(a=>a.Model== "Model01");

            var route = airlineDbContext.Routes.FirstOrDefault(a => a.Orgin == "Cairo"&& a.Distination == "Dubai");

            var aircraftaRoute = new AircraftRoute()
            {
                Aircraft_Id = aircraft?.Id ?? 0,
                Duration = 4,
                Price = 3000,
                RouteId = route?.RouteId??0,
                Departure = "Evenning"


            };

            airlineDbContext.Add(aircraftaRoute);
            airlineDbContext.SaveChanges();

            


            #endregion










        }
    }
}
