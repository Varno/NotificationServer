using Notification.Core.Models;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;

namespace Notification.Core.DataAccessLayer
{
    public class SubscriberRepositary : ParticipantRepositary<Subscriber>
    {
        private static List<Subscriber> defaultParticipants = new List<Subscriber>()
        {
            new Subscriber(Guid.NewGuid(), "Alexey"),
            new Subscriber(Guid.NewGuid(), "Bill"),
            new Subscriber(Guid.NewGuid(), "Danila"),
            new Subscriber(Guid.NewGuid(), "Martin"),
        };
        
        static SubscriberRepositary()
        {
            defaultParticipants
                .ForEach(s => participants.Add(s));
        }
    }
}
