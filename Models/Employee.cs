namespace RefuseManagementPortal.Models
{
    /*
    Employee model is designed to match the Employees table in database.
    Properties that corresponding database fields do not accept null values have been marked as required.
    Properties that corresponding database fields accept null values will allow null values.
    */
    public class Employee
    {
        public required string EmployeeID { get; set; }
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public required string Role { get; set; }
        public DateTime? CdlExpiration { get; set; }
        public required DateTime EmploymentStartDate { get; set; }
        public DateTime? EmploymentEndDate { get; set; }
    }
}
