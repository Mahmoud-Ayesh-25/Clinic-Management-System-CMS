using Clinic_Manager_Proj.Appointments;
using Clinic_Manager_Proj.Classes;
using Clinic_Manager_Proj.Doctors;
using Clinic_Manager_Proj.Patients;
using Clinic_Manager_Proj.Payments;
using Clinic_Manager_Proj.People;
using Clinic_Manager_Proj.Settings;
using Clinic_Manager_Proj.Settings.Notifications;
using Clinic_Manager_Proj.Users;
using Clinic_Manager_Proj.Visits;
using CMS_BusinessLayer;
using DVLD_Project;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Media;
using System.Windows.Forms;

namespace Clinic_Manager_Proj
{
    public partial class frmDashboard : frmMain
    {
        // {Handle Size}

        void HandleSideOptionsMargin(int margin)
        {
            btnPeopleMang.Margin = new Padding(3, margin, 3, 3);
            btnUsersMang.Margin = new Padding(3, margin, 3, 3);
            btnDoctorsMang.Margin = new Padding(3, margin, 3, 3);
            btnPatientsMang.Margin = new Padding(3, margin, 3, 3);
            btnPaymentsMang.Margin = new Padding(3, margin, 3, 3);
            btnAppointmantsMang.Margin = new Padding(3, margin, 3, 3);
            btnVisitsMang.Margin = new Padding(3, margin, 3, 3);
            btnSettingsMang.Margin = new Padding(3, margin, 3, 3);
            btnLogout.Margin = new Padding(3, margin, 3, 3);
        }

        void dgvAppointments_HandleSize()
        {
            dgvAppointments.Width = pnlAppointmants.Width;
            dgvAppointments.Height = pnlAppointmants.Height - 80;
            dgvAppointments.Location = new Point(0, 60); 
        }

        void dgvInProgressVisits_HandleSize()
        {
            dgvInProgressVisits.Width = ((pnlVisits.Width * 50) / 100) - 8;
            dgvInProgressVisits.Height = pnlVisits.Height - 80;
            dgvInProgressVisits.Location = new Point(0, 60);
        }

        void dgvWaitingVisits_HandleSize()
        {
            dgvWaitingVisits.Width = ((pnlVisits.Width * 50) / 100) - 8;
            dgvWaitingVisits.Height = pnlVisits.Height - 80;
            dgvWaitingVisits.Location = new Point((dgvInProgressVisits.Width) + 16, 60);
            lblWatitingVisits.Location = new Point(dgvWaitingVisits.Location.X + 10, 10);
            sepVisits.Location = new Point(dgvWaitingVisits.Location.X - 12, 0);
            sepVisits.Height = pnlVisits.Height;
        }

        void HandleSize()
        {
            pnlMenu.Height = this.Height - 99;
            pnlVisits.Width = (this.Width * 58) / 100;
            pnlVisits.Height = this.Height - 433;
            flpContainer.Width = this.Width - 291;
            flpContainer.Height = this.Height - 99;
            pnlAppointmants.Width = (this.Width * 26) / 100;
            pnlAppointmants.Height = this.Height - 433;

            float smallCardsMargin = ((flpContainer.Width - 1128) / 3) - 7;
            
            pnlEmergancyCases.Margin = new Padding(3, 3, (int)smallCardsMargin, 3);
            pnlCompleteVisits.Margin = new Padding(3, 3, (int)smallCardsMargin, 3);
            pnlUpcommingAppointments.Margin = new Padding(3, 3, (int)smallCardsMargin, 3);

            pnlRemaining.Margin = new Padding(3, 3, (int)smallCardsMargin, 3);
            pnlNumberOfReceipts.Margin = new Padding(3, 3, (int)smallCardsMargin, 3);
            pnlTodayPayments.Margin = new Padding(3, 3, (int)smallCardsMargin, 3);

            flpMenuOptionsContainer.Height = (pnlMenu.Height * 70) / 100;
            flpMenuOptionsContainer.Location = new Point(17, (pnlMenu.Height * 29) / 100);

            float sideMenuOptionsMargin = ((flpMenuOptionsContainer.Height - 405) / 9) - 4;

            HandleSideOptionsMargin((int)sideMenuOptionsMargin);

            // {DataGridView - Handle Size Section}

            dgvAppointments_HandleSize();
            dgvInProgressVisits_HandleSize();
            dgvWaitingVisits_HandleSize();
            
            //////////////////////////////////////
        }

        ///////////////


        // {Load Data}
        DataTable dtAppointments = new DataTable();
        DataTable dtInProgressVisits = new DataTable();
        DataTable dtWaitingVisits = new DataTable();
        DataTable dtDoctors = new DataTable();


        // {Load And Filter Data To Grid Views}
        void dgvAppointments_Refresh()
        {
            dtAppointments = clsAppointment.GetAllAppointments();

            if (dtAppointments.Rows.Count > 0)
            {
                DataView view = dtAppointments.DefaultView;
                view.RowFilter = $@"DoctorName = '{cbxDoctor.SelectedItem}' AND Status = 'Scheduled'
                AND AppointmantDate = '{cdpDate.Content.ToShortDateString().Replace('/', '-')}'";
                dgvAppointments.DataSource = view;
            }
        }

        void dgvInProgressVisits_Refresh()
        {
            dtInProgressVisits = clsVisit.GetAllVisitsForDashboard();

            if (dtInProgressVisits.Rows.Count > 0)
            {
                DataView view = dtInProgressVisits.DefaultView;
                view.RowFilter = $@"DoctorName = '{cbxDoctor.SelectedItem}' AND VisitDate =
                '{cdpDate.Content.ToShortDateString().Replace('/', '-')}' AND VisitStatus = 2";
                dgvInProgressVisits.DataSource = view;
            }
        }

        void dgvWaitingVisits_Refresh()
        {
            dtWaitingVisits = clsVisit.GetAllVisitsForDashboard();

            if (dtWaitingVisits.Rows.Count > 0)
            {
                DataView view = dtWaitingVisits.DefaultView;
                view.RowFilter = $@"DoctorName = '{cbxDoctor.SelectedItem}' AND VisitDate =
                '{cdpDate.Content.ToShortDateString().Replace('/', '-')}' AND VisitStatus = 1";
                dgvWaitingVisits.DataSource = view;
            }
        }

        //////////////////////////////////////

        void cbxDoctors_AddItems()
        {
            dtDoctors = clsDoctor.GetAllDoctors();

            if (dtDoctors.Rows.Count > 0)
            {
                foreach (DataRow row in dtDoctors.Rows)
                {
                    try
                    {
                        cbxDoctor.RemoveItem(row[2].ToString());
                    }
                    catch { }

                    cbxDoctor.AddItem(row[2].ToString());
                }
            }
            
        }


        // {Organize Data Grid Views Columns}

        // {dgvAppointments}
        void Organize_dgvAppointmentsColumnsWidth()
        {
            dgvAppointments.Columns["PatientName"].Width = ((dgvAppointments.Width * 31) / 100);
            dgvAppointments.Columns["AppointmantTime"].Width = ((dgvAppointments.Width * 21) / 100);
            dgvAppointments.Columns["Notes"].Width = ((dgvAppointments.Width * 48) / 100) + 10;
        }
        void Organize_gdvAppointmentsColumns()
        {
            if (dgvAppointments.Rows.Count == 0)
            {
                dgvAppointments.Visible = false;
                return;
            }
            else dgvAppointments.Visible = true;

            dgvAppointments.Columns["Status"].Visible = false;
            dgvAppointments.Columns["AppointmantDate"].Visible = false;
            dgvAppointments.Columns["DoctorName"].Visible = false;
            dgvAppointments.Columns["AppointmentID"].Visible = false;

            dgvAppointments.Columns["PatientName"].HeaderText = "Name";
            dgvAppointments.Columns["AppointmantTime"].HeaderText = "Time";
            dgvAppointments.Columns["Notes"].HeaderText = "Notes";

            Organize_dgvAppointmentsColumnsWidth();
        }


        // {dgvVisits}
        void Organize_dgvVisitsColumnsWidth(DataGridView dgv)
        {
            dgv.Columns["PatientName"].Width = (dgv.Width * 25) / 100;
            dgv.Columns["VisitTime"].Width = (dgv.Width * 15) / 100;
            dgv.Columns["EmergencyIncome"].Width = (dgv.Width * 12) / 100;
            dgv.Columns["VisitReason"].Width = (dgv.Width * 20) / 100;
            dgv.Columns["PaymentAmount"].Width = (dgv.Width * 14) / 100;
            dgv.Columns["PaidAmount"].Width = ((dgv.Width * 14) / 100) + 10;
        }
        void Organize_dgvVisitsColumns(DataGridView dgv)
        {
            if (dgv.Rows.Count == 0)
            {
                dgv.Visible = false;
                return;
            }
            else dgv.Visible = true;

            dgv.Columns["DoctorName"].Visible = false;
            dgv.Columns["VisitDate"].Visible = false;
            dgv.Columns["VisitStatus"].Visible = false;
            dgv.Columns["VisitID"].Visible = false;

            dgv.Columns["PatientName"].HeaderText = "Name";
            dgv.Columns["VisitTime"].HeaderText = "Time";
            dgv.Columns["EmergencyIncome"].HeaderText = "EMERG";
            dgv.Columns["VisitReason"].HeaderText = "V. Reason";
            dgv.Columns["PaymentAmount"].HeaderText = "Payment";
            dgv.Columns["PaidAmount"].HeaderText = "Paid";

            Organize_dgvVisitsColumnsWidth(dgv);
        }

        ////////////////////////////////////

        // {Load Small Cards}

        void SetEmergencyCasesNumber()
        {
            DataTable dtVisits = clsVisit.GetAllVisits();
            
            if (dtVisits.Rows.Count > 0)
            {
                DataView view = dtVisits.DefaultView;
                view.RowFilter = $"EmergencyIncome = 1 AND VisitDate = '{cdpDate.Content.ToShortDateString().Replace("/", "-")}'";

                int EmergencyCasesNumber = 0;

                foreach(DataRowView drv in view)
                {
                    if ((bool)drv[7])
                        EmergencyCasesNumber++;
                }

                lblEmergencyCases.Content = EmergencyCasesNumber.ToString();
            }
        }

        void SetCompleteVisitsNumber()
        {
            DataTable dtVisits = clsVisit.GetAllVisits();

            if (dtVisits.Rows.Count > 0)
            {
                DataView view = dtVisits.DefaultView;
                view.RowFilter = $"VisitStatus = 'Completed' AND VisitDate = '{cdpDate.Content.ToShortDateString().Replace('/', '-')}'";

                int CompleteVisitsNumber = 0;

                foreach (DataRowView drv in view)
                {
                    CompleteVisitsNumber++;
                }

                lblCompleteVisits.Content = CompleteVisitsNumber.ToString();
            }
        }

        void SetAppointmentsNumber()
        {
            DataTable dtAppointments = clsAppointment.GetAppointmentsByDate(cdpDate.Content);

            lblAppointment.Content = dtAppointments.Rows.Count.ToString();
        }

        void SetTodayPatientsNumber()
        {
            DataTable dtPatients = clsPatient.GetAllPatients();

            if (dtPatients.Rows.Count > 0)
            {
                DataView dv = dtPatients.DefaultView;
                dv.RowFilter = $"CreateDate = '{cdpDate.Content.ToShortDateString().Replace('/', '-')}'";

                int TodayPatientsNumber = 0;

                foreach(DataRowView drv in dv)
                {
                    TodayPatientsNumber++;
                }

                lblTodayPatients.Content = TodayPatientsNumber.ToString();
            }
        }

        void SetTodayPaymentsAndTotalReceipts()
        {
            DataTable dtPayments = clsPayment.GetAllPayments();

            if (dtPayments.Rows.Count > 0)
            {
                DataView dv = dtPayments.DefaultView;
                dv.RowFilter = $"Date = '{cdpDate.Content.ToShortDateString().Replace('/', '-')}' AND Status = 'Completed'";

                float TodayPayments = 0;
                int TotalReceipts = 0;

                foreach (DataRowView drv in dv)
                {
                    TodayPayments = TodayPayments + float.Parse(drv["PaidAmount"].ToString());
                    TotalReceipts++;
                }

                lblTodayPayments.Content = TodayPayments.ToString();
                lblNumberOfReceipts.Content = TotalReceipts.ToString();
            }
        }

        void SetRemainingPayments()
        {
            DataTable dtVisits = clsVisit.GetAllVisits();

            if (dtVisits.Rows.Count > 0)
            {
                DataView view = dtVisits.DefaultView;
                view.RowFilter = $"VisitDate = '{cdpDate.Content.ToShortDateString().Replace('/', '-')}' AND VisitStatus NOT LIKE 'Cancelled'";

                float RemainingPayments = 0;

                foreach (DataRowView drv in view)
                {
                    RemainingPayments = RemainingPayments + (float.Parse(drv["PaymentAmount"].ToString()) - float.Parse(drv["PaidAmount"].ToString()));
                }

                lblRemainingPayments.Content = RemainingPayments.ToString();
            }
        }

        /////////////////////////////////////////

        void LoadData()
        {
            cbxDoctors_AddItems();
            dgvAppointments_Refresh();
            dgvInProgressVisits_Refresh();
            dgvWaitingVisits_Refresh();

            Organize_gdvAppointmentsColumns();
            Organize_dgvVisitsColumns(dgvWaitingVisits);
            Organize_dgvVisitsColumns(dgvInProgressVisits);

            SetEmergencyCasesNumber();
            SetCompleteVisitsNumber();
            SetAppointmentsNumber();
            SetTodayPatientsNumber();
            SetTodayPaymentsAndTotalReceipts();
            SetRemainingPayments();
        }

        //////////////

        frmLogin loginForm;

        public frmDashboard(frmLogin loginForm)
        {
            InitializeComponent();

            cmsAppointments.Renderer = new MyMenuRenderer();
            dgvAppointments.ContextMenuStrip = cmsAppointments;

            cmsWaitingVisits.Renderer = new MyMenuRenderer();
            dgvWaitingVisits.ContextMenuStrip = cmsWaitingVisits;

            cmsInProgressVisits.Renderer = new MyMenuRenderer();
            dgvInProgressVisits.ContextMenuStrip = cmsInProgressVisits;

            this.loginForm = loginForm;
        }

        // this get the settings data from database and put them in clsProgramSettings class members
        bool SetSettings()
        {
            clsSettings settings = clsSettings.Get();

            if (settings == null) return false;

            clsProgramSettings.Notifications = settings.Notifications;

            return true;
        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {
            if (!SetSettings())
            {
                MessageBox.Show("Something wrong with the settings table in the database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }

            cdpDate.Content = DateTime.Now;
            cbxDoctors_AddItems();
            LoadData();

            if (clsProgramSettings.Notifications)
                NotificationsTimer.Start();

            _RefreshUnreadableNotifications();
        }

        private void frmDashboard_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;

            HandleSize();
        }

        protected override void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to close the Clinic Management System?", "Confirm Closure",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                loginForm.Close();
                this.Close();
            }
        }















        // {DESIGN} //
        private void pnlNotifications_MouseEnter(object sender, EventArgs e)
        {
            pnlNotifications.PanelColor1 = Color.FromArgb(110, 30, 0);
            pnlNotifications.PanelColor2 = Color.FromArgb(70, 0, 0);
        }

        private void pnlNotifications_MouseLeave(object sender, EventArgs e)
        {
            pnlNotifications.PanelColor1 = Color.FromArgb(120, 40, 0);
            pnlNotifications.PanelColor2 = Color.FromArgb(80, 0, 0);
        }

        private void pnlNotifications_MouseDown(object sender, MouseEventArgs e)
        {
            pnlNotifications.PanelColor1 = Color.FromArgb(100, 20, 0);
            pnlNotifications.PanelColor2 = Color.FromArgb(60, 0, 0);
        }

        private void pnlNotifications_MouseUp(object sender, MouseEventArgs e)
        {
            pnlNotifications.PanelColor1 = Color.FromArgb(110, 30, 0);
            pnlNotifications.PanelColor2 = Color.FromArgb(70, 0, 0);
        }
        //////////

        private void cbxDoctor_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private void cdpDate_DateChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnUsersMang_Click(object sender, EventArgs e)
        {
            frmManageUsers users = new frmManageUsers();
            users.ShowDialog();

            LoadData();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to log out and return to the login interface?", "Confirm Logout"
                , MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                loginForm.Show();
                this.Close();
            }
        }

        private void btnPeopleMang_Click(object sender, EventArgs e)
        {
            frmManagePeople people = new frmManagePeople();
            people.ShowDialog();

            LoadData();
        }

        private void btnDoctorsMang_Click(object sender, EventArgs e)
        {
            frmManageDoctors doctors = new frmManageDoctors();
            doctors.ShowDialog();

            LoadData();
        }

        private void btnPatientsMang_Click(object sender, EventArgs e)
        {
            frmManagePatients patients = new frmManagePatients();
            patients.ShowDialog();

            LoadData();
        }

        private void btnPaymentsMang_Click(object sender, EventArgs e)
        {
            frmManagePayments payments = new frmManagePayments();
            payments.ShowDialog();
        }

        private void btnAppointmantsMang_Click(object sender, EventArgs e)
        {
            frmManageAppointment appointment = new frmManageAppointment();
            appointment.ShowDialog();

            LoadData();
        }

        private void btnAddAppointment_Click(object sender, EventArgs e)
        {
            frmAddUpdateAppointment appointment = new frmAddUpdateAppointment();
            appointment.ShowDialog();

            LoadData();
        }

        private void btnVisitsMang_Click(object sender, EventArgs e)
        {
            frmManageVisits visits = new frmManageVisits();
            visits.ShowDialog();

            LoadData();
        }

        private void btnAddVisit_Click(object sender, EventArgs e)
        {
            frmAddVisit visit = new frmAddVisit();
            visit.ShowDialog();

            LoadData();
        }

        private void showInfoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (dgvAppointments.CurrentRow == null)
                return;

            frmShowAppointmentInfo appointment = new frmShowAppointmentInfo(int.Parse(dgvAppointments.CurrentRow.Cells[0].Value.ToString()));
            appointment.ShowDialog();

            LoadData();
        }

        private void makeVisitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvAppointments.CurrentRow == null)
                return;

            frmAddVisit visit = new frmAddVisit(int.Parse(dgvAppointments.CurrentRow.Cells[0].Value.ToString()));
            visit.ShowDialog();

            LoadData();
        }

        private void setCancelledToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvAppointments.CurrentRow == null)
                return;

            if (MessageBox.Show("Are you sure you want to cancel this appointment?", "Cancel Confirmation",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (!clsAppointment.SetAppointmentStatus(int.Parse(dgvAppointments.CurrentRow.Cells[0].Value.ToString()),
                    clsAppointment.enStatus.Cancelled))
                {
                    MessageBox.Show("Error while updating the appointment status.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    if (!clsMisc.MakeLog(clsMisc.enTableName.Appointments, int.Parse(dgvAppointments.CurrentRow.Cells[0].Value.ToString()),
                        clsLog.enActionType.Update))
                    {
                        MessageBox.Show($"An error occurred while saving the log.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                LoadData();
            }
        }

        private void setNoShowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvAppointments.CurrentRow == null)
                return;

            if (MessageBox.Show("Are you sure you want to change this appointment status to No Show?", "Change Confirmation",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (!clsAppointment.SetAppointmentStatus(int.Parse(dgvAppointments.CurrentRow.Cells[0].Value.ToString()),
                    clsAppointment.enStatus.NoShow))
                {
                    MessageBox.Show("Error while updating the appointment status.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    if (!clsMisc.MakeLog(clsMisc.enTableName.Appointments, int.Parse(dgvAppointments.CurrentRow.Cells[0].Value.ToString()),
                        clsLog.enActionType.Update))
                    {
                        MessageBox.Show($"An error occurred while saving the log.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                LoadData();
            }
        }

        private void WaitingVisit_toolStripMenuItem_Cancel_Click(object sender, EventArgs e)
        {
            if (dgvWaitingVisits.CurrentRow == null)
                return;

            if (MessageBox.Show("Are you sure you want to cancel this visit?", "Cancel Confirmation",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (!clsVisit.SetVisitStatus(int.Parse(dgvWaitingVisits.CurrentRow.Cells[0].Value.ToString()),
                    clsVisit.enVisitStatus.Cancelled))
                {
                    MessageBox.Show("Error while updating the appointment status.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    DataTable dtPayments = clsPayment.GetAllPaymentsByVisitID(int.Parse(dgvWaitingVisits.CurrentRow.Cells[0].Value.ToString()));

                    if (dtPayments.Rows.Count > 0)
                    {
                        foreach (DataRow dr in dtPayments.Rows)
                        {
                            if (dr["Status"].ToString() != "Cancelled")
                            {
                                clsPayment payment = clsPayment.Find(int.Parse(dr["PaymentID"].ToString()));
                                payment.Status = 2;

                                if (payment.Save())
                                {
                                    if (!clsMisc.MakeLog(clsMisc.enTableName.Payments, payment.PaymentID, clsLog.enActionType.Update))
                                    {
                                        MessageBox.Show($"An error occurred while saving the log.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Error while updating payment status.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                    }

                    if (!clsMisc.MakeLog(clsMisc.enTableName.Visits, int.Parse(dgvWaitingVisits.CurrentRow.Cells[0].Value.ToString()),
                        clsLog.enActionType.Update))
                    {
                        MessageBox.Show($"An error occurred while saving the log.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                LoadData();
            }
        }

        private void setInProgressToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvWaitingVisits.CurrentRow == null)
                return;

            if (MessageBox.Show("Are you sure you want to change this visit to In Progress?", "Change Confirmation",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (!clsVisit.SetVisitStatus(int.Parse(dgvWaitingVisits.CurrentRow.Cells[0].Value.ToString()),
                    clsVisit.enVisitStatus.InProgress))
                {
                    MessageBox.Show("Error while updating the appointment status.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    if (!clsMisc.MakeLog(clsMisc.enTableName.Visits, int.Parse(dgvWaitingVisits.CurrentRow.Cells[0].Value.ToString()),
                        clsLog.enActionType.Update))
                    {
                        MessageBox.Show($"An error occurred while saving the log.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                LoadData();
            }
        }

        private void showInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvWaitingVisits.CurrentRow == null)
                return;

            frmShowVisitInfo visit = new frmShowVisitInfo(int.Parse(dgvWaitingVisits.CurrentRow.Cells[0].Value.ToString()));
            visit.ShowDialog();

            LoadData();
        }

        private void sendToEmergencyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvWaitingVisits.CurrentRow == null)
                return;

            if (MessageBox.Show("Are you sure you want to send this visit to Emergency?", "Change Confirmation",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (!clsVisit.SetEmergencyTrue(int.Parse(dgvWaitingVisits.CurrentRow.Cells[0].Value.ToString())))
                {
                    MessageBox.Show("Error while updating the appointment.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    if (!clsMisc.MakeLog(clsMisc.enTableName.Visits, int.Parse(dgvWaitingVisits.CurrentRow.Cells[0].Value.ToString()),
                        clsLog.enActionType.Update))
                    {
                        MessageBox.Show($"An error occurred while saving the log.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                LoadData();
            }
        }

        private void toolStripMenuItem_ShowInfo_Click(object sender, EventArgs e)
        {
            if (dgvInProgressVisits.CurrentRow == null)
                return;

            frmShowVisitInfo visit = new frmShowVisitInfo(int.Parse(dgvInProgressVisits.CurrentRow.Cells[0].Value.ToString()));
            visit.ShowDialog();

            LoadData();
        }

        private void toolStripMenuItem_Complete_Click(object sender, EventArgs e)
        {
            if (dgvInProgressVisits.CurrentRow == null)
                return;

            frmEditVisit visit = new frmEditVisit(int.Parse(dgvInProgressVisits.CurrentRow.Cells[0].Value.ToString()));
            visit.ShowDialog();

            LoadData();
        }

        private void toolStripMenuItem_Cancel_Click(object sender, EventArgs e)
        {
            if (dgvInProgressVisits.CurrentRow == null)
                return;

            if (MessageBox.Show("Are you sure you want to cancel this visit?", "Cancel Confirmation",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (!clsVisit.SetVisitStatus(int.Parse(dgvInProgressVisits.CurrentRow.Cells[0].Value.ToString()),
                    clsVisit.enVisitStatus.Cancelled))
                {
                    MessageBox.Show("Error while updating the appointment status.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    DataTable dtPayments = clsPayment.GetAllPaymentsByVisitID(int.Parse(dgvInProgressVisits.CurrentRow.Cells[0].Value.ToString()));

                    if (dtPayments.Rows.Count > 0)
                    {
                        foreach (DataRow dr in dtPayments.Rows)
                        {
                            if (dr["Status"].ToString() != "Cancelled")
                            {
                                clsPayment payment = clsPayment.Find(int.Parse(dr["PaymentID"].ToString()));
                                payment.Status = 2;

                                if (payment.Save())
                                {
                                    if (!clsMisc.MakeLog(clsMisc.enTableName.Payments, payment.PaymentID, clsLog.enActionType.Update))
                                    {
                                        MessageBox.Show($"An error occurred while saving the log.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Error while updating payment status.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                    }

                    if (!clsMisc.MakeLog(clsMisc.enTableName.Visits, int.Parse(dgvInProgressVisits.CurrentRow.Cells[0].Value.ToString()),
                        clsLog.enActionType.Update))
                    {
                        MessageBox.Show($"An error occurred while saving the log.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                LoadData();
            }
        }

        private void toolStripMenuItem_SendToEmergency_Click(object sender, EventArgs e)
        {
            if (dgvInProgressVisits.CurrentRow == null)
                return;

            if (MessageBox.Show("Are you sure you want to send this visit to Emergency?", "Change Confirmation",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (!clsVisit.SetEmergencyTrue(int.Parse(dgvInProgressVisits.CurrentRow.Cells[0].Value.ToString())))
                {
                    MessageBox.Show("Error while updating the appointment.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    if (!clsMisc.MakeLog(clsMisc.enTableName.Visits, int.Parse(dgvInProgressVisits.CurrentRow.Cells[0].Value.ToString()),
                        clsLog.enActionType.Update))
                    {
                        MessageBox.Show($"An error occurred while saving the log.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                LoadData();
            }
        }

        private void payToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvWaitingVisits.CurrentRow == null)
                return;

            frmAddPayment payment = new frmAddPayment(int.Parse(dgvWaitingVisits.CurrentRow.Cells[0].Value.ToString()));
            payment.ShowDialog();

            LoadData();
        }

        private void payToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (dgvInProgressVisits.CurrentRow == null)
                return;

            frmAddPayment payment = new frmAddPayment(int.Parse(dgvInProgressVisits.CurrentRow.Cells[0].Value.ToString()));
            payment.ShowDialog();

            LoadData();
        }

        private void cmsInProgressVisits_Opening(object sender, CancelEventArgs e)
        {
            if (dgvInProgressVisits.CurrentRow == null) return;

            cmsInProgressVisits.Items[6].Enabled = false;
            cmsInProgressVisits.Items[4].Enabled = false;

            clsVisit visit = clsVisit.Find(int.Parse(dgvInProgressVisits.CurrentRow.Cells[0].Value.ToString()));

            if (visit == null) return;

            if (!visit.EmergencyIncome)
            {
                cmsInProgressVisits.Items[4].Enabled = true;
            }

            if (visit.PaymentAmount > visit.PaidAmount)
            {
                cmsInProgressVisits.Items[6].Enabled = true;
            }
        }

        private void cmsWaitingVisits_Opening(object sender, CancelEventArgs e)
        {
            if (dgvWaitingVisits.CurrentRow == null) return;

            cmsWaitingVisits.Items[6].Enabled = false;
            cmsWaitingVisits.Items[4].Enabled = false;

            clsVisit visit = clsVisit.Find(int.Parse(dgvWaitingVisits.CurrentRow.Cells[0].Value.ToString()));

            if (visit == null) return;

            if (!visit.EmergencyIncome)
            {
                cmsWaitingVisits.Items[4].Enabled = true;
            }

            if (visit.PaymentAmount > visit.PaidAmount)
            {
                cmsWaitingVisits.Items[6].Enabled = true;
            }
        }

        private void btnSettingsMang_Click(object sender, EventArgs e)
        {
            frmMainSettings settings = new frmMainSettings();
            settings.ShowDialog();

            _RefreshUnreadableNotifications();

            if (clsProgramSettings.Notifications)
            {
                NotificationsTimer.Stop();
                NotificationsTimer.Start();
            }
            else
            {
                NotificationsTimer.Stop();
            }
        }

        private void cuiButtonShowAllNotifications_Click(object sender, EventArgs e)
        {
            frmManageNotifications notifications = new frmManageNotifications();
            notifications.ShowDialog();

            _RefreshUnreadableNotifications();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvAppointments.CurrentRow == null) return;

            frmAddUpdateAppointment appointment = new frmAddUpdateAppointment(int.Parse(dgvAppointments.CurrentRow.Cells[0].Value.ToString()));
            appointment.ShowDialog();

            LoadData();
        }


        //Notifications
        enum enTimeMode { Soon, Due, Late}

        int currentNotificationID = -1;

        void _RefreshUnreadableNotifications()
        {
            int unreadableNotifications = 0;

            DataTable notifications = clsNotification.GetAllNotifications();

            if (notifications.Rows.Count > 0)
            {
                foreach (DataRow row in notifications.Rows)
                {
                    if (!(bool)row[5])
                    {
                        unreadableNotifications++;
                    }
                }
            }

            lblUnreadableMessage.Content = $"{unreadableNotifications} Unreadable";
        }
        void _MakeNotification(clsAppointment appointment, enTimeMode timeMode)
        {
            clsNotification notification = new clsNotification();

            notification.Date = DateTime.Now;
            notification.Time = DateTime.Now;
            
            string Message = string.Empty;

            switch (timeMode)
            {
                case enTimeMode.Soon:
                    Message = $"{appointment.PatientInfo.PersonInfo.FirstName} {appointment.PatientInfo.PersonInfo.LastName}'s appointment with Dr. {appointment.DoctorInfo.PersonInfo.FirstName} {appointment.DoctorInfo.PersonInfo.LastName} is approaching.";
                    break;
                case enTimeMode.Due:
                    Message = $"It's time for {appointment.PatientInfo.PersonInfo.FirstName} {appointment.PatientInfo.PersonInfo.LastName}'s appointment with Dr. {appointment.DoctorInfo.PersonInfo.FirstName} {appointment.DoctorInfo.PersonInfo.LastName}.";
                    break;
                case enTimeMode.Late:
                    Message = $"{appointment.PatientInfo.PersonInfo.FirstName} {appointment.PatientInfo.PersonInfo.LastName} is late for his appointment with Dr. {appointment.DoctorInfo.PersonInfo.FirstName} {appointment.DoctorInfo.PersonInfo.LastName}.";
                    break;
            }

            notification.NotificationMessage = Message;
            notification.UserID = clsProgramSettings.CurrentUser.UserID;
            notification.IsRead = false;

            if (!notification.Save())
            {
                MessageBox.Show("An error occurred while saving the person, most likely due to a connection error with the database, either because" +
                    " it was deleted or because it was moved from its expected location.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (notification.NotificationID != -1)
                currentNotificationID = notification.NotificationID;

            lblNotifyMessage.Content = Message;

            notifyIcon.Visible = true;
            notifyIcon.Icon = SystemIcons.Application;
            notifyIcon.BalloonTipText = Message;
            notifyIcon.ShowBalloonTip(1000);
            SystemSounds.Exclamation.Play();

            _RefreshUnreadableNotifications();
        }

        private void NotificationsTimer_Tick(object sender, EventArgs e)
        {
            clsAppointment appointment = new clsAppointment();

            appointment = clsAppointment.Find(new DateTime(DateTime.Now.Year, DateTime.Now.Month,
                DateTime.Now.Day, DateTime.Now.Hour, DateTime.Now.Minute, 0).AddMinutes(5));

            if (appointment != null)
            {
                _MakeNotification(appointment, enTimeMode.Soon);
            }

            appointment = clsAppointment.Find(new DateTime(DateTime.Now.Year, DateTime.Now.Month,
                DateTime.Now.Day, DateTime.Now.Hour, DateTime.Now.Minute, 0).AddMinutes(-15));

            if (appointment != null)
            {
                _MakeNotification(appointment, enTimeMode.Late);
            }

            appointment = clsAppointment.Find(new DateTime(DateTime.Now.Year, DateTime.Now.Month,
                DateTime.Now.Day, DateTime.Now.Hour, DateTime.Now.Minute, 0));

            if (appointment != null)
            {
                _MakeNotification(appointment, enTimeMode.Due);
            }
        }

        private void pnlNotifications_Click(object sender, EventArgs e)
        {
            if (currentNotificationID == -1) return;

            frmShowNotificationInfo notification = new frmShowNotificationInfo(currentNotificationID);
            notification.ShowDialog();

            _RefreshUnreadableNotifications();
        }
        ///////////////

    }
}
