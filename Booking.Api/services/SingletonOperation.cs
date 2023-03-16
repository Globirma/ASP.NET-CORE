using Booking.Api.services.Abstraction;

namespace Booking.Api.services
{
    public class SingletonOperation : ISingletonOperation
    {
        public Guid Guid { get; set; } = Guid.NewGuid();
    }
}
