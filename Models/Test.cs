namespace RefuseManagementPortal.Models
{
    public class Test
    {
        public required DateTime date { get; set; }
        public required string serviceArea { get; set; }
        public required string route { get; set; }
        public required string truckNumber { get; set; }
        public required string driver { get; set; }
        public required string helperOne { get; set; }
        public string? helperTwo { get; set; }
        public required string refuseType { get; set; }
    }
}
