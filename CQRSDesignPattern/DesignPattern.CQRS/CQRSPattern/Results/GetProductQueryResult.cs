namespace DesignPattern.CQRS.CQRSPattern.Results
{
    public class GetProductQueryResult //Çıktının karşılığı olan propertyleri tutuyor.
    {
        public int ID { get; set; }
        public string ProductName { get; set; } //entitydeki isimle aynı olmak zorunda değil
        public int Stock { get; set; }
        public decimal Price { get; set; }
    }
}
