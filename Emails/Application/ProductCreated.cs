namespace Emails.Application
{
    public class ProductCreated
    {
        public ProductCreated(Guid id, string name, DateTime occuredOn)
        {
            Id = id;
            Name = name;
            OccuredOn = occuredOn;
        }

        public Guid Id { get; }
        public string Name { get; }
        public DateTime OccuredOn { get; }
    }
}