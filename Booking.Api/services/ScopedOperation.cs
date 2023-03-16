using Booking.Api.services.Abstraction;

namespace Booking.Api.services
{
    public class ScopedOperation : IScopedOperation
    {
        public Guid Guid { get; set; } = new Guid();
    }
}
