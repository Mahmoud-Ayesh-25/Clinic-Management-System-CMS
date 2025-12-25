using CMS_BusinessLayer;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinic_Manager_Proj.Classes
{
    public class clsMisc
    {
        public enum enTableName { Appointments, Doctors, Examinations, Patients, PaymentMethodes, Payments, People,
            PermissionsTypes, Users, Visits, Settings }

        public static string HashPassword(string password, string salt)
        {
            using (SHA256 sha = SHA256.Create())
            {
                var combined = password + salt;

                var bytes = Encoding.UTF8.GetBytes(combined);

                var hash = sha.ComputeHash(bytes);

                return Convert.ToBase64String(hash);
            }
        }

        // {Handle Image}
        static string _ReplaceImageNameWithGUID(FileInfo imageName)
        {
            string ex = imageName.Extension;

            return Guid.NewGuid().ToString() + ex;
        }

        static bool _CreateDirectoryIfNotExist(string directory)
        {
            if (!Directory.Exists(directory))
            {
                try
                {
                    Directory.CreateDirectory(directory);
                }
                catch (Exception e)
                {
                    MessageBox.Show($"Error: {e.ToString()}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            return true;
        }

        public static bool CopyImageToImagesFolder(ref string ImagePath)
        {
            string newImagePath = string.Empty;
            string directory = @"Images\";

            if (_CreateDirectoryIfNotExist(directory))
            {
                FileInfo image = new FileInfo(ImagePath);
                newImagePath = directory + _ReplaceImageNameWithGUID(image);

                try
                {
                    File.Copy(ImagePath, newImagePath);
                    ImagePath = newImagePath;
                }
                catch (Exception e)
                {
                    MessageBox.Show($"Error: {e.ToString()}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }

            return true;
        }
        /////////////////
        
        public static bool MakeLog(enTableName TableName, int RecordID, clsLog.enActionType ActionType)
        {
            clsLog log = new clsLog();

            log.TableName = TableName.ToString();
            log.RecordID = RecordID;
            log.ActionType = (int)ActionType;
            log.DateTime = DateTime.Now;
            log.UserID = clsProgramSettings.CurrentUser.UserID;

            return log.Save();
        }
    }
}
