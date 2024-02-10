namespace DesignPattern.ChainOfResponsibility.Models
{
    public class CustomerProcessViewModel //arada bir sanal sınıf olarak kullanılacak
    {
        public int CustomerProcessID { get; set; }
        public string Name { get; set; }
        public int Amount { get; set; }
        public string EmployeeName { get; set; }
        public string Description { get; set; }
    }
}
