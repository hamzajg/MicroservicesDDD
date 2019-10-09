using System;

namespace Services.Common.Domain.Events
{
    public abstract class DomainEvent : IEvent
    {
        public Guid Id {get; protected set;}
        public DateTime OcurrendOn {get;}
        public int Version {get; set;}

        public DomainEvent() {
            OcurrendOn = DateTime.UtcNow;
        }
    }
}