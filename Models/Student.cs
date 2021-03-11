using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoUniversity.Models
{
    //tinfo200:[2020-03-01-jmmiddle-dykstra1] - Created class named Student. Code for the student entity of the database
    //tinfo200:[2020-03-01-jmmiddle-dykstra1] - The enrollments property is used to hold multiple entities and makes it so there can be additions, deletions and updates
    public class Student
    {
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstMidName { get; set; }
        public DateTime EnrollmentDate { get; set; }
        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
