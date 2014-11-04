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

        internal Participant()
        {
        }

        internal Participant(Guid id, string name)
        {
            this.Id = id;
            this.Name = name;
        }

        /// <summary>
        /// Initializes this instance.
        /// </summary>
        protected virtual void Init()
        {
            this.Id = Guid.NewGuid();
        }

        /// <summary>
        /// Builds the specified identifier.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="name">The name.</param>
        /// <returns></returns>
        public static T Build<T>(string name) where T: Participant, new()
        {
            var result = new T();
            result.Name = name;
            result.Init();
            return result;
        }
    }
}
