namespace Shared.DataTransferObjects.Product
{
    public record ProductDto
    {
        public Guid Id { get; set; }
        public bool Active { get; set; }
        public DateTime Changed { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public bool Available { get; set; }
    }
}
