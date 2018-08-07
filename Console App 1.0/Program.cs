using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_App_1._0
{
    class Program
    {
         public static void Exit()
        // Function to Ask to Exit the Console
        {
            Console.WriteLine("\nDo You Really Wish To Exit?\n\nY/N?");
            char a = Convert.ToChar(Console.ReadLine());
            if (a == 'Y' | a == 'y')
            {
                Environment.Exit(0);
            }
            else
            {
                Console.Clear();
                Main();
            }

        }
      
        public static void Add()
            // Function for Addition of Two Integers
        {
            Console.Clear();
            Console.WriteLine("\nFunction for Addition of Two Integers\n");
            long total, n1, n2;
            Console.WriteLine("Enter a Integer : ");
            n1 = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("\nEnter another Integer : ");
            n2 = Convert.ToInt64(Console.ReadLine());
            total = n1 + n2;
            Console.WriteLine("Addition of Entered Digits is : {0}", total.ToString());
            Console.ReadLine();
        }

        public static void Sub()
            // Function for Substraction of two integers
        {
            Console.Clear();
            Console.WriteLine("\nFunction for Substraction of two integers \n");
            long total, n1, n2;
            Console.WriteLine("Enter a Integer : ");
            n1 = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("\nEnter another Integer : ");
            n2 = Convert.ToInt64(Console.ReadLine());
            total = n1 - n2;
            Console.WriteLine("Subtraction of Entered Digits is : {0}", total.ToString());
            Console.ReadLine();
        }
 
        public static void Multiply()
            // Function for Multiplication of Two numbers with two decimal places
        {
            Console.Clear();
            Console.WriteLine("\nFunction for Multiplication of Two numbers with two decimal places:\n");
            double total, n1, n2;
            Console.WriteLine("Enter a Number With Two Decimals : ");
            n1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\nEnter another Number with Two Decimals : ");
            n2 = Convert.ToDouble(Console.ReadLine());
            total = n1 * n2;
            Console.WriteLine("Multiplication of Entered Numbers is : {0}", total.ToString());
            Console.ReadLine();
        }

        public static void Division()
            // Function for division of Two numbers with two decimal places
        {
            Console.Clear();
            Console.WriteLine("\nFunction for division of Two numbers with two decimal places\n");
            double total, n1, n2;
            Console.WriteLine("Enter a Number With Two Decimals : ");
            n1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\nEnter another Number with Two Decimals : ");
            n2 = Convert.ToDouble(Console.ReadLine());
            total = n1 / n2;
            Console.WriteLine("Division of Entered Numbers is : {0}", total.ToString());
            Console.ReadLine();
        }      

        public static void Student()
            // Student Percentage Calculation
        {
            Console.Clear();
            Console.WriteLine("\nEnter the following details :\n");
            Console.WriteLine("\nEnter Marks for 1st Subject : \t");
            double s1 = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("\nEnter Marks for 2nd Subject : \t");
            double s2 = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("\nEnter Marks for 3rd Subject : \t");
            double s3 = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("\nEnter Marks for 4th Subject : \t");
            double s4 = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("\nEnter Marks for 5th Subject : \t");
            double s5 = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("\nEnter Marks for 6th Subject : \t");
            double s6 = Convert.ToInt64(Console.ReadLine());
            double total = s1 + s2 + s3 + s4 + s5 + s6;
            double per = total / 6;
            Console.WriteLine("\nTotal Marks Secured : \t{0} and percntage are \t{1} %",total.ToString(),per.ToString());
            Console.ReadLine();
        }

        public static void Area()
        //Calculating Area of Circle
        {
            Console.Clear();
            const double pi = 3.14;
            Console.WriteLine("\nEnter the Radius of the Circle");
            double r = Convert.ToDouble(Console.ReadLine());
            double a = pi * r * r;
            Console.WriteLine("\nThe Radius give is {0} and the area of the circle therefore is\n{1}",r.ToString(),a.ToString());
            Console.ReadLine();
        }

        public static void Main()
        {
            Console.Clear();
            Console.WriteLine("\nApplication Development Tools");
            Console.WriteLine("\n<--------Pracitcal 1-------->");
            Console.WriteLine("\n  Select Any of the Following Function :");
            Console.WriteLine("\n_________________________________________");
            Console.WriteLine("\n1. Addition of Two Numbers\n\n2. Subtraction of Two Numbers");
            Console.WriteLine("\n3. Multiplication of Two Numbers\n\n4. Division of Two Numbers");
            Console.WriteLine("\n5. Area of a Circle\n\n6. Percentage of a Student");
            Console.WriteLine("\nPress Any Other Key to Exit the Console Application.");
            int a = Convert.ToInt32(Console.ReadLine());

            switch (a)
            {
                case 1:
                    Add();
                    break;
                case 2:
                    Sub();
                    break;
                case 3:
                    Multiply();
                    break;
                case 4:
                    Division();
                    break;
                case 5:
                    Area();
                    break;
                case 6:
                    Student();
                    break;

                default:
                    Console.WriteLine("\nWhat you wish to do?\na. Continue the Program\nb. Exit the Program");
                    char c = Convert.ToChar(Console.ReadLine());
                    if(c=='a'||c=='A')
                    {
                        Main();
                    }
                    else
                    {
                        Exit();
                    }                  
                    break;
            }
        }
    }
}
