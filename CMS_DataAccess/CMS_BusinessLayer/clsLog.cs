using System;
using System.Data;

namespace CMS_BusinessLayer
{
    public class clsLog
    {
        public enum enActionType { AddNew = 1, Update, Delete}

        enum enMode { Add, Update}
        enMode Mode;

        public int LogID { get; set; }
        public int UserID { get; set; }
        public clsUser UserInfo { get { return (UserID != -1) ? clsUser.FindByUserID(UserID) : new clsUser(); } }
        public string TableName { get; set; }
        public int ActionType { get; set; }
        public enActionType ActionTypeEnum { get { return (enActionType)ActionType; } }
        public int RecordID { get; set; }
        public DateTime DateTime { get; set; }

        public clsLog ()
        {
            Mode = enMode.Add;
            LogID = -1;
            UserID = -1;
            TableName = string.Empty;
            ActionType = 1;
            RecordID = -1;
            DateTime = new DateTime();
        }

        clsLog (int logID, int userID, string tableName, int actionType, int recordID, DateTime dateTime)
        {
            Mode = enMode.Update;
            LogID = logID;
            UserID = userID;
            TableName = tableName;
            ActionType = actionType;
            RecordID = recordID;
            DateTime = dateTime;
        }

        public static DataTable GetAllLogs()
        {
            return CMS_DataLayer.clsLog.GetAllLogs();
        }

        public static DataTable GetAllLogsByUserID(int UserID)
        {
            return CMS_DataLayer.clsLog.GetAllLogsByUserID(UserID);
        }

        public static clsLog Find(int LogID)
        {
            int UserID = -1;
            string TableName = string.Empty;
            int ActionType = 1;
            int RecordID = -1;
            DateTime DateTime = new DateTime();

            if (CMS_DataLayer.clsLog.GetLogByID(LogID, ref UserID, ref TableName, ref RecordID, ref ActionType, ref DateTime))
            {
                return new clsLog(LogID, UserID, TableName, ActionType, RecordID, DateTime);
            }
            else return null;
        }

        bool _Add()
        {
            LogID = CMS_DataLayer.clsLog.AddNewLog(UserID, TableName, RecordID, ActionType, DateTime);
            return (LogID != -1);
        }

        bool _Update()
        {
            return CMS_DataLayer.clsLog.UpdateLog(LogID, UserID, TableName, RecordID, ActionType, DateTime);
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
                        else return false;
                    }
                case enMode.Update:
                    {
                        return _Update();
                    }
                default: return false;
            }
        }

        public static bool DeleteLog(int LogID)
        {
            return CMS_DataLayer.clsLog.DeleteLog(LogID);
        }

        public static DataTable GetAllLogsByTableNameAndRecordID(string TableName, int RecordID)
        {
            return CMS_DataLayer.clsLog.GetAllLogsByTableNameAndRecordID(TableName, RecordID);
        }
    }
}
