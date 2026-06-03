using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy
{
    internal class AcademyMember:Human
    {
        public string Speciality { get; set; }
        public AcademyMember
            (
                string lastName, string firstName, int age,
                string speciality
            ) : base(lastName, firstName, age)
        {
            this.Speciality = speciality;
            Console.WriteLine($"AConstructor:\t{GetHashCode()}");
        } 
        ~AcademyMember()
        {
            Console.WriteLine($"ADestructor{GetHashCode()}");
        }
        public override string ToString()
        {
            return base.ToString() + $" {Speciality}";
        }
    }
}
