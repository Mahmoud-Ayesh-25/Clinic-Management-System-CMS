using CMS_BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinic_Manager_Proj.Logs.Controls
{
    public partial class ctrlLogCard : UserControl
    {
        clsLog log = new clsLog();

        public bool LoadData(int LogID)
        {
            log = clsLog.Find(LogID);

            if (log == null) return false;

            lblLogID.Content = $"Log ID: {log.LogID}";
            lblUsername.Content = $"Username: {log.UserInfo.Username}";
            lblTableName.Content = $"Table Name: {log.TableName}";
            lblRecordID.Content = $"Record ID: {log.RecordID}";
            lblActionType.Content = $"Action Type: {log.ActionTypeEnum.ToString()}";
            lblDate.Content = $"Date Time: {log.DateTime.ToShortDateString()} {log.DateTime.ToShortTimeString()}";

            return true;
        }

        public ctrlLogCard()
        {
            InitializeComponent();
        }
    }
}
