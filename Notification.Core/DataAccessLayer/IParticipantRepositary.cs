using Notification.Core.Models;
using System;
using System.Collections.Generic;

namespace Notification.Core.DataAccessLayer
{
    /// <summary>
    /// IParticipantRepositary
    /// </summary>
    /// <typeparam name="T">The Participant</typeparam>
    public interface IParticipantRepositary<T> where T: Participant
    {
        /// <summary>
        /// Gets the list.
        /// </summary>
        /// <param name="criteria">The criteria.</param>
        /// <returns>List of participants</returns>
        IEnumerable<T> GetList(Func<T, bool> criteria = null);

        /// <summary>
        /// Gets the specified participant identifier.
        /// </summary>
        /// <param name="participantId">The participant identifier.</param>
        /// <returns>The particioant or null</returns>
        T Get(Guid participantId);

        /// <summary>
        /// Adds the specified participant.
        /// </summary>
        /// <param name="participant">The participant.</param>
        void Add(T participant);

        // void Delete(Guid participantId);
    }
}
