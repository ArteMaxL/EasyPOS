using EasyPOS.Domain.Primitives;
using EasyPOS.Domain.ValueObjects;

namespace EasyPOS.Domain.Customers
{
    public sealed class Customer : AggregateRoot
    {
        public Customer()
        {
        }

        public Customer(CustomerId id, string? name, string? lastName, string? email, PhoneNumber? phoneNumber, Address? address, bool isActive)
        {
            Id = id ?? throw new ArgumentNullException(nameof(id));
            Name = name;
            LastName = lastName;
            Email = email;
            PhoneNumber = phoneNumber;
            Address = address;
            IsActive = isActive;
        }

        public CustomerId Id { get; private set; }
        public string? Name { get; private set; }
        public string? LastName { get; set; }
        public string? FullName => $"{Name} {LastName}";
        public string? Email { get; private set; }
        public PhoneNumber? PhoneNumber { get; private set; }
        public Address? Address { get; private set; }
        public bool IsActive { get; set; }
    }
}
