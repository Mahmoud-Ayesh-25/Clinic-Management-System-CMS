using System;
using System.Data;

namespace CMS_BusinessLayer
{
    public class clsNotification
    {
        enum enMode { Add, Update}
        enMode Mode;

        public int NotificationID { get; set; }
        public int UserID { get; set; }
        public string UserName { get { return (UserID != -1) ? clsUser.FindByUserID(UserID).Username : string.Empty; } }
        public string NotificationMessage { get; set; }
        public DateTime Time {  get; set; }
        public DateTime Date {  get; set; }
        public bool IsRead { get; set; }

        public clsNotification()
        {
            Mode = enMode.Add;
            NotificationID = -1;
            UserID = -1;
            NotificationMessage = string.Empty;
            Time = new DateTime();
            Date = new DateTime();
            IsRead = false;
        }

        clsNotification(int notificationID, int userID, string notificationMessage, DateTime time, DateTime date, bool isRead)
        {
            Mode = enMode.Update;
            NotificationID = notificationID;
            UserID = userID;
            NotificationMessage = notificationMessage;
            Time = time;
            Date = date;
            IsRead = isRead;
        }

        public static DataTable GetAllNotifications()
        {
            return CMS_DataLayer.clsNotification.GetAllNotifications();
        }

        public static clsNotification Find(int NotificationID)
        {
            int UserID = -1;
            string NotificationMessage = string.Empty;
            DateTime Time = new DateTime();
            DateTime Date = new DateTime();
            bool IsRead = true;

            if (CMS_DataLayer.clsNotification.GetNotificationByID(NotificationID, ref UserID, ref NotificationMessage, ref Time, ref Date, ref IsRead))
            {
                return new clsNotification(NotificationID, UserID, NotificationMessage, Time, Date, IsRead);
            }
            else return null;
        }

        bool _Add()
        {
            NotificationID = CMS_DataLayer.clsNotification.AddNewNotification(UserID, NotificationMessage, Time, Date, IsRead);
            return (NotificationID != -1);
        }

        bool _Update()
        {
            return CMS_DataLayer.clsNotification.UpdateNotification(NotificationID, UserID, NotificationMessage, Time, Date, IsRead);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.Add:
                    {
                        if (_Add())
                        {
                            Mode = enMode.Update;
                            return true;
                        }
                        else { return false; }
                    }
                case enMode.Update:
                    {
                        return _Update();
                    }
                default: return false;
            }
        }

        public bool SetRead()
        {
            return CMS_DataLayer.clsNotification.SetNotificationRead(NotificationID);
        }

        public static bool DeleteNotification(int NotificationID)
        {
            return CMS_DataLayer.clsNotification.DeleteNotification(NotificationID);
        }
    }
}
