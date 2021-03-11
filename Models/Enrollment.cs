namespace ContosoUniversity.Models
{
    //tinfo200:[2020-03-01-jmmiddle-dykstra1] - Created enrollment class which contains enrollment entity properties
    //tinfo200:[2020-03-01-jmmiddle-dykstra1] - Grade is enum because property is nullable, which would happen if there is no grade yet
    public enum Grade
    {
        A, B, C, D, F
    }
    public class Enrollment
    {
        public int EnrollmentID { get; set; }
        public int CourseID { get; set; }
        public int StudentID { get; set; }
        public Grade? Grade { get; set; }
        public Student Student { get; set; }

    }
}