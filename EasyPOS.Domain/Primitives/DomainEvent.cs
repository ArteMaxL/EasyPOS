using MediatR;

namespace EasyPOS.Domain.Primitives
{
    public record DomainEvent(Guid Id) : INotification;
}
