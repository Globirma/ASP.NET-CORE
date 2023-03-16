using Booking.Api.services.Abstraction;

namespace Booking.Api.services
{
    public class TransientOperation : ITransientOperation
    {
        public Guid Guid { get; set; } = new Guid();
    }
}
