using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS_DataLayer
{
    public class clsDataAccessSettings
    {
        static string mdf_path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Clinic Management System", "Clinic_Manager_DB.mdf");

        public static string ConnectionString = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={mdf_path};Integrated Security=True;Connect Timeout=30";
    }
}
