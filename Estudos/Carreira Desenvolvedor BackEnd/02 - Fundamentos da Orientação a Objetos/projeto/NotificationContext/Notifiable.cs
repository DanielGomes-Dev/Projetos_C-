using System.Collections.Specialized;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Balta.NotificationContext
{
    public abstract class Notifiable
    {
        public Notifiable()
        {
            Notifications = new List<Notification>();

        }

        public List<Notification> Notifications { get; set; }
        public bool IsValid => !Notifications.Any();



        public void AddNotification(Notification notification)
        {
            Notifications.Add(notification);
        }


        public void AddNotifications(IEnumerable<Notification> notifications)
        {
            Notifications.AddRange(notifications);
        }

    }

}