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
#if DEBUG
            Console.WriteLine($"AConstructor:\t{GetHashCode()}"); 
#endif
        } 
        ~AcademyMember()
        {
#if DEBUG
            Console.WriteLine($"ADestructor{GetHashCode()}"); 
#endif
        }
        public override string ToString()
        {
            return base.ToString() + $" {Speciality}";
        }
    }
}
