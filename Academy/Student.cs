using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Academy
{
    internal class Student:AcademyMember
    {
        public string Group { get; set; }
        public double Rating { get; set; }
        public double Attendance { get; set; }
        public Student
        (
            string lastName, string firstName, int age,
            string speciality, string group, double rating, double attendance
        ): base(lastName, firstName, age,speciality)
        {
            Group = group;
            Rating = rating;
            Attendance = attendance;
#if DEBUG
            Console.WriteLine($"SConstructor:\t{GetHashCode()}"); 
#endif
        }

        public Student(Human human, string speciality,string group, double rating, double attendance) : base(human, speciality)
        {
            this.Group = group;
            this.Rating = rating;
            this.Attendance = attendance;
        }

        public Student(Student other):base(other)
        {
            this.Rating = other.Rating;
            this.Attendance = other.Attendance;
            this.Group = other.Group;
        }

        ~Student()
        {
#if DEBUG
            Console.WriteLine($"SDestructor:\t{GetHashCode()}"); 
#endif
        }

        public override string ToString()
        {
            return base.ToString() + $"{Group.PadRight(8)}{Rating.ToString().PadLeft(8)}{Attendance.ToString().PadLeft(8)}";
        }
    }
}
