using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment11
{
    internal class Student
    {
        //Constructor
        public Student(string firstName, string familyName, DateTime registrationDate)
        {
            FirstName = firstName;
            FamilyName= familyName;
            RegistrationDate = registrationDate;
            
        }

        //Properties
        public string FirstName { get; set; }
        public string FamilyName { get; set; }
        public DateTime RegistrationDate { get; set; }

        //Method

        public override string ToString()
        {
            return "First name is " + FirstName + 
                ", Family name is " + FamilyName +
                ",\n Registration date was " + RegistrationDate.ToString("dddd,d,MMMM,yyyy");
        }
        

        }


    }

