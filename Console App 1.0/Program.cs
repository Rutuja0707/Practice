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
            int total, n1, n2;
            Console.WriteLine("Enter a Integer : ");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nEnter another Integer : ");
            n2 = Convert.ToInt32(Console.ReadLine());
            total = n1 + n2;
            Console.WriteLine("Addition of Entered Digits is : {0}", total.ToString());
        }

        public static void Sub()
            // Function for Substraction of two integers
        {
            Console.Clear();
            Console.WriteLine("\nFunction for Substraction of two integers \n");
            int total, n1, n2;
            Console.WriteLine("Enter a Integer : ");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nEnter another Integer : ");
            n2 = Convert.ToInt32(Console.ReadLine());
            total = n1 - n2;
            Console.WriteLine("Subtraction of Entered Digits is : {0}", total.ToString());
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
        }      

        public static void Main()
        {
            Console.WriteLine("\nApplication Development Tools");
            Console.WriteLine("\n<--------Pracitcal 1-------->");
            Console.WriteLine("\n  Select Any of the Following Function :");
            Console.WriteLine("\n_________________________________________");
            Console.WriteLine("\n1. Addition of Two Numbers\n\n2. Subtraction of Two Numbers");
            Console.WriteLine("\n3. Multiplication of Two Numbers\n\n4. Division of Two Numbers");
            Console.WriteLine("\nPress Any Other Key to Exit the Console Application.");
            int a = Convert.ToInt32(Console.ReadLine());
            
            if(a == 1)
            {
                Add();
            }
            if(a == 2)
            {
                Sub();
            }
            if (a == 3)
            {
                Multiply();
            }
            if(a==4)
            {
                Division();
            }
            else
            {
                char b = Convert.ToChar(a);
                Exit();
            }
        }
    }
}
