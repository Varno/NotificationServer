using Notification.Core.Models;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;

namespace Notification.Core.DataAccessLayer
{
    public class ParticipantRepositary<T> : IParticipantRepositary<T> where T : Participant
    {
        protected static ConcurrentBag<Participant> participants = new ConcurrentBag<Participant>();

        public IEnumerable<T> GetList(Func<T, bool> criteria = null)
        {
            if (criteria == null)
                return participants
                    .OfType<T>()
                    .ToArray();
            return participants
                .OfType<T>()
                .Where(criteria)
                .ToArray();
        }

        public T Get(Guid participantId)
        {
            return participants
                .OfType<T>()
                .SingleOrDefault(p => p.Id == participantId);
        }

        public void Add(T participant)
        {
            participants.Add(participant);
        }
    }
}
