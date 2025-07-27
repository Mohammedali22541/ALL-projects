using Common;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assignment_1_oop
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Question 1

            ///Create an Enum called "WeekDays" with the days of the week(Monday to Sunday) as its members.
            ///write a C# program that prints out all the days of the week using this Enum.


            ///Console.WriteLine("Weekdays: ");
            ///foreach (var day in Enum.GetNames(typeof(Weekdays))) 
            ///{
            ///    Console.WriteLine(day);
            ///}
            #endregion

            #region Question 2
            ///Create an Enum called "Seas on" with the four seasons(Spring, Summer, Autumn, Winter) as its members.
            ///Write a C# program that takes a season name as input from the user and displays
            ///the corresponding month range for that season. Note range for seasons ( spring march to may ,
            ///summer june to august , autumn September to November , winter December to February)




            ///كنت حابب اخليه مش case sensitive 
            /// فبحث ولقيت انه بياخد باراميتر تالت لو ب تروو مش هيبقي case sensitive


            ///Seas_on season;
            ///bool isParsed;
            ///do
            ///{
            ///    Console.Write("Please Enter Season Name: ");
            ///    isParsed = Enum.TryParse(Console.ReadLine(), true , out season);
            ///
            ///}
            ///while (!isParsed);
            ///
            ///if (season == Seas_on.spring)
            ///{
            ///    Console.WriteLine("Month Range From March To May");
            ///}else if (season == Seas_on.summer)
            ///{
            ///    Console.WriteLine("Month Range From June To August");
            ///
            ///}
            ///else if (season == Seas_on.autumn)
            ///{
            ///    Console.WriteLine("Month Range From September to November");
            ///
            ///}
            ///else if ((season == Seas_on.winter))
            ///{
            ///    Console.WriteLine("Month Range From December to February");
            ///
            ///}
            #endregion

            #region Question 3

            ///Assign the following Permissions(Read, write, Delete, Execute) in a form of Enum.
            ///Create Variable from previous Enum to Add and Remove Permission from variable, 
            ///check if specific Permission existed inside variable

            ///Permissions std;
            ///
            ///std = Permissions.read;
            ///Console.WriteLine(std);
            ///
            ///std = std | Permissions.write;
            ///Console.WriteLine(std);


            ///طريقة اولي and
            ///if ( (std  &  Permissions.execute) == Permissions.execute)
            ///{
            ///    Console.WriteLine("Permission Execute Is Exist");
            ///}
            ///else
            ///{
            ///    Console.WriteLine("Permission Execute Is Not Exist");
            ///}

            /// طريقة hasflag
            ///if (std.HasFlag(Permissions.execute))
            ///{
            ///    Console.WriteLine("Permission Execute Is Exist");
            ///
            ///}
            ///else
            ///{
            ///    Console.WriteLine("Permission Execute Is Not Exist");
            ///
            ///}





            #endregion

            #region Question 4
            ///Create an Enum called "Colors" with the basic colors(Red, Green, Blue) as its members.
            ///Write a C# program that takes a color name as input from the user and displays a message
            ///indicating whether the input color is a primary color or not.

            ///Colors colorss;
            ///bool isParsed;
            ///
            ///do
            ///{
            ///    Console.Write("Enter Your Color: ");
            ///    isParsed = Enum.TryParse(Console.ReadLine(), true, out colorss);
            ///
            ///}
            ///while (!isParsed);
            ///
            ///
            ///if (colorss == Colors.red || colorss == Colors.green || colorss == Colors.blue)
            ///{
            ///    Console.WriteLine("your color is a primary color");
            ///
            ///}
            ///else
            ///{
            ///    Console.WriteLine("your color isn' a primary color");
            ///
            ///}


            #endregion






            //==================================================================

            #region Demo
            #region Class Library And Access Modifier
            // first i created a class library named common
            // inside common i made a class with public access modifier and make an object from this class
            // access modifier allowed inside classs ===> //public //private //protected //private protected //internal //protected internal


            ///StudentInfo studentInfo = new StudentInfo()
            ///{
            ///    Id = 10,
            ///    name = "Mohammed"
            ///};
            ///
            ///Console.WriteLine($"Your Name is {studentInfo.name} And Your Id IS {studentInfo.Id}");


            // what we can write inside class...

            //1- attributes
            ///int myAtribute = 0;

            //2- function
            ///static void PrintMessage()
            ///{
            ///    Console.WriteLine("hello user");
            ///}

            //3- properties
            ///public int MyProperty { get; set; }

            //4- event

            #endregion

            #region enum

            #region Ex1
            // i will create a class named person will have some attributes
            // person have attr id , name , gender
            // gender is a value type (Enum) ===> male = 0 , female = 1

            ///Person person01 = new Person();
            ///person01.Name = "Ali";
            ///person01.Id = 1;
            ///person01.gender = Gender.male;
            ///
            ///Console.WriteLine($"Your Name Is {person01.Name} And Your Id Is {person01.Id} And Your Gender Is {person01.gender}");

            #endregion

            #region Ex2
            // i will create an enum named grades from a to f 
            // i will check on these grades to show message
            // i changed the default in enum (a) now is equal 1 not 0
            // i will use (new) keyword but here it will intialize variable to default value

            ///Grades grades = new Grades();
            ///
            ///Console.WriteLine(grades); //0 default value
            ///
            ///Grades grades01 = Grades.a;
            ///if (grades01 == Grades.a)
            ///{
            ///    Console.WriteLine("You Got High Marks");
            ///}


            ///Grades grades02 = (Grades)4;
            ///Console.WriteLine(grades02); // d

            ///Grades grades03 = Grades.exellant;
            ///Console.WriteLine(grades03); // a


            #endregion

            #region Ex3
            // i made a new enum name branches 
            // in this ex i will enter the data manually




            ///Student std01 = new Student()
            ///{
            ///    Id = 1,
            ///    Name = "Hassan",
            ///    Gender = Gender.male, //0
            ///    Branches = Branches.dokki, //0
            ///    Grades = Grades.a, //1
            ///
            ///   
            ///};
            #endregion

            #region Ex4
            // in this ex we will take the data from the user 
            // we wont enter data manually like past ex3


            ///Student std02 = new Student();
            ///Console.WriteLine("Please enter your data: ");
            ///
            ///int id;
            ///bool isParsed;
            ///do
            ///{
            ///    Console.Write("id: ");
            ///    isParsed = int.TryParse(Console.ReadLine(), out id);
            ///}
            ///while (!isParsed);
            ///
            ///std02.Id = id;
            ///
            ///Console.Write("Name: ");
            ///std02.Name = Console.ReadLine();
            ///
            //الطريقة القديمة
            ///object gender;
            ///do
            ///{
            ///    Console.Write("gender: ");
            ///    isParsed = Enum.TryParse(typeof(Gender), Console.ReadLine(), true, out gender);
            ///
            ///}
            ///while (!isParsed || gender == null);
            ///
            ///std02.Gender = (Gender)gender;
            ///
            ///Grades studentGrade;
            ///do
            ///{
            ///    Console.Write("grades: ");
            ///    isParsed = Enum.TryParse<Grades>(Console.ReadLine(), out studentGrade);
            ///}
            ///while (!isParsed);
            ///
            ///std02.Grades = studentGrade;
            ///
            ///
            ///Branches StdBranch;
            ///do
            ///{
            ///    Console.Write("branch: ");
            ///    isParsed = Enum.TryParse(Console.ReadLine(), out StdBranch);
            ///}
            ///while (!isParsed);
            ///
            ///std02.Branches = StdBranch;
            ///
            ///Console.Clear();
            ///Console.WriteLine($"Welcome To Route Your Id Is {std02.Id}\n And Your Name Is {std02.Name} And Your Branch Is {std02.Branches}\n And Your Gender Is {std02.Gender} And your Grade Is {std02.Grades}");



            #endregion

            #region Ex5
            // i will create class named user 
            // i will also create an enum name permissions 
            // permissions value will store in byte


            ///User user = new User();
            ///user.Permession = Permessions.read;
            ///Console.WriteLine(user.Permession); // read


            ///user.Permession = user.Permession ^ Permessions.write;
            ///Console.WriteLine(user.Permession); //read  // Write

            // cheack if user has delete or not  // only check

            ///if (user.Permession == (user.Permession & Permessions.delete))
            ///{
            ///    Console.WriteLine("Delete Permession Is Exist ");
            ///}
            ///else
            ///{
            ///    Console.WriteLine("Delete Permession Isn't Exist ");
            ///
            ///}

            // cheack if user has delete or not  // if not it will be added

            ///if (user.Permession == (user.Permession & Permessions.delete))
            ///{
            ///    Console.WriteLine("Delete Permession Is Exist ");
            ///}
            ///else
            ///{
            ///   user.Permession ^= Permessions.delete; // it will be added
            ///    Console.WriteLine(user.Permession);
            ///
            ///}

            // cheack if user has Execute or not  // if Exist dont do anything  // if not it will be added using | or

            ///user.Permession = user.Permession | Permessions.excute;
            ///Console.WriteLine(user.Permession); //read, write, delete, excute








            #endregion
            #endregion

            #endregion


        }

    }
}
