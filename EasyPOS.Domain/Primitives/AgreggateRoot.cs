namespace EasyPOS.Domain.Primitives
{
    public abstract class AgreggateRoot
    {
        private readonly List<DomainEvent> _domainEvents = new();
        public ICollection<DomainEvent> GetDomainEvents() => _domainEvents;
        protected void Raise(DomainEvent domainEvent)
        {
            _domainEvents.Add(domainEvent);
        }
    }
}
