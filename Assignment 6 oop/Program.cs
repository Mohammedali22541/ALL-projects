using Assignment_6_oop.Classes;
using Assignment_6_oop.Demo;
using System.Text;

namespace Assignment_6_oop
{
    internal class Program
    {

      
        static void Main(string[] args)
        {

            #region Assignment 

            #region Question 1


            ///_3D_Point p1 = new _3D_Point(10, 20 , 30);
            ///Console.WriteLine(p1);

            ///int temp;
            ///int temp2;
            ///bool isParsed;
            ///do
            ///{
            ///    Console.Write("Enter First Dimention: ");  
            ///    isParsed =  int.TryParse(Console.ReadLine(), out temp);
            ///}
            ///while (!isParsed);
            ///do
            ///{
            ///    Console.Write("Enter Second Dimention: ");
            ///    isParsed = int.TryParse(Console.ReadLine(), out temp2);
            ///}
            ///while (!isParsed);
            ///
            ///_3D_Point p2 = new _3D_Point(temp, temp2);
            ///Console.WriteLine(p2);
            ///
            ///if (p1 == p2)
            ///{
            ///    Console.WriteLine($"P1 is equal P2");
            ///}
            ///else if(p1 != p2)
            ///{
            ///    Console.WriteLine($"P1 is Not equal P2");
            ///
            ///}



            ///_3D_Point[] _3D_Points =
            ///{
            ///    new _3D_Point(10,20),
            ///    new _3D_Point(5,10),
            ///    new _3D_Point(20,30),
            ///    new _3D_Point(40,30),
            ///
            ///};
            ///
            ///
            ///Array.Sort( _3D_Points );
            ///
            ///foreach (_3D_Point point in _3D_Points)
            ///{
            ///    Console.WriteLine(point);
            ///}


            ///_3D_Point p1 = new _3D_Point() { D1 = 10 , D2 = 20};
            ///_3D_Point p2 = new _3D_Point() { D1 = 500, D2 = 200 };
            ///
            ///p2 = (_3D_Point)p1.Clone();
            ///
            ///Console.WriteLine(p1);
            ///Console.WriteLine(p2);

            #endregion

            #region Question 2
            Console.Write("Enter Your User Type from These Types (Regular, Premium, Guest) :  ");
            string? UserType = Console.ReadLine()?.ToLower();

          
            User? user;

            if (UserType == "regular")
            {
                 user = new RegularUser();
            }
            else if (UserType == "premium")
            {
                user = new PremiumUser();
            }
            else if (UserType == "guest")
            {
                 user = new GuestUser();
            }
            else
            {
                return;
            }

                Console.Write("Enter Product Price: ");
            decimal.TryParse(Console.ReadLine(), out decimal Price);

            Console.Write("Enter Product Quantity: ");
            int.TryParse(Console.ReadLine(), out int Quantity);

            Discount discount = user.GetDiscount();
            decimal discountAmount = discount.CalculateDiscount(Price, Quantity);   
            decimal totalPrice = Price * Quantity;
            decimal finalPrice = totalPrice - discountAmount;


            Console.WriteLine($"User Type: {user.UserName}");
            Console.WriteLine($"Discount Type: {discount.Name}");
            Console.WriteLine($"Discount Amount: {discountAmount:C}");
            Console.WriteLine($"Final Price: {finalPrice:C}");


            #endregion

            #endregion
            #region Demo


            #region Shallow Copy And Deep Copy

            #region Array Of Value Type

            //int[] arr01 = { 1, 2, 3 };
            //int[] arr02 = new int[3];


            //Console.WriteLine($"Hash Code Arr01 is: {arr01.GetHashCode()}");
            //Console.WriteLine($"Hash Code Arr02 is: {arr02.GetHashCode()}");


            #region Shallow Copy
            ///arr02 = arr01;
            ///
            ///Console.WriteLine("After Shallow Copy");
            ///Console.WriteLine($"Hash Code Arr01 is: {arr01.GetHashCode()}");
            ///Console.WriteLine($"Hash Code Arr02 is: {arr02.GetHashCode()}");
            ///
            ///arr01[0] = 100;
            ///Console.WriteLine($"Arr01 [0] is : {arr01[0]}");
            ///Console.WriteLine($"Arr02 [0] is : {arr02[0]}");



            #endregion

            #region Deep Copy

            ///arr02 = (int[])arr01.Clone();
            ///Console.WriteLine("After Deep Copy");
            ///Console.WriteLine($"Hash Code Arr01 is: {arr01.GetHashCode()}");
            ///Console.WriteLine($"Hash Code Arr02 is: {arr02.GetHashCode()}");
            ///
            ///arr01[0] = 100;
            ///Console.WriteLine($"Arr01 [0] is : {arr01[0]}");
            ///Console.WriteLine($"Arr02 [0] is : {arr02[0]}");

            #endregion
            #endregion

            #region Array Of Reference Type

            #region Immutable Type

            ///string[] names01 = {"Omar" , "Ali" };
            ///string[] names02 = new string[2];
            ///
            ///Console.WriteLine($"Hash Code names01 is: {names01.GetHashCode()}");  // Hash Code names01 is: 54267293
            ///Console.WriteLine($"Hash Code names02 is: {names02.GetHashCode()}");  // Hash Code names02 is: 18643596


            #region Shallow copy
            ///names02 = names01;

            ///Console.WriteLine("After Shallow Copy");
            ///Console.WriteLine($"Hash Code names01 is: {names01.GetHashCode()}");  // Hash Code names01 is: 54267293
            ///Console.WriteLine($"Hash Code names02 is: {names02.GetHashCode()}");  // Hash Code names02 is: 54267293


            ///Console.WriteLine(names01[0]); //  Omar
            ///Console.WriteLine(names02[0]); //  Omar


            ///names01[0] = "Sama";


            ///Console.WriteLine("After Change Value");
            ///Console.WriteLine($"names01 [0] is : {names01[0]}");  //  Sama
            ///Console.WriteLine($"names02 [0] is : {names02[0]}");  //  Sama



            #endregion

            #region Deep Copy

            ///names02 = (string[])names01.Clone();


            ///Console.WriteLine("After Deep Copy");
            ///Console.WriteLine($"Hash Code names01 is: {names01.GetHashCode()}");  // Hash Code names01 is: 54267293
            ///Console.WriteLine($"Hash Code names02 is: {names02.GetHashCode()}");  // Hash Code names02 is: 33574638


            ///Console.WriteLine("Before Change Value");
            ///Console.WriteLine(names01[0]); //  Omar
            ///Console.WriteLine(names02[0]); //  Omar


            ///names01[0] = "Sama";


            ///Console.WriteLine("After Change Value");
            ///Console.WriteLine($"names01 [0] is : {names01[0]}");  //  Sama
            ///Console.WriteLine($"names02 [0] is : {names02[0]}");  //  Omar
            #endregion
            #endregion

            #region Mutable type

            ///StringBuilder[] names01 = [new StringBuilder("omar")];
            ///StringBuilder[] names02 = new StringBuilder[1];


            ///Console.WriteLine($"Hash Code names01 is: {names01.GetHashCode()}"); //54267293
            ///Console.WriteLine($"Hash Code names02 is: {names02.GetHashCode()}"); //18643596



            #region Shallow Copy

            ///names02 = names01;

            ///Console.WriteLine("After Shallow Copy");
            ///Console.WriteLine($"Hash Code names01 is: {names01.GetHashCode()}");  // 54267293
            ///Console.WriteLine($"Hash Code names02 is: {names02.GetHashCode()}");  // 54267293


            ///Console.WriteLine("Before Change Value");
            ///Console.WriteLine(names01[0]); //  Omar
            ///Console.WriteLine(names02[0]); //  Omar


            ///names01[0].Append("Sama");


            ///Console.WriteLine("After Change Value");
            ///Console.WriteLine($"names01 [0] is : {names01[0]}");  //  omar sama
            ///Console.WriteLine($"names02 [0] is : {names02[0]}");  //  omar sama

            #endregion

            #region Deep Copy

            ///names02 = (StringBuilder[])names01.Clone();


            ///Console.WriteLine("After Deep Copy");
            ///Console.WriteLine($"Hash Code names01 is: {names01.GetHashCode()}");  // Hash Code names01 is: 54267293
            ///Console.WriteLine($"Hash Code names02 is: {names02.GetHashCode()}");  // Hash Code names02 is: 33574638


            ///Console.WriteLine("Before Change Value");
            ///Console.WriteLine(names01[0]); //  Omar
            ///Console.WriteLine(names02[0]); //  Omar


            ///names01[0].Append("Sama") ;


            ///Console.WriteLine("After Change Value");
            ///Console.WriteLine($"names01 [0] is : {names01[0]}");  //  omarSama
            ///Console.WriteLine($"names02 [0] is : {names02[0]}");  //  omarSama

            #endregion

            #endregion
            #endregion
            #endregion

            #region IClonable

            #region Clone()
            ///Employee employee01 = new Employee() { Id = 10, Name = "MoHammed", Salary = 4500 };
            ///Employee employee02 = new Employee() { Id = 20, Name = "Ali", Salary = 5000 };
            ///
            ///Console.WriteLine($"employee01:  {employee01}"); // ID = 10 , Name = MoHammed , Salary = 4,500.00
            ///Console.WriteLine($"employee01 HashCode =  {employee01.GetHashCode()}"); //54267293
            ///
            ///Console.WriteLine($"employee02:  {employee02}"); // ID = 20 , Name = Ali , Salary = 5,000.00
            ///Console.WriteLine($"employee02 HashCode =  {employee02.GetHashCode()}"); //18643596

            ///employee02 = (Employee)employee01.Clone(); // deep copy done 
            ///
            ///Console.WriteLine("After Deep Copy");
            ///
            ///Console.WriteLine($"employee01:  {employee01}"); // ID = 10 , Name = MoHammed , Salary = 4,500.00
            ///Console.WriteLine($"employee01 HashCode =  {employee01.GetHashCode()}"); //54267293
            ///
            ///Console.WriteLine($"employee02:  {employee02}"); // ID = 10 , Name = MoHammed , Salary = 4,500.00
            ///Console.WriteLine($"employee02 HashCode =  {employee02.GetHashCode()}"); //33574638

            #endregion

            #region Copy Constructor

            ///employee02 = new Employee(employee01);

            ///Console.WriteLine("After Deep Copy");

            ///Console.WriteLine($"employee01:  {employee01}"); // ID = 10 , Name = MoHammed , Salary = 4,500.00
            ///Console.WriteLine($"employee01 HashCode =  {employee01.GetHashCode()}"); //54267293

            ///Console.WriteLine($"employee02:  {employee02}"); // ID = 10 , Name = MoHammed , Salary = 4,500.00
            ///Console.WriteLine($"employee02 HashCode =  {employee02.GetHashCode()}"); //33574638
            #endregion

            #endregion

            #region IComparable 

            ///int[] nums = { 6, 2, 1, 4, 3, 5 };
            ///Array.Sort(nums);
            ///foreach (int i in nums) {
            ///    Console.WriteLine(i);
            ///}


            ///Employee[] employees =
            ///{
            ///    new Employee(){Id = 1 , Name = "Mohammed" , Salary = 4000},
            ///    new Employee(){Id = 2 , Name = "Ali" , Salary = 2000 } , 
            ///    new Employee(){Id = 3 , Name = "Salmaa" , Salary = 3000 } , 
            ///    new Employee{Id = 4 , Name = "Omar" , Salary = 1000 }
            ///};

            ///Array.Sort(employees);

            /////Array.Reverse(employees); // لو عايز تعمل reverse

            ///foreach (Employee employee in employees) {
            ///    Console.WriteLine(employee);
            ///}

            #endregion

            #region IComparer


            ///Employee[] employees =
            ///{
            ///    new Employee(){Id = 1 , Name = "Mohammed" , Salary = 4000},
            ///    new Employee(){Id = 2 , Name = "Ali" , Salary = 2000 } , 
            ///    new Employee(){Id = 3 , Name = "Salmaa" , Salary = 3000 } , 
            ///    new Employee{Id = 4 , Name = "Omar" , Salary = 1000 }
            ///};

            ///Array.Sort(employees,new EmployeeNameComparer());
            ///foreach (Employee employee in employees) {
            ///    Console.WriteLine(employee);
            ///}
            #endregion

            #region Abstract

            ///Rectangle rectangle = new Rectangle() { D1 = 10 , D2 = 20};
            ///Console.WriteLine($"Rectangle perimeter = {rectangle.Perimeter}");  // Rectangle perimeter = 400
            ///Console.WriteLine($"Rectangle Area = {rectangle.GetArea()}"); ;     // Rectangle Area = 200


            ///Square square = new Square(5) { D1 = 10, D2 = 20 };
            ///Console.WriteLine($"Square perimeter = {square.Perimeter}");  // Rectangle perimeter = 40
            ///Console.WriteLine($"Square Area = {square.GetArea()}"); ;     // Rectangle Area = 200


            ///Circle circle = new Circle(5) { D1 = 10, D2 = 20 };
            ///Console.WriteLine($"Circle perimeter = {circle.Perimeter}");  // Rectangle perimeter = 62.80
            ///Console.WriteLine($"Circle Area = {circle.GetArea()}"); ;     // Rectangle Area = 314.15926535897900




            #endregion

            #endregion
        }
    }
}
