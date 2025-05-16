using System;
using System.Transactions;
namespace OOPs
{
    //Creating Class
    class Student
    {
        //Creating Public Variable in student class to store Data
        public string name;
        public int rollnum;
        public float marks;

        //Printing the output Function
        public void Display()
        {
            Console.WriteLine("Name Of Student - " + name);
            Console.WriteLine("Roll Number - " + rollnum);
            Console.WriteLine("Marks - "+ marks);
        }
        
    }
    class Display
    {
        static void Main()
        {
            //Creating Object named obj1 (Converting student class in Object obj1)
            Student obj1 = new Student();
           
            //storing values in variables declared in class student
            Console.WriteLine("Enter Student name: ");
            obj1.name = Console.ReadLine();

            Console.WriteLine("Enter Roll Number");
            obj1.rollnum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Marks- ");
            obj1.marks = float.Parse(Console.ReadLine());

            //calling function to print stored Data
            Console.WriteLine("-----------Student Details----------");
            obj1.Display();
            
            

        }
    }
}