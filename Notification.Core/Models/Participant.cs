using System;

namespace Notification.Core.Models
{
    /// <summary>
    /// Participant
    /// </summary>
    public abstract class Participant
    {
        /// <summary>
        /// Participant Id (Guid).
        /// </summary>
        public Guid Id { get; protected set; }
        
        /// <summary>
        /// Participant Name.
        /// </summary>
        public string Name { get; protected set; }

        public Participant(Guid id, string name)
        {
            this.Id = id;
            this.Name = name;
        }
    }
}
