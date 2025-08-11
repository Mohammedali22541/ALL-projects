using Assignment_5_oop.Classes;
using Assignment_5_oop.Demo;
using Assignment_5_oop.Interfaces;

namespace Assignment_5_oop
{
    internal class Program
    {
        public static void ProcessEmp(Employee employee)
        {
            if (employee != null) {
                employee.GetEmployeeType(); // static Polymorphism based on reference => I am Employee 
                employee.GetEmployeeData(); // Dynamic Polymorphism based on object  
            }
        }
        static void Main(string[] args)
        {
            #region Assignment 

            #region Question 1

            ///Circle circle = new Circle();
            ///circle.Area = 5;
            ///circle.DisplayShapeInfo();


            ///Rectangle rectangle = new Rectangle();
            ///rectangle.Width = 15;
            ///rectangle.Height = 10;
            ///rectangle.DisplayShapeInfo();
            #endregion

            #region Question 2

            ///IAuthenticationService  authService = new BasicAuthenticationService();
            ///bool isUser = authService.AuthenticateUser("Mohammed Ali", "passw@rd");
            ///bool isAuthorizes =  authService.AuthorizeUser("Mohammed Ali", "Admin");
            ///
            ///
            ///Console.WriteLine(isUser);
            ///Console.WriteLine(isAuthorizes);
            #endregion

            #region Question 3

            ///INotificationService notificationService = new PushNotificationService();
            ///notificationService.SendNotification("Mohammed", "Hi This Is A Push Notification Message");
            ///
            ///INotificationService Smsnotification = new SmsNotificationService();
            ///Smsnotification.SendNotification("Ali" , "This Is A Message From Sms");
            ///
            ///INotificationService emailNotification = new EmailNotificationService();
            ///emailNotification.SendNotification("salma", "This Is Message To You From Email");



            #endregion
            #endregion

            #region Demo
            #region Ex1

            //TypeA typeAObj = new TypeA(10);
            //typeAObj.Myfun01(); // Iam Base
            //typeAObj.Myfun02(); // Type A - A=10


            //TypeB typeBObj = new TypeB(10, 15);
            //typeBObj.Myfun01(); // Iam Base                     // this is from parent before overriding 
            //typeBObj.Myfun02(); // Type A - A=10                // this is from parent before overriding 

            //typeBObj.Myfun01(); // Iam Derived                  // Static compile time PolymorPhism new ==> Masking  // calling function based on reference
            //typeBObj.Myfun02(); // Type B - A = 10 , B = 15     // Dynamic Run time PolymorPhism OverRide            // calling function based on object type


            #endregion

            #region Ex2

            ///TypeA typeAObj = new TypeB(2 , 4);
            ///typeAObj.A = 20; //20
            /////typeAObj.b = 40; //Invalid Cant Access It
            ///
            ///typeAObj.Myfun01(); // Iam Base                   //Static Polymorphism     // called Parent Because it called Based On Reference (typeAObj)
            ///typeAObj.Myfun02(); // Type B - A = 20 , B = 4    //Dynamic Polymorphism    // called Child Because it called Based On Object ("new TypeB")



            #endregion

            #region Ex3

            ///FullTimeEmployee fullTimeEmployee = new FullTimeEmployee(10, "Mohammed", 25, 2000);
            ///ProcessEmp(fullTimeEmployee); //Data : Id = 10 , Name = Mohammed , Age = 25 , Salary = 2000
            ///
            ///PartTimeEmployee partTimeEmployee = new PartTimeEmployee(15, "ali", 25, 30, 9);
            ///ProcessEmp(partTimeEmployee); //Data : Id = 15 , Name = ali , Age = 25 , Count Of Hours = 30 , Hour Rate = 9




            #endregion

            #region Ex4

            ///TypeA typeARef = new TypeB(10, 20);
            ///typeARef.A = 100; // 100 //valid
            ///typeARef.B = 200;        //invalid
            ///typeARef.Myfun01(); // static compile Time Polymarphism    // Iam Type A --  Base         ==> reference   ("TypeARef")
            ///typeARef.Myfun02(); // Dynamic Run Time Polymarphism       // Type B - A = 100 , B = 20   ==> Object Type ("TypeB")

            ///TypeA typeARef = new TypeC(10, 20, 30);
            ///typeARef.A = 100;   // 100 //valid
            ///typeARef.B = 200;        //invalid
            ///typeARef.c = 200;        //invalid
            ///typeARef.Myfun01(); // static compile Time Polymarphism    // Iam Type A --  Base                 ==> reference   ("TypeARef")
            ///typeARef.Myfun02(); // Dynamic Run Time Polymarphism       //Type C - A = 100 , B = 20 , C = 30   ==> Object Type ("TypeC")


            ///TypeB typeBRef = new TypeC(5, 10, 20);
            ///typeBRef.A = 100;   // 100 // valid
            ///typeBRef.B = 200;   // 200 // valid
            ///typeBRef.c = 200;        //invalid
            ///typeBRef.Myfun01(); // static compile Time Polymarphism    // Iam Type B --  Child                 ==> reference   ("typeBRef")
            ///typeBRef.Myfun02(); // Dynamic Run Time Polymarphism       //Type C - A = 100 , B = 200 , C = 20   ==> Object Type ("TypeC")


            ///TypeA typeARef = new TypeD(10, 20 , 30 , 40);
            ///typeARef.A = 100; // 100 //valid
            ///typeARef.B = 200;        //invalid
            ///typeARef.C = 200;        //invalid
            ///typeARef.D = 200;        //invalid
            ///typeARef.Myfun01(); // static compile Time Polymarphism    // Iam Type A --  Base         ==> reference   ("TypeARef")
            ///typeARef.Myfun02(); // Dynamic Run Time Polymarphism      //Type C - A = 100 , B = 20 , C = 30  ==> Object Type ("TypeD")  // can not get type D


            ///TypeB typeBRef = new TypeD(5, 10, 20 , 40);
            ///typeBRef.A = 100;   // 100 // valid
            ///typeBRef.B = 200;   // 200 // valid
            ///typeBRef.C = 200;        //invalid
            ///typeBRef.Myfun01(); // static compile Time Polymarphism    // Iam Type B --  Child                 ==> reference   ("typeBRef")
            ///typeBRef.Myfun02(); // Dynamic Run Time Polymarphism       //Type C - A = 100 , B = 200 , C = 20   ==> Object Type ("TypeD")    // can get type D



            ///TypeC typeCRef = new TypeD(5, 10, 20 , 40);
            ///typeCRef.A = 100;   // 100 // valid
            ///typeCRef.B = 200;   // 200 // valid
            ///typeCRef.C = 200;   // 200 //valid
            ///typeCRef.D = 400;          //invalid
            ///typeCRef.Myfun01(); // static compile Time Polymarphism    // Iam Type C --  Grand Child                 ==> reference   ("typeCRef")
            ///typeCRef.Myfun02(); // Dynamic Run Time Polymarphism       Type C - A = 100 , B = 200 , C = 200   ==> Object Type ("TypeD")   // can get type D



            ///TypeA typeARef = new TypeE(10, 20 , 30 , 40 , 50);
            ///typeARef.Myfun02(); // Dynamic Run Time Polymarphism       // Type C - A = 100 , B = 20 , C = 30  ==> Object Type ("TypeE")  // can not get type D or e
            ///TypeB typeBRef = new TypeE(10, 20, 30, 40, 50);
            ///typeBRef.Myfun02(); // Dynamic Run Time Polymarphism       // Type C - A = 100 , B = 20 , C = 30  ==> Object Type ("TypeE")  // can not get type D or e
            ///TypeC typeCRef = new TypeE(10, 20, 30, 40, 50);
            ///typeCRef.Myfun02(); // Dynamic Run Time Polymarphism       // Type C - A = 100 , B = 20 , C = 30  ==> Object Type ("TypeE")  // can not get type D or e
            ///TypeD typeDRef = new TypeE(10, 20, 30, 40, 50);
            ///typeDRef.Myfun02(); // Dynamic Run Time Polymarphism       // Type E - A = 10 , B = 20 , C = 30 , D = 40 , E = 50
            ///TypeE typeERef = new TypeE(10, 20, 30, 40, 50);
            ///typeERef.Myfun02(); // Dynamic Run Time Polymarphism         // Type E - A = 10 , B = 20 , C = 30 , D = 40 , E = 50


            #endregion
            #endregion
        }
    }
}
