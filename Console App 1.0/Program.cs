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
            long s1 = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("\nEnter Marks for 2nd Subject : \t");
            long s2 = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("\nEnter Marks for 3rd Subject : \t");
            long s3 = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("\nEnter Marks for 4th Subject : \t");
            long s4 = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("\nEnter Marks for 5th Subject : \t");
            long s5 = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("\nEnter Marks for 6th Subject : \t");
            long s6 = Convert.ToInt64(Console.ReadLine());
            long total = s1 + s2 + s3 + s4 + s5 + s6;
            Console.WriteLine("\nTotal Marks Secured : \t");
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
            Console.WriteLine("\nPress Any Other Key to Exit the Console Application.");
            char a = Convert.ToChar(Console.ReadLine());

            if (a >= 1 && a <= 10)
            {
                if (a == 1)
                {
                    Add();
                }
                if (a == 2)
                {
                    Sub();
                }
                if (a == 3)
                {
                    Multiply();
                }
                if (a == 4)
                {
                    Division();
                }
                else
                {
                    Console.WriteLine("Please select the only number which is provided in the list");
                }
            }
            else
            {
                Exit();
            }
        }
    }
}
