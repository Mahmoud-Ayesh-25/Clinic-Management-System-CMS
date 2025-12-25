using CMS_DataLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS_BusinessLayer
{
    public class clsSettings
    {
        public bool Notifications { get; set; }
        public bool AutoSave { get; set; }
        public string AutoSaveLocation { get; set; }

        public clsSettings(bool notifications, bool autoSave, string autoSaveLocation)
        {
            Notifications = notifications;
            AutoSave = autoSave;
            AutoSaveLocation = autoSaveLocation;
        }

        public static clsSettings Get()
        {
            bool Notifications = false;
            bool AutoSave = false;
            string AutoSaveLocation = string.Empty;

            if (CMS_DataLayer.clsSettings.GetSettings(ref Notifications, ref AutoSave, ref AutoSaveLocation))
            {
                return new clsSettings(Notifications, AutoSave, AutoSaveLocation);
            }
            else return null;
        }

        public static bool UpdateNotifications(bool Notifications)
        {
            return CMS_DataLayer.clsSettings.UpdateNotifications(Notifications);
        }
    }
}
