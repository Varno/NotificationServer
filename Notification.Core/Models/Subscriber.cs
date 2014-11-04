using System;
namespace Notification.Core.Models
{
    /// <summary>
    /// Subscriber
    /// </summary>
    public class Subscriber : Participant
    {
        public Subscriber(Guid id, string name) : base(id, name)
        {
        }
    }
}
