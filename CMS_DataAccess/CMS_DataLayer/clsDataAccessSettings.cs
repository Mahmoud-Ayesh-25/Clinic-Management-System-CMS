using System;
using System.IO;
using System.Diagnostics;
namespace CMS_DataLayer
{
    public class clsDataAccessSettings
    {
        static string mdf_path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Clinic Management System", "Clinic_Manager_DB.mdf");

        public static string ConnectionString = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={mdf_path};Integrated Security=True;Connect Timeout=30";

        public static void CreateEventLog(string message)
        {
            string appSource = "CMS";

            if (!EventLog.Exists(appSource))
            {
                EventLog.CreateEventSource(appSource, "Application");
            }

            EventLog.WriteEntry(appSource, message, EventLogEntryType.Error);
        }
    }
}
