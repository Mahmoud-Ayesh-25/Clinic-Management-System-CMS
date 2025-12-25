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

namespace Clinic_Manager_Proj.Patients
{
    public partial class frmSelectPatient : frmMain
    {
        public delegate void DataBackEventHandler(int ID);
        public event DataBackEventHandler DataBack;


        DataTable dtPatients = new DataTable();

        void _LoadData()
        {
            dtPatients = clsPatient.GetAllPatients();

            dgvData.DataSource = dtPatients;

            if (dgvData.Rows.Count == 0)
            {
                MessageBox.Show("There are no registered patients in the system yet.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
            else dgvData.Visible = true;

            dgvData.Columns[0].Visible = false;
            dgvData.Columns[2].Visible = false;
            dgvData.Columns[3].Visible = false;
            dgvData.Columns[4].Visible = false;
            dgvData.Columns[5].Visible = false;
            dgvData.Columns[6].Visible = false;
            dgvData.Columns[7].Visible = false;
            dgvData.Columns[8].Visible = false;

            dgvData.Columns[1].Width = dgvData.Width + 10;
        }

        void _Select()
        {
            if (dgvData.Visible == false) return;
            if (dgvData.CurrentRow == null)
            {
                MessageBox.Show("A patient must be selected first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DataBack?.Invoke(int.Parse(dgvData.CurrentRow.Cells[0].Value.ToString()));

            this.Close();
        }

        void _FilterHandler()
        {
            if (string.IsNullOrEmpty(tbxFilter.Content))
            {
                _LoadData();
            }

            DataView view = dtPatients.DefaultView;
            view.RowFilter = $"Name LIKE '{tbxFilter.Content}%'";
            dgvData.DataSource = view;
        }

        public frmSelectPatient()
        {
            InitializeComponent();

            _LoadData();
        }

        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            _Select();
        }

        private void dgvData_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                _Select();
            }
        }

        private void dgvData_DoubleClick(object sender, EventArgs e)
        {
            _Select();
        }

        private void tbxFilter_ContentChanged(object sender, EventArgs e)
        {
            _FilterHandler();
        }
    }
}
