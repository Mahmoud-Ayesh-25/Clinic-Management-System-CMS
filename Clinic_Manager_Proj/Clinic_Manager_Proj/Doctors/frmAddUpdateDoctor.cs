using Clinic_Manager_Proj.Classes;
using CMS_BusinessLayer;
using CuoreUI.Controls;
using DVLD_Project.MainSettings;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinic_Manager_Proj.Doctors
{
    public partial class frmAddUpdateDoctor : frmMain
    {
        enum enMode { Add, Update}
        enMode Mode;

        int DoctorID = -1;
        clsDoctor doctor = new clsDoctor();

        bool _IsValidHour(int Hour)
        {
            return (Hour > 0 && Hour < 13);
        }

        bool _IsValidMinute(int Minute)
        {
            return (Minute >= 0 && Minute < 60);
        }

        bool _IsAllFieldsFilled()
        {
            if (string.IsNullOrEmpty(tbxSpecialization.Content)) return false;
            if (string.IsNullOrEmpty(tbxExperienceYears.Content)) return false;
            if (string.IsNullOrEmpty(tbxExaminationPrice.Content)) return false;
            if (string.IsNullOrEmpty(tbxLicenseNo.Content)) return false;
            if (string.IsNullOrEmpty(tbxWorkFromHours.Content)) return false;
            if (string.IsNullOrEmpty(tbxWorkToHours.Content)) return false;
            if (string.IsNullOrEmpty(tbxWorkFromMin.Content)) return false;
            if (string.IsNullOrEmpty(tbxWorkToMin.Content)) return false;

            return true;
        }

        bool _IsValidTime()
        {
            if (!(_IsValidHour(int.Parse(tbxWorkFromHours.Content)) && _IsValidHour(int.Parse(tbxWorkToHours.Content)))) return false;
            if (!(_IsValidMinute(int.Parse(tbxWorkFromMin.Content)) && _IsValidMinute(int.Parse(tbxWorkToMin.Content)))) return false;

            return true;
        }

        string _OrganizeWeekDaysToSave()
        {
            string weekDays = string.Empty;

            if (chkSun.Checked) weekDays += ",Sun";
            if (chkMon.Checked) weekDays += ",Mon";
            if (chkTue.Checked) weekDays += ",Tue";
            if (chkWid.Checked) weekDays += ",Wid";
            if (chkThu.Checked) weekDays += ",Thu";
            if (chkFri.Checked) weekDays += ",Fri";
            if (chkSat.Checked) weekDays += ",Sat";

            weekDays = weekDays.Remove(0, 1);

            return weekDays;
        }

        void _SetWeekDays()
        {
            if (doctor.WeekDays.Contains("Sun")) chkSun.Checked = true;
            if (doctor.WeekDays.Contains("Mon")) chkMon.Checked = true;
            if (doctor.WeekDays.Contains("Tue")) chkTue.Checked = true;
            if (doctor.WeekDays.Contains("Wid")) chkWid.Checked = true;
            if (doctor.WeekDays.Contains("Thu")) chkThu.Checked = true;
            if (doctor.WeekDays.Contains("Fri")) chkFri.Checked = true;
            if (doctor.WeekDays.Contains("Sat")) chkSat.Checked = true;
        }
        bool _LoadDate()
        {
            doctor = clsDoctor.FindByDoctorID(DoctorID);

            if (doctor == null) return false;

            ctrlPersonCardWithSearch1.LoadData(doctor.PersonID);

            lblID.Content = $"ID: {doctor.DoctorID}";
            tbxSpecialization.Content = doctor.Specialization;
            tbxSubSpecialization.Content = doctor.SubSpecialization;
            tbxLicenseNo.Content = doctor.LicenseNo;
            cdpLicenseIssueDate.Content = doctor.LicenseIssueDate;
            cdpLicenseExpDate.Content = doctor.LicenseExpDate;
            _SetWeekDays();
            tbxExperienceYears.Content = doctor.ExperienceYears.ToString();
            tbxExaminationPrice.Content = doctor.ExaminationPrice.ToString();
            schActive.Checked = doctor.IsActive;

            if (doctor.WorkHourFrom.Hour != 12 && doctor.WorkHourFrom.Hour != 0)
            {
                if (doctor.WorkHourFrom.Hour > 12)
                {
                    btnWorkFromPM.Checked = true;
                    btnWorkFromAM.Checked = false;

                    tbxWorkFromHours.Content = (doctor.WorkHourFrom.Hour - 12).ToString();
                }
                else
                {
                    tbxWorkFromHours.Content = (doctor.WorkHourFrom.Hour).ToString();
                }
            }
            else
            {
                if (doctor.WorkHourFrom.Hour == 12)
                {
                    btnWorkFromPM.Checked = true;
                    btnWorkFromAM.Checked = false;
                }
                else
                {
                    btnWorkFromPM.Checked = false;
                    btnWorkFromAM.Checked = true;
                }

                tbxWorkFromHours.Content = "12";
            }
            tbxWorkFromMin.Content = doctor.WorkHourFrom.Minute.ToString();

            if (doctor.WorkHourTo.Hour != 12 && doctor.WorkHourTo.Hour != 0)
            {
                if (doctor.WorkHourTo.Hour > 12)
                {
                    btnWorkToPM.Checked = true;
                    btnWorkToAM.Checked = false;

                    tbxWorkToHours.Content = (doctor.WorkHourTo.Hour - 12).ToString();
                }
                else
                {
                    tbxWorkToHours.Content = (doctor.WorkHourTo.Hour).ToString();
                }
            }
            else
            {
                if (doctor.WorkHourTo.Hour == 12)
                {
                    btnWorkToPM.Checked = true;
                    btnWorkToAM.Checked = false;
                }
                else
                {
                    btnWorkToPM.Checked = false;
                    btnWorkToAM.Checked = true;
                }

                tbxWorkToHours.Content = "12";
            }
            tbxWorkToMin.Content = doctor.WorkHourTo.Minute.ToString();

            return true;
        }

        public frmAddUpdateDoctor()
        {
            InitializeComponent();

            Mode = enMode.Add;
            lblMainTitle.Content = "Add New Doctor";
            ctrlPersonCardWithSearch1.BringToFront();
            cdpLicenseIssueDate.Content = DateTime.Now;
            cdpLicenseExpDate.Content = DateTime.Now.AddYears(5).AddDays(-1);
        }

        public frmAddUpdateDoctor(int DoctorID)
        {
            InitializeComponent();

            this.DoctorID = DoctorID;
            Mode = enMode.Update;
            lblMainTitle.Content = "Edit Doctor";
            pnlDoctorDetails.BringToFront();
            btnBack.Visible = true;
            btnNext.Visible = false;
            btnSaveUser.Visible = true;
        }

        private void frmAddUpdateDoctor_Load(object sender, EventArgs e)
        {
            if (clsProgramSettings.CurrentUser.PermissionTypeEnum != clsUser.enPermissionType.Admin)
            {
                MessageBox.Show("You don't have the permissions for this.", "No Permissions", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                this.Close();
            }

            if (DoctorID != -1)
            {
                if (!_LoadDate())
                {
                    MessageBox.Show("Error while retrieving doctor data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (ctrlPersonCardWithSearch1.PersonID != -1)
            {
                if (clsDoctor.FindByPersonID(ctrlPersonCardWithSearch1.PersonID) != null && ctrlPersonCardWithSearch1.PersonID != doctor.PersonID)
                {
                    MessageBox.Show("This person is already a doctor.", "Cannot Now", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                else
                {
                    btnSaveUser.Visible = true;
                    btnNext.Visible = false;
                    btnBack.Visible = true;
                    pnlDoctorDetails.BringToFront();
                }
            }
            else
            {
                MessageBox.Show("You have to choose a person first.", "Cannot Now", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            btnSaveUser.Visible = false;
            btnNext.Visible = true;
            btnBack.Visible = false;
            ctrlPersonCardWithSearch1.BringToFront();
        }

        private void tbxEmpty_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(((cuiTextBox)sender).Content))
            {
                ((cuiTextBox)sender).OutlineColor = Color.Red;
                ((cuiTextBox)sender).PlaceholderColor = Color.Red;
                ((cuiTextBox)sender).ForeColor = Color.Red;
                ((cuiTextBox)sender).PlaceholderText = "Required";
            }
            else
            {
                ((cuiTextBox)sender).OutlineColor = Color.Black;
                ((cuiTextBox)sender).PlaceholderColor = Color.DimGray;
                ((cuiTextBox)sender).ForeColor = Color.White;
            }
        }

        private void tbxWorkFromHours_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(((cuiTextBox)sender).Content))
            {
                ((cuiTextBox)sender).OutlineColor = Color.Red;
                ((cuiTextBox)sender).PlaceholderColor = Color.Red;
                ((cuiTextBox)sender).ForeColor = Color.Red;
                ((cuiTextBox)sender).PlaceholderText = "Required";
            }
            else if (!_IsValidHour(int.Parse(((cuiTextBox)sender).Content)))
            {
                ((cuiTextBox)sender).OutlineColor = Color.Red;
                ((cuiTextBox)sender).PlaceholderColor = Color.Red;
                ((cuiTextBox)sender).ForeColor = Color.Red;
            }
            else
            {
                ((cuiTextBox)sender).OutlineColor = Color.Black;
                ((cuiTextBox)sender).PlaceholderColor = Color.DimGray;
                ((cuiTextBox)sender).ForeColor = Color.White;
            }
        }

        private void tbxWorkFromMin_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(((cuiTextBox)sender).Content))
            {
                ((cuiTextBox)sender).Content = "0";

                ((cuiTextBox)sender).OutlineColor = Color.Black;
                ((cuiTextBox)sender).PlaceholderColor = Color.DimGray;
                ((cuiTextBox)sender).ForeColor = Color.White;
            }
            else if (!_IsValidMinute(int.Parse(((cuiTextBox)sender).Content)))
            {
                ((cuiTextBox)sender).OutlineColor = Color.Red;
                ((cuiTextBox)sender).PlaceholderColor = Color.Red;
                ((cuiTextBox)sender).ForeColor = Color.Red;
            }
        }

        private void tbxExperienceYears_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!clsValidation.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbxExaminationPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!clsValidation.IsDigit(e.KeyChar))
            {
                if (e.KeyChar != '.')
                {
                    e.Handled = true;
                }
            }
        }

        private void tbxLicenseNo_Validating(object sender, CancelEventArgs e)
        {
            if (clsDoctor.IsDoctorExistByLicenseNo(tbxLicenseNo.Content))
            {
                if (Mode == enMode.Update)
                {
                    if (tbxLicenseNo.Content != doctor.LicenseNo)
                    {
                        tbxLicenseNo.OutlineColor = Color.Red;
                        tbxLicenseNo.PlaceholderColor = Color.Red;
                        tbxLicenseNo.ForeColor = Color.Red;

                        return;
                    }
                }
                else
                {
                    tbxLicenseNo.OutlineColor = Color.Red;
                    tbxLicenseNo.PlaceholderColor = Color.Red;
                    tbxLicenseNo.ForeColor = Color.Red;

                    return;
                }
            }

            if (string.IsNullOrEmpty(tbxLicenseNo.Content))
            {
                tbxLicenseNo.OutlineColor = Color.Red;
                tbxLicenseNo.PlaceholderColor = Color.Red;
                tbxLicenseNo.ForeColor = Color.Red;
                tbxLicenseNo.PlaceholderText = "Required";

                return;
            }
            else
            {
                tbxLicenseNo.OutlineColor = Color.Black;
                tbxLicenseNo.PlaceholderColor = Color.DimGray;
                tbxLicenseNo.ForeColor = Color.White;
            }
        }

        private void btnSaveUser_Click(object sender, EventArgs e)
        {
            if (!_IsAllFieldsFilled())
            {
                MessageBox.Show("Make sure to fill in all the required fields.", "Cannot Save Now", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }

            if (clsDoctor.IsDoctorExistByLicenseNo(tbxLicenseNo.Content))
            {
                if (Mode == enMode.Add)
                {
                    MessageBox.Show("There is already a doctor who has the same license number.", "Cannot Save Now", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    return;
                }
                else
                {
                    if (tbxLicenseNo.Content != doctor.LicenseNo)
                    {
                        MessageBox.Show("There is already a doctor who has the same license number.", "Cannot Save Now", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        return;
                    }
                }
            }

            if (!_IsValidTime())
            {
                MessageBox.Show("Error in work time.", "Cannot Save Now", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }

            doctor.PersonID = ctrlPersonCardWithSearch1.PersonID;
            doctor.Specialization = tbxSpecialization.Content;
            doctor.SubSpecialization = tbxSubSpecialization.Content;
            doctor.LicenseNo = tbxLicenseNo.Content;
            doctor.LicenseIssueDate = cdpLicenseIssueDate.Content;
            doctor.LicenseExpDate = cdpLicenseExpDate.Content;
            doctor.ExperienceYears = byte.Parse(tbxExperienceYears.Content);
            doctor.WeekDays = _OrganizeWeekDaysToSave();

            int hourFrom = 0;

            if (tbxWorkFromHours.Content == "12")
            {
                if (btnWorkFromPM.Checked) hourFrom = 12;
                else hourFrom = 0;
            }
            else
            {
                if (btnWorkFromPM.Checked)
                {
                    hourFrom = int.Parse(tbxWorkFromHours.Content) + 12; 
                }
                else
                {
                    hourFrom = int.Parse(tbxWorkFromHours.Content);
                }
            }

            int hourTo = 0;

            if (tbxWorkToHours.Content == "12")
            {
                if (btnWorkToPM.Checked) hourTo = 12;
                else hourTo = 0;
            }
            else
            {
                if (btnWorkToPM.Checked)
                {
                    hourTo = int.Parse(tbxWorkToHours.Content) + 12;
                }
                else
                {
                    hourTo = int.Parse(tbxWorkToHours.Content);
                }
            }

            doctor.WorkHourFrom = new DateTime(1800, 1, 1, hourFrom, int.Parse(tbxWorkFromMin.Content), 0);
            doctor.WorkHourTo = new DateTime(1800, 1, 1, hourTo, int.Parse(tbxWorkToMin.Content), 0);
            doctor.ExaminationPrice = float.Parse(tbxExaminationPrice.Content);
            doctor.IsActive = schActive.Checked;

            if (doctor.Save())
            {
                if (Mode == enMode.Add)
                {
                    Mode = enMode.Update;
                    DoctorID = doctor.DoctorID;
                    lblID.Content = $"ID: {DoctorID}";
                    lblMainTitle.Content = "Edit Doctor";
                    ctrlPersonCardWithSearch1.LoadData(doctor.PersonID);

                    if (!clsMisc.MakeLog(clsMisc.enTableName.Doctors, DoctorID, clsLog.enActionType.AddNew))
                    {
                        MessageBox.Show($"An error occurred while saving the log.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    if (!clsMisc.MakeLog(clsMisc.enTableName.Doctors, DoctorID, clsLog.enActionType.Update))
                    {
                        MessageBox.Show($"An error occurred while saving the log.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                MessageBox.Show($"The doctor has been saved successfully with ID[{DoctorID}].", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"An error occurred while saving the doctor, most likely due to a connection error with the database, either because it was deleted or because it was moved from its expected location.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
