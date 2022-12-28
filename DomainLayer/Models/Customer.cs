using DomainLayer.Common;


namespace DomainLayer.Models
{
    public class Customer:BaseEntity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public string Position { get; set; }
    }
}
