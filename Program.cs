using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            bool stillMore = false;
            List<Student> students = new List<Student>();
            do
            {
                Console.Write("Enter your first name, please: ");
                string firstName = Console.ReadLine();
                Console.Write("Enter your family name, please: ");
                string familyName = Console.ReadLine();
                Console.Write("Enter the Registration date of your studies, please: ");
                DateTime sdor;
                string nextdor = Console.ReadLine();

                while (!DateTime.TryParse(nextdor, out sdor))
                {
                    Console.Write("Not valid, Try again ");
                    nextdor = Console.ReadLine();

                }
                students.Add(new Student(firstName, familyName, sdor));
                Console.Write("More (Y/N)?:");

                
                string moreOfThis = Console.ReadLine().ToUpper();
                if (moreOfThis.StartsWith("Y"))
                stillMore = true;

                else
                    stillMore=false;
                
                }while (!stillMore);

            foreach (Student item in students)
                Console.WriteLine(item);
            


                
            
            


        }
    }
}
