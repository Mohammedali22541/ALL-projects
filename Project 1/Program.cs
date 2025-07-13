namespace Project_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //#region variable declartion
            //int number;
            //number = 200;
            //Console.WriteLine(number);
          
            //#endregion

            //#region data type
            //#region valu type data type

            //int x;
            ///// declare variable x type: int
            ///// clr will allocate 4 unassigned byte in a stack
            

            //x = 10;
            //// assign for x with value (10)
            
            //Console.WriteLine(x);
            //// x = 10


            //Int32 y = 20;
            ///// declare variable y type int  
            ///// will assigned 4 byte in stack
            
            //Console.WriteLine(y);
            //// y = 20


            //x = y;
            //Console.WriteLine("after assigned");
            //Console.WriteLine(x);  // x = 20
            //Console.WriteLine(y);  // y = 20


            //y++;

            //Console.WriteLine("after increment");
            //Console.WriteLine(x); //x = 20      
            //Console.WriteLine(y); //y = 21

            //#endregion

            //#region refrences type data 

            //Point p1;
            ///// declared for references of type point (p1) refer to null
            ///// cle will allocate 4 byte in stack
            ///// in heab 0 byte will allocated 
            
            //p1 = new Point();
            ///// allocate required memory  --> 8 byte at heap
            ///// intialize allocated byte in heab with default value (0)

            //Console.WriteLine($"p1.x = {p1.x}"); //  x = 0 because default value is 0
            //Console.WriteLine($"p1.x = {p1.y}"); //  y = 0 because default value is 0


            //Point p2 = new Point() {x = 10,y = 20};
            ///// declare for refrences of type point (p2)
            ///// clr will allocate 4 byte in stack 
            ///// and 8 byte in heab  // because it contain 2 int (x,y) each one = 4 byte

            //Console.WriteLine($"p2.x = {p2.x}"); //  x = 10 
            //Console.WriteLine($"p2.x = {p2.y}"); //  y = 20 


            //p2 = p1;

            //Console.WriteLine("after assign p1 in p2");

            //Console.WriteLine($"p1.x = {p1.x}"); //  x = 0
            //Console.WriteLine($"p1.x = {p1.y}"); //  y = 0
            //Console.WriteLine($"p2.x = {p2.x}"); //  x = 0
            //Console.WriteLine($"p2.x = {p2.y}"); //  y = 0



            //p1.x = 15;
            //p1.y = 20;


            //Console.WriteLine("after increament p1");

            //Console.WriteLine($"p1.x = {p1.x}"); //  x = 15
            //Console.WriteLine($"p1.x = {p1.y}"); //  y = 20
            //Console.WriteLine($"p2.x = {p2.x}"); //  x = 15
            //Console.WriteLine($"p2.x = {p2.y}"); //  y = 20



            //#endregion
            //#endregion

        }
    }   
}
