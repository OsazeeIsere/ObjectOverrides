using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOverrides
{
    class Person
    {
        public string FirstName { get; set; } = "";
        public string LastName { get; set; } = "";
        public int Age { get; set; }
        public string SSN { get; set; }

        //custom constructor
        public Person(string firstName,string lastName, int age,string ssn)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            SSN = ssn;
        }
        public Person(){}

        //methods
        public override string ToString()=>$"[FirstName: {FirstName}, LastName: {LastName}," +
            $"Age: {Age}]";//expresion-bodied member
        public override bool Equals(object obj)
        {
           
            if(obj is Person && obj != null)
            {
                Person temp;
                temp = (Person)obj;
                if(temp.FirstName==this.FirstName && temp.LastName==this.LastName
                    && temp.Age==this.Age)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else { return false; }
        }
        public override int GetHashCode()
        {
            return SSN.GetHashCode();
        }
    }
}
