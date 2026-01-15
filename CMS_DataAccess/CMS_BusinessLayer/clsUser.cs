using System.Data;

namespace CMS_BusinessLayer
{
    public class clsUser
    {
        public enum enPermissionType { Admin = 1, Doctor, Receptionist, Accountant}

        enum enMode { Add, Update}
        enMode Mode;

        public int UserID { get; set; }
        public int PersonID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Salt { get; set; }
        public int PermissionType { get; set; }
        public enPermissionType PermissionTypeEnum { get { return (enPermissionType)PermissionType; } }
        public bool IsActive { get; set; }

        public clsUser()
        {
            Mode = enMode.Add;
            UserID = -1;
            PersonID = -1;
            Username = string.Empty;
            Password = string.Empty;
            PermissionType = 1;
            IsActive = true;
        }

        clsUser(int userID, int personID, string username, string password,string salt, int permissionType, bool isActive)
        {
            Mode = enMode.Update;
            UserID = userID;
            PersonID = personID;
            Username = username;
            Password = password;
            Salt = salt;
            PermissionType = permissionType;
            IsActive = isActive;
        }

        public static DataTable GetAllUsers()
        {
            return CMS_DataLayer.clsUser.GetAllUsers();
        }

        public static clsUser FindByUserID(int UserID)
        {
            int PersonID = -1;
            string Username = string.Empty;
            string Password = string.Empty;
            string Salt = string.Empty;
            int PermissionType = 1;
            bool IsActive = true;

            if (CMS_DataLayer.clsUser.GetUserByUserID(UserID, ref PersonID, ref Username, ref Password, ref Salt, ref PermissionType, ref IsActive))
            {
                return new clsUser(UserID, PersonID, Username, Password, Salt, PermissionType, IsActive);
            }
            return null;
        }

        public static clsUser FindByPersonID(int PersonID)
        {
            int UserID = -1;
            string Username = string.Empty;
            string Password = string.Empty;
            string Salt = string.Empty;
            int PermissionType = 1;
            bool IsActive = true;

            if (CMS_DataLayer.clsUser.GetUserByPersonID(PersonID, ref UserID, ref Username, ref Password, ref Salt, ref PermissionType, ref IsActive))
            {
                return new clsUser(PersonID, PersonID, Username, Password, Salt, PermissionType, IsActive);
            }
            return null;
        }

        public static clsUser FindByUsername(string Username)
        {
            string Password = string.Empty;
            string Salt = string.Empty;
            int UserID = -1;
            int PersonID = -1;
            int PermissionType = 1;
            bool IsActive = true;

            if (CMS_DataLayer.clsUser.GetUserByUsernameAndPassword(Username,ref Password, ref Salt, ref UserID, ref PersonID, ref PermissionType, ref IsActive))
            {
                return new clsUser(UserID, PersonID, Username, Password, Salt, PermissionType, IsActive);
            }
            return null;
        }

        bool _Add()
        {
            UserID = CMS_DataLayer.clsUser.AddNewUser(PersonID, Username, Password, Salt, PermissionType, IsActive);
            return (UserID != -1);
        }

        bool _Update()
        {
            return CMS_DataLayer.clsUser.UpdateUser(UserID, PersonID, Username, Password, Salt, PermissionType, IsActive);
        }

        public bool Save()
        {
            switch(Mode)
            {
                case enMode.Add:
                    {
                        if (_Add())
                        {
                            Mode = enMode.Add;
                            return true;
                        }
                        return false;
                    }
                case enMode.Update:
                    {
                        return _Update();
                    }
                default: return false;
            }
        }

        public static bool DeleteUser(int UserID)
        {
            return CMS_DataLayer.clsUser.DeleteUser(UserID);
        }

        public DataTable GetUserLogs()
        {
            return CMS_DataLayer.clsLog.GetAllLogsByUserID(UserID);
        }

        public static bool IsUserExistByUsername(string Username)
        {
            return CMS_DataLayer.clsUser.IsUserExistByUsername(Username);
        }

        public static bool ActivateUser(int UserID)
        {
            return CMS_DataLayer.clsUser.ActivateUser(UserID);
        }

        public static bool DeactivateUser(int UserID)
        {
            return CMS_DataLayer.clsUser.DeactivateUser(UserID);
        }
    }
}
