using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_AutomaticProperties
{
    public class Human
    {
        //default constructor
        public Human()
        {
            this.height = 0.0;
            this.weight = 0.0;
        }
        //constructor chaining
        public Human(string firstName, string lastName) : this()
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }
        public Human(string bloodType = "A") : this()
        {
            if (bloodType == "A" || bloodType == "B" || bloodType == "AB" || bloodType == "O")
            {
                this.bloodType = bloodType;
            }
        }
        //a hidden field is created for each automatic property
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string fullName
        {
            get { return this.firstName + " " + this.lastName; }
            private set { }
        }
        public int age { get; set; }
        public double height { get; set; }
        public double weight { get; set; }
        public string bloodType { get; set; }
        //non automatic properties give us a little more means of implementing our getters and setters
        public string sex
        {
            get { return this.fullName + " is a " + this.sex; }
            set { this.sex = value; }
        }
        //a method just for fun, notice the optional parameter
        public string GetOccupationByAge(int age = 0)
        {
            string message = "";

            if (age >= 0 || age < 18)
            {
                message = "High School student";
            }
            else if (age >= 18 && age <= 20)
            {
                message = "United States Marine";
            }
            else if (age > 20 && age <= 27)
            {
                message = "Systems Technician Support";
            }
            else if (age > 27 && age <= 29)
            {
                message = "Web Developer";
            }
            else
            {
                message = "unknown";
            }

            return message;
        }
    }
}
